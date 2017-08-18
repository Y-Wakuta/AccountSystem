using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filter = System.Linq.Expressions.Expression<System.Func<AccountSystem.AccountEntity, bool>>;


namespace AccountSystem {
    class AccountRoutine {

        static public Func<AccountContext, ProductsEntity> GetProductById(int id) {
            return ctx => {
                return ctx.products
                    .Where(p => p.id == id)
                    .ToList()
                    .First();
            };
        }

        static public Func<AccountContext, AccountEntity> GetAccountById(int id) {
            return ctx => {
                return ctx.daily_account
                    .Where(a => a.id == id)
                    .ToList()
                    .First();
            };
        }

        static public Func<AccountContext, AccountEntity> GetByFilter(Filter filter) {
            return ctx => {
                return ctx.daily_account
                    .Where(filter)
                    .ToList()
                    .First();
            };
        }
    }
}
