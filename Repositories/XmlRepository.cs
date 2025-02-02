using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XmlClassApplication.Models;

namespace XmlClassApplication.Repositories
{
     public class XmlRepository : IXmlRepository
    {
        public Test LoadXml(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("XML file not found", filePath);

            XmlSerializer serializer = new XmlSerializer(typeof(Test));
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                return (Test)serializer.Deserialize(fileStream);
            }
        }

        public void SaveXml(string filePath, Test testData)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Test));
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(fileStream, testData);
            }
        }

        public void UpdateTestBilgileri(string filePath, TestBilgileri updatedBilgileri)
        {
            Test testData = LoadXml(filePath);
            testData.TestBilgileri = updatedBilgileri;
            SaveXml(filePath, testData);
        }

        public void UpdateTestCihazi(string filePath, TestCihazi updatedCihaz)
        {
            Test testData = LoadXml(filePath);
            var cihaz = testData.TestBilgileri.TestCihazlari.FirstOrDefault(c => c.KayitNo == updatedCihaz.KayitNo);
            if (cihaz != null)
            {
                cihaz.ModelNo = updatedCihaz.ModelNo;
                cihaz.KalibrasyonTarihi = updatedCihaz.KalibrasyonTarihi;
            }
            SaveXml(filePath, testData);
        }

        public void AddTestCihazi(string filePath, TestCihazi newCihaz)
        {
            Test testData = LoadXml(filePath);
            testData.TestBilgileri.TestCihazlari.Add(newCihaz);
            SaveXml(filePath, testData);
        }

        public void DeleteTestCihazi(string filePath, string kayitNo)
        {
            Test testData = LoadXml(filePath);
            var cihaz = testData.TestBilgileri.TestCihazlari.FirstOrDefault(c => c.KayitNo == kayitNo);
            if (cihaz != null)
            {
                testData.TestBilgileri.TestCihazlari.Remove(cihaz);
                SaveXml(filePath, testData);
            }
        }

        public void UpdateEmpedansOlcumleri(string filePath, EmpedansOlcumleri updatedOlcumleri)
        {
            Test testData = LoadXml(filePath);
            var olcum = testData.TestSonuclari.EmpedansOlcumleri.FirstOrDefault(o => o.Parametre == updatedOlcumleri.Parametre);
            if (olcum != null)
            {
                olcum.EmpedansDegerleri = updatedOlcumleri.EmpedansDegerleri;
            }
            SaveXml(filePath, testData);
        }

        public void AddEmpedansOlcumu(string filePath, string parametre, Empedans newOlcum)
        {
            Test testData = LoadXml(filePath);
            var olcum = testData.TestSonuclari.EmpedansOlcumleri.FirstOrDefault(o => o.Parametre == parametre);
            if (olcum != null)
            {
                olcum.EmpedansDegerleri.Add(newOlcum);
            }
            SaveXml(filePath, testData);
        }

        public void DeleteEmpedansOlcumu(string filePath, string parametre, double frekans)
        {
            Test testData = LoadXml(filePath);
            var olcum = testData.TestSonuclari.EmpedansOlcumleri.FirstOrDefault(o => o.Parametre == parametre);
            if (olcum != null)
            {
                var empedans = olcum.EmpedansDegerleri.FirstOrDefault(e => e.Frekans == frekans);
                if (empedans != null)
                {
                    olcum.EmpedansDegerleri.Remove(empedans);
                    SaveXml(filePath, testData);
                }
            }
        }
    }
}
