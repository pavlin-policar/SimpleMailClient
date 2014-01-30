using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace MailClient.wuc
{
  public partial class wuc_attachment : UserControl
  {
    #region / events /
    public event Delegates.EhAttachment attachmentRemoved;
    #endregion
    #region / locals /
    private Attachment attachment;
    #endregion
    #region / constructor /
    public wuc_attachment(Attachment att)
    {
      InitializeComponent();
      this.attachment = att;
      l_FileName.Text = att.Name;
    }
    #endregion
    #region / private form handlers /
    private void b_removeAttachment_Click(object sender, EventArgs e)
    {
      attachmentRemoved(attachment);
      this.Dispose();
    }
    #endregion
  }
}
