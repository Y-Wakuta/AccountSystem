using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;

using Filter = System.Linq.Expressions.Expression<System.Func<AccountSystem.AccountEntity, bool>>;




namespace AccountSystem {
    public partial class AccountSystem : Form {

        AccountDatahandler _adh;

        public AccountSystem() {
            InitializeComponent();
            _adh = new AccountDatahandler(productEntityBindingSource, accountEntityBindingSource);
            _adh.GetAccount();
            queryBoxSearch.Initialize(QueryBoxItems.GetAccountSearch());
        }

        private void buttonSearch_Click(object sender, EventArgs e) {
            var account = _adh.GetAccountByFilter(MakeFilter());
        }

        private Filter MakeFilter() {
            Filter filter = a => true;
            queryBoxSearch.FilterOpt<AccountEntity>().ForEach(f => filter = filter.And(f));
            return filter;
        }
    }
}
