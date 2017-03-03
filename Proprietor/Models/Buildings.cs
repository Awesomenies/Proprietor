using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proprietor.Models
{
    public class Buildings
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public virtual City City { get; set; }

        public decimal Value { get; set; }
        public decimal Income { get; set; }
        public decimal Expense { get; set; }

        public virtual List<GameAccount> GameAccounts { get; set; }

    }
}