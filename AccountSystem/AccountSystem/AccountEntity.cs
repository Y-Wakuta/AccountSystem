using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AccountSystem {
    [Table("daily_account", Schema = "public")]
    public class AccountEntity {
        public int id { get; set; }
        public string name { get; set; }
        public int money_total { get; set; }
        public DateTime date_time { get; set; }
        public string remarks { get; set; }
        public string additional_number1 { get; set; }
        public string additional_number2 { get; set; }
        public string additional_number3 { get; set; }
    }
}
