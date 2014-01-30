using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ImapX;

namespace MailClient.wuc
{
  public partial class wuc_dlAttachment : UserControl
  {
    #region / locals /
    private Attachment attachment;
    #endregion
    #region / constructor /
    public wuc_dlAttachment(Attachment att)
    {
      InitializeComponent();
      this.attachment = att;
      l_FileName.Text = att.FileName;
    }
    #endregion
    #region / private form handlers /
    private void b_dlAttachment_Click(object sender, EventArgs e)
    {
      if (!Directory.Exists("downloads"))
        Directory.CreateDirectory("downloads");
      attachment.Download();
      attachment.Save("downloads", attachment.FileName);
    }
    #endregion
  }
}
