using System.Collections.Generic;
using XmlClassApplication.Models;
using XmlClassApplication.Repositories;
using XmlClassApplication.Models;
using XmlClassApplication.Repositories;

namespace XmlClassApplication.Service
{
    public class TestService
    {
        private readonly IXmlRepository xmlRepository;
        private readonly string xmlFilePath;

        public TestService(string xmlFilePath)
        {
            this.xmlFilePath = xmlFilePath;
            this.xmlRepository = new XmlRepository();
        }

        public Test GetTestData()
        {
            return xmlRepository.LoadXml(xmlFilePath);
        }

        public void SaveTestData(Test testData)
        {
            xmlRepository.SaveXml(xmlFilePath, testData);
        }
    }
}
