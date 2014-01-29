using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailClientLib
{
  public class LoginCred : ICloneable
  {
    #region / locals /
    private string usr, pass;
    #endregion
    #region / properties /
    public string Username { get { return usr; } set { usr = value; } }
    public string Password { get { return pass; } set { pass = value; } }
    #endregion
    #region / constructor /
    public LoginCred()
    { }
    public LoginCred(string username, string password)
    {
      this.usr = username;
      this.pass = password;
    }
    #endregion
    #region / IClonable /
    public object Clone()
    {
      return new LoginCred(this.usr, this.pass);
    }
    #endregion
  }
}
