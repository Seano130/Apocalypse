using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace FormAGettingForm
{
    public class CharacterSave
    {
        public string Root { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public CharacterSave()
        {

        }
        public void FileSave(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                XmlSerializer xml = new XmlSerializer(typeof(CharacterSave));
                xml.Serialize(fs, this);
            }
        }
    }
    
}
