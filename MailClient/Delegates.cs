using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace MailClient
{
  public class Delegates
  {
    public delegate void EhBool(bool blnLogin);
    public delegate void EhAttachment(Attachment attachment);
  }
}
