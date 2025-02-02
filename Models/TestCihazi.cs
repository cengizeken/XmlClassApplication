using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlClassApplication.Models
{
    public class TestCihazi
    {
        [XmlAttribute("CihazAdi")]
        public string CihazAdi { get; set; }

        [XmlElement("KayitNo")]
        public string KayitNo { get; set; }

        [XmlElement("ModelNo")]
        public string ModelNo { get; set; }

        [XmlElement("KalibrasyonTarihi")]
        public string KalibrasyonTarihi { get; set; }
    }
}
