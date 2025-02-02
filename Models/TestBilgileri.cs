using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlClassApplication.Models
{
    public class TestBilgileri
    {
        public string TestBaslangicZamani { get; set; }
        public string TestBitisZamani { get; set; }
        public string OperatorAdi { get; set; }
        public List<TestCihazi> TestCihazlari { get; set; } = new List<TestCihazi>();

    }
}
