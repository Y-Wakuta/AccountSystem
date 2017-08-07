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
        public AccountSystem() {
            InitializeComponent();
            GetAccount();
        }

        public void GetAccount() {
            var context = new AccountContext();
            var result = context.daily_account.ToList();

        }
    }
}
