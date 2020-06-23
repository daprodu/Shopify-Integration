using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JTOXML
{
    public class ShopifyTransactionJSON
    {
        public Transaction[] transactions { get; set; }
    }

    public class Transaction
    {
        public long order_id { get; set; }
        public string authorization { get; set; }
    }

    
}
