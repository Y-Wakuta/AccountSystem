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
            using (var context = new AccountContext()) {
                var dailyAccountList = context.daily_account.ToList();
                var productsList = context.products.ToList();

            }

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e) {

        }
    }
}
