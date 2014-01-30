using System;
using System.Net.Mail;
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
  public partial class SendMail : Form
  {
    #region / locals /
    private string usr, pass;
    private bool blnAttachment = false;
    private List<Attachment> attachments;
    #endregion
    #region / constructor /
    public SendMail(string usr, string pass)
    {
      InitializeComponent();
      this.usr = usr;
      this.pass = pass;
      attachments = new List<Attachment>();
    }

    public SendMail(string usr, string pass, string to) : this(usr, pass)
    {
      tb_to.Text = to;
    }
    #endregion
    #region / private /
    private void sendEmail(object sender, EventArgs e)
    {
      if (tb_to.Text == "")
        MessageBox.Show("You must enter a recipient.");
      if (rtb_message.Text == "")
        if (MessageBox.Show("Are you sure you would like to send a message with no body?",
          "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
          return;
      CSmtpClient smtp;
      if (!blnAttachment)
        smtp = new CSmtpClient(usr, pass, tb_to.Text, usr, tb_subject.Text, rtb_message.Text);
      else
        smtp = new CSmtpClient(usr, pass, tb_to.Text, usr, tb_subject.Text, rtb_message.Text, attachments.ToArray());
      smtp.sendMessage();
      MessageBox.Show("Your message was sent successfully!");
      this.Close();
    }

    private void AddAttachment(object sender, EventArgs e)
    {
      DialogResult res = openFileDialog.ShowDialog();
      if (res == DialogResult.OK)
      {
        Attachment att = new Attachment(openFileDialog.FileName);
        attachments.Add(att);
        blnAttachment = true;
      }
    }
    private void HandleAttachments(object sender, EventArgs e)
    {
      if (blnAttachment)
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

        foreach (Attachment att in attachments)
        {
          wuc.wuc_attachment attW = new wuc.wuc_attachment(att);
          attW.attachmentRemoved += new Delegates.EhAttachment(AttachmentRemovedHandler);
          flp.Controls.Add(attW);
        }
        parentForm.Controls.Add(flp);
        parentForm.Show();
      }
      else
        MessageBox.Show("No attachments have been added.");
    }
    #endregion
    #region / event handler /
    private void AttachmentRemovedHandler(Attachment attachment)
    {
      if (attachments.Count < 1)
        blnAttachment = false;
      attachments.Remove(attachment);
    }
    #endregion
  }
}
