using CruzSebastianTaller1P3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CruzSebastianTaller1P3.ViewModels
{
    public class LibroViewModelSC : INotifyPropertyChanged
    {
        private LibroSC _libro;
        public LibroSC Libro
        {
            get { return _libro; }
            set { _libro = value;
                OnPropertyChanged(nameof(LibroSC));}
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
