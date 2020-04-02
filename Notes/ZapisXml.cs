using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Notes
{
    class ZapisXml
    {
        public static void ZapisDanych(object Objekt, string NazwaPliku)
        {
            XmlSerializer Serializer = new XmlSerializer(Objekt.GetType());
            TextWriter Wpis = new StreamWriter(NazwaPliku);
            Serializer.Serialize(Wpis, Objekt);
            Wpis.Close();
        }
    }
}
