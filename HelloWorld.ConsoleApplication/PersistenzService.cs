using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HelloWorld.ConsoleApplication
{
    public class PersistenzService
    {
        public void Speichere(string dateiPfad, object kontakte)
        {
            XmlWriter xmlWriter = null;
            try
            {
                var fileStream = new FileStream(dateiPfad, FileMode.Create);
                xmlWriter = XmlWriter.Create(fileStream, new XmlWriterSettings
                {
                    Indent = true,
                    IndentChars = "    ",
                    CloseOutput = true
                });
                var dataContractSerializer = new DataContractSerializer(kontakte.GetType());
                dataContractSerializer.WriteObject(xmlWriter, kontakte);
            }
            finally
            {
                if (xmlWriter != null)
                    xmlWriter.Dispose();
            }
        }

        public T Lade<T>(string dateiPfad)
        {
            XmlReader reader = null;
            try
            {
                reader = XmlReader.Create(dateiPfad);
                var dataContractSerializer = new DataContractSerializer(typeof(T));
                return (T)dataContractSerializer.ReadObject(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Dispose();
            }

        }
    }
}
