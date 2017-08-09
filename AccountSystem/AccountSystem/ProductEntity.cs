using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AccountSystem {
    [Table("products", Schema = "public")]
    public class ProductsEntity : INotifyPropertyChanged {
        public int id {
            get { return _id; }
            set {
                _id = value;
                OnPropertyChanged(nameof(id));
            }
        }
        private int _id;

        public string name {
            get { return _name; }
            set {
                _name = value;
                OnPropertyChanged(nameof(name));
            }
        }
        private string _name;

        public int teika {
            get { return _teika; }
            set {
                _teika = value;
                OnPropertyChanged(nameof(teika));
            }
        }
        private int _teika;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
