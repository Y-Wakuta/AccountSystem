using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Filter = System.Linq.Expressions.Expression<System.Func<AccountSystem.AccountEntity, bool>>;



namespace AccountSystem {
    public class AccountDatahandler {

        BindingList<AccountEntity> _dailyAccountList;
        BindingList<ProductsEntity> _productsList;
        AccountContext accountContext = new AccountContext();
        BindingSource _pbs;
        BindingSource _abs;

        public AccountDatahandler(BindingSource pbs, BindingSource abs) {
            _pbs = pbs;
            _abs = abs;
            GetAccount();

            _abs.CurrentItemChanged += (s, e) => currentAccountChanged();
            _pbs.CurrentItemChanged += (s, e) => currentProductChanged();
        }

        private void currentAccountChanged() {
            var cur = (AccountEntity)_abs.Current;
            _pbs.Position = int.Parse(cur.additional_number1) - 1;
        }

        private void currentProductChanged() {
            var cur = (ProductsEntity)_pbs.Current;
            ((AccountEntity)_abs.Current).additional_number1 = cur.id.ToString();
        }

        public void GetAccount() {
            _dailyAccountList = new BindingList<AccountEntity>(accountContext.daily_account.ToList());
            _productsList = new BindingList<ProductsEntity>(accountContext.products.ToList());
            _abs.DataSource = _dailyAccountList;
            _pbs.DataSource = _productsList;
        }

        public List<AccountEntity> GetAccountByFilter(Filter filter) {
            "test"
            return accountContext.daily_account.Where(filter).ToList();
        }
    }
}
