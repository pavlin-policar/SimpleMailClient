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
        public string username { get {return usr;} }
        public string password { get {return pass;} }
        #endregion
        #region / constructor /
        public LoginCred(string username, string password)
        {
            this.usr = username;
            this.pass = password;
        }
        #endregion
        #region / IClonable /
        public object Clone()
        {
            return new LoginCred(this.username, this.password);
        }
        #endregion
    }
}
