using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MailClientLib;

namespace MailClient.wuc
{
  public partial class wuc_addDomain : UserControl
  {
    #region / events /
    public event Delegates.EhVoid domainAdded;
    #endregion
    #region / locals /
    private Domains domains;
    #endregion
    #region / constructor /
    public wuc_addDomain(Domains domains)
    {
      InitializeComponent();
      this.domains = domains;
    }
    #endregion
    #region / private form event /
    /// <summary>
    /// Adds domain to domain list<>
    /// </summary>
    private void b_AddDomainToList_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Are you sure you wish to add the domain: " + tb_domain.Text + "?",
        "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        domains.DomainList.Add(tb_domain.Text);
        domainAdded();
        EmptyForm parent = (EmptyForm)this.Parent;
        parent.Close();
      }
    }
    private void b_Cancel_Click(object sender, EventArgs e)
    {
      EmptyForm parent = (EmptyForm)this.Parent;
      parent.Close();
    }
    #endregion
  }
}
