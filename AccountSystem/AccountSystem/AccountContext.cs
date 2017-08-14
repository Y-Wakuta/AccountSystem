using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AccountSystem {
    public class AccountContext : DbContext {
        public AccountContext() : base("DefaultDbSource") { }

        public DbSet<AccountEntity> daily_account { get; set; }
        public DbSet<ProductsEntity> products { get; set; }
    }
}
