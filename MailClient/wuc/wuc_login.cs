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
using MailClient;

namespace MailClient.wuc
{
  public partial class wuc_login : UserControl
  {
    #region / events /
    public event Delegates.EhLogin loginSuccessful;
    #endregion
    #region / locals /
    private CImapClient srv = null;
    #endregion
    #region / constructor /
    public wuc_login(CImapClient srv)
    {
      InitializeComponent();
      this.srv = srv;
    }
    #endregion
    #region / private /
    private void Login(object sender, EventArgs e)
    {
      //LoginCred login = new LoginCred(tb_username.Text + "@" + cb_domains.SelectedText, tb_password.Text);
      LoginCred login = new LoginCred("diskjokeyshaco@gmail.com", "asdqwe123123");
      try
      {
        srv = new CImapClient(login);
        srv.Connect(login, "imap.gmail.com");
        if (srv.Connected)
          loginSuccessful(true);
        else
          MessageBox.Show("Unable to authenticate. Please check your login credidentials.");
      }
      catch (Exception ex)
      { }
    }
    #endregion
  }
}
