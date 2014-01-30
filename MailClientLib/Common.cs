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
    public List<string> DomainList;
    public string selectedDomain;

    public Domains()
    {
      this.DomainList = new List<string>();
    }
  }

  public class Common
  {
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
  }
}
