using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccountFilter = System.Linq.Expressions.Expression<System.Func<AccountSystem.AccountEntity, bool>>;

namespace AccountSystem {
    class QueryBoxItems {
        static public List<QueryBoxItemBase> GetAccountSearch() {
            return new List<QueryBoxItemBase>() {
                new QueryBoxItem<AccountEntity, int>{
                    DisplayName = "id",
                    FilterBaseOpt = Option.Some<Func<int,AccountFilter>>(q => a => a.id == q)
                },
                new QueryBoxItem<AccountEntity, string> {
                    DisplayName = "name",
                    FilterBaseOpt= Option.Some<Func<string,AccountFilter>>(q=>a=> a.name.Contains(q))
                },
                new QueryBoxItem<AccountEntity, string> {
                    DisplayName = "additional number",
                    FilterBaseOpt =Option.Some<Func<string,AccountFilter>>(q => a => a.additional_number1.Contains(q))
                }
            };
        }
    }
}
