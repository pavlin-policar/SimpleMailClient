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
    #endregion
    #region / constructor /
    public wuc_inbox(CImapClient srv)
    {
      InitializeComponent();
      this.srv = srv;
      lv_messages.Columns[0].Width = 0;
      if (srv == null)
        label1.Text = "null";
      else label1.Text = "notnull";
      try
      {
        PopulateMailList();
      }
      catch (Exception ex)
      { }
    }
    #endregion
    #region / private /
    private void PopulateMailList()
    {
      lv_messages.Items.Clear();
      inbox = srv.GetInbox();
      inbox.Sort((y, x) => DateTime.Parse(x.Date.ToString()).CompareTo(DateTime.Parse(y.Date.ToString())));

      foreach (ImapX.Message msg in inbox)
      {
        ListViewItem message = new ListViewItem(msg.UId.ToString());
        if (msg.Seen == false)
          message.Font = new Font(lv_messages.Font, FontStyle.Bold);
        message.SubItems.Add(msg.Subject.ToString());
        message.SubItems.Add(msg.From.ToString());
        message.SubItems.Add(msg.Date.ToString());
        lv_messages.Items.Add(message);
      }
    }
    private void ShowEmailMessage(object sender, EventArgs e)
    {
      long index = long.Parse(lv_messages.SelectedIndices[0].ToString());
      int uid = int.Parse(lv_messages.SelectedItems[0].SubItems[0].Text);
      ImapX.Message dmsg = (ImapX.Message)inbox.Where(x => (long)x.UId == uid).First();

      dmsg.Seen = true;
      PopulateMailList();

      ViewMail viewForm = new ViewMail(dmsg);
      viewForm.Show();
    }
    private void OpenMailForm(object sender, EventArgs e)
    {
      SendMail mailForm = new SendMail("diskjokeyshaco@gmail.com", "asdqwe123123");
      mailForm.Show();
    }
    #endregion
  }
}
