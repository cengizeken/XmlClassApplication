using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlClassApplication.Models
{
public class EmpedansOlcumleri
    {
        [XmlAttribute("Parametre")]
        public string Parametre { get; set; }

        [XmlElement("Empedans")]
        public BindingList<Empedans> EmpedansDegerleri { get; set; }// = new BindingList<Empedans>();
    }
}
