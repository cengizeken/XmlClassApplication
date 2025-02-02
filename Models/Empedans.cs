using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlClassApplication.Models
{
    public class Empedans : INotifyPropertyChanged
    {
        private int _frekans;
        private double _altLimit;
        private double _olculenDeger;
        private double _ustLimit;
        private string _gectiKaldi;

        [XmlElement("Frekans")]
        public int Frekans
        {
            get => _frekans;
            set
            {
                _frekans = value;
                OnPropertyChanged(nameof(Frekans));
            }
        }

        [XmlElement("AltLimit")]
        public double AltLimit
        {
            get => _altLimit;
            set
            {
                _altLimit = value;
                OnPropertyChanged(nameof(AltLimit));
            }
        }

        [XmlElement("OlculenDeger")]
        public double OlculenDeger
        {
            get => _olculenDeger;
            set
            {
                _olculenDeger = value;
                OnPropertyChanged(nameof(OlculenDeger));
            }
        }

        [XmlElement("UstLimit")]
        public double UstLimit
        {
            get => _ustLimit;
            set
            {
                _ustLimit = value;
                OnPropertyChanged(nameof(UstLimit));
            }
        }

        [XmlElement("GectiKaldi")]
        public string GectiKaldi
        {
            get => _gectiKaldi;
            set
            {
                _gectiKaldi = value;
                OnPropertyChanged(nameof(GectiKaldi));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
