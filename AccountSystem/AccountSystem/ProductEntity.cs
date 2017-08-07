using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AccountSystem {
    [Table("products", Schema = "public")]
    public class ProductEntity {
        public int id { get; set; }
        public string name { get; set; }
        public int teika { get; set; }
    }
}
