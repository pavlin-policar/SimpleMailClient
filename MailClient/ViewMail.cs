using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MailClientLib;

namespace MailClient
{
  public partial class ViewMail : Form
  {
    #region / locals /
    private LoginCred login;
    private ImapX.Message message;
    private bool blnAttachments;
    private List<Contact> contacts;
    #endregion
    #region / constructor /
    public ViewMail(List<Contact> contacts, LoginCred login, ImapX.Message msg)
    {
      InitializeComponent();
      this.login = login;
      this.message = msg;
      this.contacts = contacts;
      if (msg.Attachments.Length > 0)
        blnAttachments = true;
      else
        blnAttachments = false;
      if (!blnAttachments)
        b_ViewAttachments.Visible = false;
      try
      {
        tb_from.Text = String.Format("From: {0}", msg.From.ToString());
        tb_subject.Text = String.Format("Subject: {0}", msg.Subject);

        wb_msg.Navigate("about:blank");
        wb_msg.Document.Write(msg.Body.Html.ToString());
      }
      catch (Exception ex)
      {
        throw new ApplicationException("Email uid was not specified: " + ex.Message);
      }
    }
    #endregion
    #region / private form methods /
    private void b_reply_Click(object sender, EventArgs e)
    {
      SendMail sm = new SendMail(contacts, login.Username, login.Password, message.From.Address, message.Subject);
      sm.Show();
    }
    private void b_forward_Click(object sender, EventArgs e)
    {
      SendMail sm = new SendMail(contacts, login.Username, login.Password, message.From.Address, message.Subject, message.Body.Text, message.From.Address);
      sm.Show();
    }
    private void b_ViewAttachments_Click(object sender, EventArgs e)
    {
      EmptyForm parentForm = new EmptyForm();
      MainWindow myParent = (MainWindow)this.Parent;
      this.Parent = myParent;
      parentForm.StartPosition = FormStartPosition.CenterParent;
      parentForm.Text = "Attachments";

      FlowLayoutPanel flp = new FlowLayoutPanel();
      flp.FlowDirection = FlowDirection.TopDown;
      flp.Height = 0;
      flp.AutoSize = true;

      foreach (ImapX.Attachment att in message.Attachments)
      {
        wuc.wuc_dlAttachment dla = new wuc.wuc_dlAttachment(att);
        flp.Controls.Add(dla);
      }
      parentForm.Controls.Add(flp);
      parentForm.Show();
    }
    #endregion
  }
}
