using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MailClientLib;
using ImapX;

namespace MailClient
{
  public partial class MainWindow : Form
  {
    #region / locals /
    private CImapClient srv = null;
    private LoginCred login = null;
    private Domains domains = null;
    private wuc.wuc_login loginW = null;
    private wuc.wuc_inbox inboxW = null;

    private readonly string domainPath = "settings\\domains";
    #endregion
    #region / constructor /
    public MainWindow()
    {
      InitializeComponent();
      srv = new CImapClient();
      login = new LoginCred();

      if (File.Exists(domainPath))
      {
        try
        {
          this.domains = Common.DeserializeDomains(domainPath);
        }
        catch (Exception)
        {
          File.Delete(domainPath);
          domains = new Domains();
          domains.DomainList.Add("gmail.com");
        }
      }
      else
      {
        domains = new Domains();
        domains.DomainList.Add("gmail.com");
      }

      AddLoginWuc();
    }
    #endregion
    #region / event handler /
    private void loginHandler(bool success)
    {
      if (success)
      {
        RemoveLoginWuc();
        AddInboxWuc();
      }
    }
    #endregion
    #region / private /
    #region / wuc add/remove /
    private void AddLoginWuc()
    {
      loginW = new wuc.wuc_login(srv, login, domains);
      loginW.loginSuccessful += new Delegates.EhBool(loginHandler);
      Controls.Add(loginW);
    }
    private void RemoveLoginWuc()
    {
      Controls.Remove(loginW);
      loginW.Dispose();
      loginW = null;
    }
    private void AddInboxWuc()
    {
      inboxW = new wuc.wuc_inbox(srv, login);
      Controls.Add(inboxW);
    }
    private void RemoveInboxWuc()
    {
      Controls.Remove(inboxW);
      inboxW.Dispose();
      inboxW = null;
    }
    #endregion
    private void cleanUp(object sender, FormClosedEventArgs e)
    {
      srv.Disconnect();
      if (!Directory.Exists("settings"))
        Directory.CreateDirectory("settings");
      Common.SerializeDomains (domains, domainPath);
    }
    #endregion
  }
}
