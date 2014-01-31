using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MailClientLib
{
  [Serializable]
  public class Domains
  {
    public List<string> DomainList { get; set; }
    public string selectedDomain { get; set; }

    public Domains()
    {
      this.DomainList = new List<string>();
    }
  }

  [Serializable]
  public class Contact
  {
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Telephone { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }

    public Contact() { }

    public Contact(string fname, string lname, string email)
    {
      this.FirstName = fname;
      this.LastName = lname;
      this.Name = string.Format("{0} {1}", fname, lname);
      this.Email = email;
    }
  }

  public class Common
  {
    /// <summary>
    /// Serialize Domain object.
    /// </summary>
    /// <param name="serializableObject">The Domain object you would like to serialize</param>
    /// <param name="fileName">The path string you would like the file to be saved</param>
    public static void SerializeDomains(Domains serializableObject, string fileName)
    {
      if (serializableObject == null)
        return;
      XmlSerializer xmls = new XmlSerializer(typeof(Domains));
      Stream stream = File.Open(fileName, FileMode.Create);
      xmls.Serialize(stream, serializableObject);
      stream.Close();
      stream.Dispose();
    }
    /// <summary>
    /// Deserialize Domain object.
    /// </summary>
    /// <param name="fileName">The path string where the serialized object is loacted</param>
    /// <returns></returns>
    public static Domains DeserializeDomains(string fileName)
    {
      Domains dm;
      XmlSerializer xmls = new XmlSerializer(typeof(Domains));
      Stream stream = File.Open(fileName, FileMode.Open);
      dm = (Domains)xmls.Deserialize(stream);
      stream.Close();
      stream.Dispose();
      return dm;
    }
    /// <summary>
    /// Serialize Contact object.
    /// </summary>
    /// <param name="serializableObject">The Contact object you would like to serialize</param>
    /// <param name="fileName">The path string you would like the file to be saved</param>
    public static void SerializeContact(Contact contact, string fileName)
    {
      if (contact == null)
        return;
      XmlSerializer xmls = new XmlSerializer(typeof(Contact));
      Stream stream = File.Open(fileName, FileMode.Create);
      xmls.Serialize(stream, contact);
      stream.Close();
      stream.Dispose();
    }/// <summary>
    /// Deserialize Contact object.
    /// </summary>
    /// <param name="fileName">The path string where the serialized object is loacted</param>
    /// <returns></returns>
    public static Contact DeserializeContact(string fileName)
    {
      Contact ct;
      XmlSerializer xmls = new XmlSerializer(typeof(Contact));
      Stream stream = File.Open(fileName, FileMode.Open);
      ct = (Contact)xmls.Deserialize(stream);
      stream.Close();
      stream.Dispose();
      return ct;
    }
  }
}
