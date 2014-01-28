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
using ImapX;

namespace MailClient
{
  public partial class MainWindow : Form
  {
    #region / locals /
    private CImapClient srv = null;
    private wuc.wuc_login loginW = null;
    private wuc.wuc_inbox inboxW = null;
    #endregion
    #region / constructor /
    public MainWindow()
    {
      InitializeComponent();
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
    private void AddLoginWuc()
    {
      loginW = new wuc.wuc_login(srv);
      loginW.loginSuccessful += new Delegates.EhLogin(loginHandler);
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
      inboxW = new wuc.wuc_inbox(srv);
      Controls.Add(inboxW);
    }
    private void RemoveInboxWuc()
    {
      Controls.Remove(inboxW);
      inboxW.Dispose();
      inboxW = null;
    }
    private void cleanUp(object sender, FormClosedEventArgs e)
    {
      try
      {
        srv.Disconnect();
      }
      catch (Exception ex) { }
    }
    private void lv_cancelResize(object sender, ColumnWidthChangingEventArgs e)
    {
      if (e.ColumnIndex == 0)
      {
        e.Cancel = true;
        e.NewWidth = 0;
      }
    }
    #endregion
  }
}
