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
    private bool attachment = false;
    private Attachment att;
    #endregion
    #region / constructor /
    public SendMail(string usr, string pass)
    {
      InitializeComponent();
      this.usr = usr;
      this.pass = pass;
    }

    public SendMail(string usr, string pass, string to)
    {
      InitializeComponent();
      this.usr = usr;
      this.pass = pass;
      tb_to.Text = to;
    }
    #endregion
    #region / private /
    private void sendEmail(object sender, EventArgs e)
    {
      CSmtpClient smtp;
      if (!attachment)
        smtp = new CSmtpClient(usr, pass, tb_to.Text, usr, tb_subject.Text, rtb_message.Text);
      else
        smtp = new CSmtpClient(usr, pass, tb_to.Text, usr, tb_subject.Text, rtb_message.Text, att);
      smtp.sendMessage();
      MessageBox.Show("Your message was sent successfully!");
      this.Close();
    }

    private void AddAttachment(object sender, EventArgs e)
    {
      DialogResult res = openFileDialog.ShowDialog();
      if (res == DialogResult.OK)
      {
        att = new Attachment(openFileDialog.FileName);
        attachment = true;
        l_attachmentName.Text = openFileDialog.FileName;
      }
    }

    private void RemoveAttachment(object sender, EventArgs e)
    {
      openFileDialog.Reset();
      l_attachmentName.Text = "";
    }
    #endregion
  }
}
