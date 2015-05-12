using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
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
                var dataContractSerializer = new DataContractSerializer(typeof (T));
                return (T) dataContractSerializer.ReadObject(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Dispose();
            }

        }
    }

    internal class Program
    {
        private static void Main()
        {
            const string dateiPfad = "Kontakte.xml";
            var persistenzService = new PersistenzService();
            var kontakte = new List<Kontakt>
                           {
                               new Kontakt { Vorname = "Walter", Nachname = "White", Geburtsdatum = new DateTime(1958, 2, 20), Telefon = "12898129 8989" },
                               new Kontakt { Vorname = "Jesse", Nachname = "Pinkman", Geburtsdatum = new DateTime(1987, 5, 26), Email = "jesse@gmail.com" }
                           };

            persistenzService.Speichere(dateiPfad, kontakte);

            var geladeneKontakte = persistenzService.Lade<List<Kontakt>>(dateiPfad);
        }
    }
}