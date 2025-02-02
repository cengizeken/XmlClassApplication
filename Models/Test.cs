using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace XmlClassApplication.Models
{
    [XmlRoot("Test")]
    public class Test
    {
        [XmlElement("TestBilgileri")]
        public TestBilgileri TestBilgileri { get; set; }

        [XmlElement("TestSonuclari")]
        public TestSonuclari TestSonuclari { get; set; }
    }

}
