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
  public partial class wuc_contactList : UserControl
  {
    #region / locals /
    private List<Contact> contacts = null;
    private LoginCred login;
    #endregion
    #region / construcor /
    public wuc_contactList(List<Contact> contacts, LoginCred login)
    {
      this.contacts = contacts;
      this.login = login;

      InitializeComponent();

      FillContactListView();
    }
    #endregion
    #region / private /
    private void FillContactListView()
    {
      lv_contactList.Items.Clear();
      foreach (Contact ct in contacts)
        lv_contactList.Items.Add(new ListViewItem(ct.Name));
    }
    #endregion
    #region / private form methods /
    private void b_AddContact_Click(object sender, EventArgs e)
    {
      EmptyForm ef = new EmptyForm();
      wuc.wuc_addContact addCW = new wuc.wuc_addContact(contacts);
      addCW.ContactAdded += new Delegates.EhVoid(FillContactListView);
      ef.Controls.Add(addCW);
      ef.Show();
    }
    private void b_DeleteContact_Click(object sender, EventArgs e)
    {
      string fileName = lv_contactList.SelectedItems[0].SubItems[0].Text.ToString();
      string filePath = string.Format("{0}\\{1}.contact", MainWindow.contactPath, fileName);
      contacts.Remove((Contact)contacts.Where(x => x.Name == fileName).First());
      if (File.Exists(filePath))
        File.Delete(filePath);
      FillContactListView();
    }
    private void SendMailTo(object sender, EventArgs e)
    {
      string msgTo = contacts.Where(x => x.Name == lv_contactList.SelectedItems[0].SubItems[0].Text.ToString()).First().Email;
      SendMail smf = new SendMail(login.Username, login.Password, msgTo);
      smf.Show();
    }
    #endregion
  }
}
