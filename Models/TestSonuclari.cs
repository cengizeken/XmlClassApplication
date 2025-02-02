using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlClassApplication.Models
{
    public class TestSonuclari
    {
        [XmlElement("EmpedansOlcumleri")]
        public List<EmpedansOlcumleri> EmpedansOlcumleri { get; set; }
    }
}
