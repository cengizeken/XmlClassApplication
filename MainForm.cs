using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmlClassApplication.Models;
using XmlClassApplication.Repositories;

namespace XmlClassApplication
{
    public partial class MainForm : Form
    {
        private BindingSource testBilgileriBinding = new BindingSource();
        private BindingSource testSonuclariBinding = new BindingSource();
        private BindingList<TestCihazi> testCihazlariBinding = new BindingList<TestCihazi>();
        private BindingList<Empedans> empedansOlcumleriBinding = new BindingList<Empedans>();
        private IXmlRepository xmlRepository;
        private string xmlFilePath = "test.xml";

        public MainForm()
        {
            InitializeComponent();
            dgvKalibrasyonBilgileri.CellValueChanged += (s, e) => xmlRepository.SaveXml(xmlFilePath, testData);
            dgvKalibrasyonBilgileri.RowsRemoved += (s, e) => xmlRepository.SaveXml(xmlFilePath, testData);
            dgvEmpedansOlcumleriBeta.RowsRemoved += (s, e) => xmlRepository.SaveXml(xmlFilePath, testData);
            dgvEmpedansOlcumleriBeta.CellValueChanged += (s, e) => xmlRepository.SaveXml(xmlFilePath, testData);
            xmlRepository = new XmlRepository();
            LoadData();
        }
        Test testData;
        private void LoadData()
        {
            testData = xmlRepository.LoadXml(xmlFilePath);
            testBilgileriBinding.DataSource = testData.TestBilgileri;
            testSonuclariBinding.DataSource = testData.TestSonuclari;
            testCihazlariBinding = new BindingList<TestCihazi>(testData.TestBilgileri.TestCihazlari);

            // Beta parametresi için DataGridView bağlama
            var betaOlcumleri = testData.TestSonuclari.EmpedansOlcumleri.Find(e => e.Parametre == "Beta");
            if (betaOlcumleri != null)
            {
                empedansOlcumleriBinding = new BindingList<Empedans>(betaOlcumleri.EmpedansDegerleri);
            }

            

            tbTestBaslangicZamani.DataBindings.Clear();
            tbTestBitisZamani.DataBindings.Clear();
            tbOperatorAdi.DataBindings.Clear();
            dgvKalibrasyonBilgileri.DataBindings.Clear();
            dgvEmpedansOlcumleriBeta.DataBindings.Clear();

            tbTestBaslangicZamani.DataBindings.Add("Text", testBilgileriBinding, "TestBaslangicZamani", false, DataSourceUpdateMode.OnPropertyChanged);
            tbTestBitisZamani.DataBindings.Add("Text", testBilgileriBinding, "TestBitisZamani", false, DataSourceUpdateMode.OnPropertyChanged);
            tbOperatorAdi.DataBindings.Add("Text", testBilgileriBinding, "OperatorAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            dgvKalibrasyonBilgileri.DataSource = testCihazlariBinding;
            dgvEmpedansOlcumleriBeta.DataSource = empedansOlcumleriBinding;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var testData = new Test
            {
                TestBilgileri = (TestBilgileri)testBilgileriBinding.DataSource,
                TestSonuclari = (TestSonuclari)testSonuclariBinding.DataSource,
                
            };
            testData.TestBilgileri.TestCihazlari = new List<TestCihazi>(testCihazlariBinding);
            xmlRepository.SaveXml(xmlFilePath, testData);
            MessageBox.Show("Veriler başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCihazEkle_Click(object sender, EventArgs e)
        {
            var yeniCihaz = new TestCihazi { CihazAdi = "Yeni Cihaz", KayitNo = "0000", ModelNo = "Model", KalibrasyonTarihi = DateTime.Now.ToShortDateString() };
            testCihazlariBinding.Add(yeniCihaz);
        }

        private void btnCihazSil_Click(object sender, EventArgs e)
        {
            if (dgvKalibrasyonBilgileri.SelectedRows.Count > 0)
            {
                var cihaz = (TestCihazi)dgvKalibrasyonBilgileri.SelectedRows[0].DataBoundItem;
                testCihazlariBinding.Remove(cihaz);
            }
        }
    }
}
