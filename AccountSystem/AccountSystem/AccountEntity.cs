using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AccountSystem {
    [Table("daily_account", Schema = "public")]
    public class AccountEntity : INotifyPropertyChanged {
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

        public int money_total {
            get { return _money_total; }
            set {
                _money_total = value;
                OnPropertyChanged(nameof(money_total));
            }
        }
        private int _money_total;

        public DateTime date_time { get; set; }

        public string remarks {
            get { return _remarks; }
            set {
                _remarks = value;
                OnPropertyChanged(nameof(remarks));
            }
        }
        private string _remarks;


        public string additional_number1 {
            get { return _additional_number1; }
            set {
                _additional_number1 = value;
                OnPropertyChanged(nameof(additional_number1));
            }
        }
        private string _additional_number1;


        public string additional_number2 {
            get { return _additional_number2; }
            set {
                _additional_number2 = value;
                OnPropertyChanged(nameof(additional_number2));
            }
        }
        private string _additional_number2;


        public string additional_number3 {
            get { return _additional_number3; }
            set {
                _additional_number3 = value;
                OnPropertyChanged(nameof(additional_number1));
            }
        }
        private string _additional_number3;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
    
}
