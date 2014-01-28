using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ImapX;

namespace MailClient
{
  public partial class ViewMail : Form
  {
    public ViewMail(ImapX.Message msg)
    {
      InitializeComponent();
      try
      {
        wb_msg.Navigate("about:blank");
        wb_msg.Document.Write(msg.Body.Html.ToString());
      }
      catch (Exception ex)
      {
        throw new ApplicationException("Email uid was not specified: " + ex.Message);
      }
    }
  }
}
