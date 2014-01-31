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

    private List<Contact> contacts = null;

    public static readonly string contactPath = "contacts";
    public static string domainPath = "settings\\domains";
    #endregion
    #region / constructor /
    public MainWindow()
    {
      InitializeComponent();
      srv = new CImapClient();
      login = new LoginCred();

      GetDomains();
      GetContacts();

      AddLoginWuc();
    }
    #endregion
    #region / event handler /
    /// <summary>
    /// Replaces the login user control with the inbox user control.
    /// </summary>
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
    /// <summary>
    /// Add and show the login user control.
    /// </summary>
    private void AddLoginWuc()
    {
      loginW = new wuc.wuc_login(srv, login, domains);
      loginW.loginSuccessful += new Delegates.EhBool(loginHandler);
      Controls.Add(loginW);
    }
    /// <summary>
    /// Hide and dispose of the login user control.
    /// </summary>
    private void RemoveLoginWuc()
    {
      Controls.Remove(loginW);
      loginW.Dispose();
      loginW = null;
    }
    /// <summary>
    /// Add and show the inbox user control.
    /// </summary>
    private void AddInboxWuc()
    {
      inboxW = new wuc.wuc_inbox(srv, login, contacts);
      Controls.Add(inboxW);
    }
    /// <summary>
    /// Hide and dispose of the inbodx user control.
    /// </summary>
    private void RemoveInboxWuc()
    {
      Controls.Remove(inboxW);
      inboxW.Dispose();
      inboxW = null;
    }
    #endregion
    /// <summary>
    /// Function writes settings and contacts to respective files and disconnects the server.
    /// </summary>
    private void cleanUp(object sender, FormClosedEventArgs e)
    {
      srv.Disconnect();
      // domains
      if (!Directory.Exists("settings"))
        Directory.CreateDirectory("settings");
      Common.SerializeDomains (domains, domainPath);
      // contacts
      if (contacts.Count > 0)
      {
        string fileName = string.Empty;
        if (!Directory.Exists(contactPath))
          Directory.CreateDirectory(contactPath);
        foreach (Contact ct in contacts)
        {
          fileName = string.Format("{0}.contact", ct.Name);
          if (!File.Exists(string.Format("{0}\\{1}", contactPath, fileName)))
            Common.SerializeContact(ct, fileName);
        }
      }
    }
    /// <summary>
    /// Checks if the domain file exists; if so, deserialize it, if not, create the list and add default domain.
    /// </summary>
    private void GetDomains()
    {
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
    }
    /// <summary>
    /// Checks if directory path exists and loops over files, deserializing them
    /// </summary>
    private void GetContacts()
    {
      contacts = new List<Contact>();
      if (Directory.Exists(contactPath))
      {
        Contact ct = null;
        foreach (string f in Directory.GetFiles(contactPath, "*.contact"))
        {
          ct = Common.DeserializeContact(f);
          contacts.Add(ct);
        }
      }
    }
    #endregion
  }
}
