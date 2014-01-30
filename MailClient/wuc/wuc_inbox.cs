using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MailClientLib;

namespace MailClient.wuc
{
  public partial class wuc_inbox : UserControl
  {
    #region / locals /
    private CImapClient srv = null;
    private List<ImapX.Message> inbox;
    private LoginCred login = null;
    #endregion
    #region / constructor /
    public wuc_inbox(CImapClient srv, LoginCred login)
    {
      InitializeComponent();
      this.srv = srv;
      this.login = login;
      lv_messages.Columns[1].Width = 0;
      try
      {
        PopulateMailList();
      }
      catch (Exception ex)
      { }
    }
    #endregion
    #region / mail specific methods /
    private void PopulateMailList()
    {
      lv_messages.Items.Clear();
      inbox = srv.GetInbox();
      inbox.Sort((y, x) => DateTime.Parse(x.Date.ToString()).CompareTo(DateTime.Parse(y.Date.ToString())));

      foreach (ImapX.Message msg in inbox)
      {
        ListViewItem message = new ListViewItem("");
        if (msg.Seen == false)
          message.Font = new Font(lv_messages.Font, FontStyle.Bold);
        message.SubItems.Add(msg.UId.ToString());
        message.SubItems.Add(msg.Subject.ToString());
        message.SubItems.Add(msg.From.ToString());
        message.SubItems.Add(DateTime.Parse(msg.Date.ToString()).ToString("dd.MM.yyyy HH:mm"));
        lv_messages.Items.Add(message);
      }
    }
    private void ShowEmailMessage(object sender, EventArgs e)
    {
      long index = long.Parse(lv_messages.SelectedIndices[0].ToString());
      int uid = int.Parse(lv_messages.SelectedItems[0].SubItems[1].Text);
      ImapX.Message dmsg = (ImapX.Message)inbox.Where(x => (long)x.UId == uid).First();

      dmsg.Seen = true;
      PopulateMailList();

      ViewMail viewForm = new ViewMail(login, dmsg);
      viewForm.Show();
    }
    private void OpenMailForm(object sender, EventArgs e)
    {
      SendMail mailForm = new SendMail(login.Username, login.Password);
      mailForm.Show();
    }
    private void Refresh(object sender, EventArgs e)
    {
      PopulateMailList();
    }
    private void SelectAll(object sender, EventArgs e)
    {
      foreach (ListViewItem l in lv_messages.Items)
        l.Checked = true;
    }
    private void SelectNone(object sender, EventArgs e)
    {
      foreach (ListViewItem l in lv_messages.Items)
        l.Checked = false;
    }
    private void DeleteMessages(object sender, EventArgs e)
    {
      if (MessageBox.Show("Are you sure you want to delete these " + lv_messages.CheckedItems.Count + " messages?",
        "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        List<ImapX.Message> ls = new List<ImapX.Message>();
        long uid;
        foreach (ListViewItem item in lv_messages.CheckedItems)
        {
          uid = long.Parse(item.SubItems[1].Text);
          ls.Add((ImapX.Message)inbox.Where(x => (long)x.UId == uid).First());
        }
        foreach (ImapX.Message msg in ls)
          msg.Remove();
        PopulateMailList();
      }
    }
    private void MarkAsRead(object sender, EventArgs e)
    {
      foreach (ListViewItem item in lv_messages.CheckedItems)
        ((ImapX.Message)inbox.Where(x => (long)x.UId == (long.Parse(item.SubItems[1].Text))).First()).Seen = true;
      PopulateMailList();
    }
    private void MarkAsUnread(object sender, EventArgs e)
    {
      foreach (ListViewItem item in lv_messages.CheckedItems)
        ((ImapX.Message)inbox.Where(x => (long)x.UId == (long.Parse(item.SubItems[1].Text))).First()).Seen = false;
      PopulateMailList();
    }
    #endregion
    #region / private /
    private void lv_cancelResize(object sender, ColumnWidthChangingEventArgs e)
    {
      if (e.ColumnIndex == 1)
      {
        e.Cancel = true;
        e.NewWidth = 0;
      }
    }
    #endregion
  }
}
