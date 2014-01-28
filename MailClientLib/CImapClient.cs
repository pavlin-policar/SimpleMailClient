using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ImapX;

namespace MailClientLib
{
  public class CImapClient
  {
    #region / locals /
    protected LoginCred login;
    protected ImapClient imapc;
    protected bool blnConnected = false;
    #endregion
    #region / properties /
    public string Path { get; set; }
    public bool Connected { get { return blnConnected;} }
    #endregion
    #region / constructor /
    public CImapClient(LoginCred login)
    {
      this.login = login;
    }
    #endregion
    #region / public /
    public void Connect(LoginCred login, string server)
    {
      imapc = new ImapClient(server, true);
      if (imapc.Connect())
        if (imapc.Login(login.username, login.password))
        {
          blnConnected = true;
          imapc.Behavior.AutoPopulateFolderMessages = true;
        }
    }
    public void Disconnect ()
    {
      imapc.Disconnect();
      blnConnected = false;
    }
    public List<Folder> GetFolders()
    {
      List<Folder> ls = new List<Folder>();
      foreach (Folder folder in imapc.Folders)
        ls.Add(folder);
      return ls;
    }
    public List<Message> GetInbox ()
    {
      List<Message> ls = new List<Message>();
      foreach (Message msg in imapc.Folders.Inbox.Messages)
        ls.Add(msg);
      return ls;
    }
    #endregion
  }
}
