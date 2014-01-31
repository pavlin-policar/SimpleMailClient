using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using MailClientLib;

namespace MailClient.wuc
{
  public partial class wuc_addContact : UserControl
  {
    #region / events /
    public event Delegates.EhVoid ContactAdded;
    #endregion
    #region / locals /
    private List<Contact> contacts = null;
    #endregion
    #region / constructor /
    public wuc_addContact(List<Contact> contacts)
    {
      this.contacts = contacts;
      InitializeComponent();
    }
    #endregion
    #region / private form methods /
    /// <summary>
    /// Adds contact and writes to file and closes parent form.
    /// </summary>
    private void b_AddContact_Click(object sender, EventArgs e)
    {
      if (tb_fname.Text == "" || tb_email.Text == "")
        MessageBox.Show("You must enter a name and email to add a contact.");
      else if (!Regex.Match(tb_email.Text, @"\w+([\.-_]?\w+)*@\w+([\.-]?\w+)*", RegexOptions.IgnoreCase).Success)
        MessageBox.Show("Please enter a valid email.");
      else
      {
        Contact ct = new Contact(tb_fname.Text, tb_lname.Text, tb_email.Text);
        if (tb_mname.Text != "")
          ct.MiddleName = tb_mname.Text;
        if (tb_tel.Text != "")
          ct.Telephone = tb_tel.Text;
        if (tb_address.Text != "")
          ct.Address = tb_address.Text;
        if (tb_city.Text != "")
          ct.City = tb_city.Text;
        if (tb_pcode.Text != "")
          ct.PostalCode = tb_pcode.Text;
        if (tb_country.Text != "")
          ct.Country = tb_country.Text;
        contacts.Add(ct);

        if (!Directory.Exists(MainWindow.contactPath))
          Directory.CreateDirectory(MainWindow.contactPath);
        Common.SerializeContact(ct, string.Format("{0}\\{1}.contact", MainWindow.contactPath, ct.Name));

        ContactAdded();

        EmptyForm parent = (EmptyForm)this.Parent;
        parent.Close();
      }
    }
    #endregion
  }
}
