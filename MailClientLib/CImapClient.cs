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
    public bool Connected { get { return blnConnected;} }
    public LoginCred Credidentials { set { login = value; } }
    #endregion
    #region / constructor /
    public CImapClient()
    { }
    public CImapClient(LoginCred login)
    {
      this.login = login;
    }
    #endregion
    #region / public /
    /// <summary>
    /// Connects to the imap server.
    /// </summary>
    /// <param name="login">Login credidentials containing username and password of user</param>
    /// <param name="server">Server address to connect to</param>
    public void Connect(LoginCred login, string server)
    {
      imapc = new ImapClient(server, true);
      if (imapc.Connect())
        if (imapc.Login(login.Username, login.Password))
        {
          blnConnected = true;
          imapc.Behavior.AutoPopulateFolderMessages = true;
        }
    }
    /// <summary>
    /// Disconnect from the imap server.
    /// </summary>
    public void Disconnect ()
    {
      if (imapc != null)
        imapc.Disconnect();
      blnConnected = false;
    }
    /// <summary>
    /// Get all folders from the user
    /// </summary>
    /// <returns>List of ImapX Folder objects</returns>
    public List<Folder> GetFolders()
    {
      List<Folder> ls = new List<Folder>();
      foreach (Folder folder in imapc.Folders)
        ls.Add(folder);
      return ls;
    }
    /// <summary>
    /// Delete message.
    /// </summary>
    /// <param name="msg">ImapX Message object</param>
    public void DeleteMail(Message msg)
    {
      msg.Remove();
    }
    /// <summary>
    /// Get content of users inbox.
    /// </summary>
    /// <returns>List of ImapX Message objects that reside in their inbox</returns>
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
