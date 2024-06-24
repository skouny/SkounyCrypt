using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Xml.Serialization;
using System.IO;

namespace SkounyCrypt
{
    public class MySettings
    {
        [NonSerialized]
        private string FileName;
        #region public methods & properties
        // Deserialize from file and create object, if filename omitted the default is used
        public static MySettings Read()
        {
            string filename = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), 
                Application.ProductName + ".xml");
            return Read(filename);
        }
        public static MySettings Read(string filename)
        {
            MySettings obj;
            try
            {
                using (TextReader reader = new StreamReader(filename))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(MySettings));
                    obj = (MySettings)serializer.Deserialize(reader);
                }
            }
            catch
            {
                obj = new MySettings(); // if filename not already exists
            }
            obj.FileName = filename; // keep the path for saving...
            return obj;
        }
        // Serialize and save to file
        public void Save()
        {
            using (TextWriter writer = new StreamWriter(FileName))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(writer, this);
            }
        }
        #endregion
        #region the settings to manage
        public Size FormSize;
        public Point FormLocation;
        public Boolean ViewStatusBar = true;
        public Boolean ViewToolBar = true;
        public Boolean ViewToolBarText;
        public Boolean OptionWordWrap;
        #endregion

    }
}
