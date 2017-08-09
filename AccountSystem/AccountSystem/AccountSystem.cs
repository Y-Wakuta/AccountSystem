using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace AccountSystem {
    public partial class AccountSystem : Form {

        AccountDatahandler _adh;

        public AccountSystem() {
            InitializeComponent();
            _adh = new AccountDatahandler(productEntityBindingSource, accountEntityBindingSource);
            _adh.GetAccount();
        }
    }
}
