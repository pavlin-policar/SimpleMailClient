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

using MailClientLib;

namespace MailClient.wuc
{
  public partial class wuc_viewContact : UserControl
  {
    #region / events /
    public event Delegates.EhVoid ContactEdited;
    #endregion
    #region / locals /
    private Contact contact = null;
    #endregion
    #region / constructor /
    public wuc_viewContact(Contact contact)
    {
      this.contact = contact;

      InitializeComponent();

      tb_fname.Text = contact.FirstName;
      tb_mname.Text = contact.MiddleName;
      tb_lname.Text = contact.LastName;
      tb_email.Text = contact.Email;
      tb_tel.Text = contact.Telephone;
      tb_address.Text = contact.Address;
      tb_city.Text = contact.City;
      tb_pcode.Text = contact.PostalCode;
      tb_country.Text = contact.PostalCode;
    }
    #endregion
    #region / private form methods /
    private void b_SaveChanges_Click(object sender, EventArgs e)
    {
      bool blnChanged = false;
      #region / ifs /
      if (tb_fname.Text != contact.FirstName)
      {
        contact.FirstName = tb_fname.Text;
        blnChanged = true;
      }
      if (tb_mname.Text != contact.MiddleName)
      {
        contact.MiddleName = tb_mname.Text;
        blnChanged = true;
      }
      if (tb_lname.Text != contact.LastName)
      {
        contact.LastName = tb_lname.Text;
        blnChanged = true;
      }
      if (tb_email.Text != contact.Email)
      {
        contact.Email = tb_email.Text;
        blnChanged = true;
      }
      if (tb_tel.Text != contact.Telephone)
      {
        contact.Telephone = tb_tel.Text;
        blnChanged = true;
      }
      if (tb_address.Text != contact.Address)
      {
        contact.Address = tb_address.Text;
        blnChanged = true;
      }
      if (tb_city.Text != contact.City)
      {
        contact.City = tb_city.Text;
        blnChanged = true;
      }
      if (tb_pcode.Text != contact.PostalCode)
      {
        contact.PostalCode = tb_pcode.Text;
        blnChanged = true;
      }
      if (tb_country.Text != contact.Country)
      {
        contact.Country = tb_country.Text;
        blnChanged = true;
      }
      #endregion
      if (blnChanged)
      {
        string oldFileName = string.Format("{0}\\{1}.contact", MainWindow.contactPath, contact.Name);
        contact.Name = string.Format("{0} {1}", contact.FirstName, contact.LastName);
        string fileName = string.Format("{0}\\{1}.contact", MainWindow.contactPath, contact.Name);
        File.Delete(oldFileName);
        Common.SerializeContact(contact, fileName);
        ContactEdited();
      }
      b_cancel_Click(sender, e);
    }
    private void b_cancel_Click(object sender, EventArgs e)
    {
      EmptyForm parent = (EmptyForm)this.Parent;
      parent.Close();
      parent.Dispose();
    }
    #endregion
  }
}
