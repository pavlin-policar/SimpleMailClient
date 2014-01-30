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
    public event Delegates.EhBool loginSuccessful;
    #endregion
    #region / locals /
    private CImapClient srv;
    private LoginCred login;
    private Domains domains;
    #endregion
    #region / constructor /
    public wuc_login(CImapClient srv, LoginCred login, Domains domains)
    {
      InitializeComponent();
      this.srv = srv;
      this.login = login;
      this.domains = domains;

      FillDomains();
    }
    #endregion
    #region / private /
    private void Login(object sender, EventArgs e)
    {
      //login.Username = String.Format("{0}@{1}", tb_username.Text, cb_domains.Text);
      //login.Password = tb_password.Text;
      login.Username = "diskjokeyshaco@gmail.com";
      login.Password = "asdqwe123123";
      try
      {
        srv.Credidentials = login;
        srv.Connect(login, "imap.gmail.com");
        if (srv.Connected)
          loginSuccessful(true);
        else
          MessageBox.Show("Unable to authenticate. Please check your login credidentials.");
      }
      catch (Exception ex)
      { }
    }
    private void DomainManager(object sender, EventArgs e)
    {
      EmptyForm parentForm = new EmptyForm();
      MainWindow myParent = (MainWindow)this.Parent;
      this.Parent = myParent;
      parentForm.StartPosition = FormStartPosition.CenterParent;
      parentForm.Text = "Domain Manager";

      wuc.wuc_addDomain domainW = new wuc_addDomain(domains);
      domainW.domainAdded += new Delegates.EhVoid(FillDomains);
      parentForm.Controls.Add(domainW);
      parentForm.Show();
    }
    public void FillDomains()
    {
      cb_domains.Items.Clear();
      if (domains.DomainList.Count > 0)
      {
        foreach (string d in domains.DomainList)
          cb_domains.Items.Add(d);
        cb_domains.SelectedIndex = 0;
      }
    }
    #endregion
  }
}
