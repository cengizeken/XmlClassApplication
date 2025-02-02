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
    public interface IXmlRepository
    {
        Test LoadXml(string filePath);
        void SaveXml(string filePath, Test testData);
        void UpdateTestBilgileri(string filePath, TestBilgileri updatedBilgileri);
        void UpdateTestCihazi(string filePath, TestCihazi updatedCihaz);
        void AddTestCihazi(string filePath, TestCihazi newCihaz);
        void DeleteTestCihazi(string filePath, string kayitNo);
        void UpdateEmpedansOlcumleri(string filePath, EmpedansOlcumleri updatedOlcumleri);
        void AddEmpedansOlcumu(string filePath, string parametre, Empedans newOlcum);
        void DeleteEmpedansOlcumu(string filePath, string parametre, double frekans);
    }

    
}