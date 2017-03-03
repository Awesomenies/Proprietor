using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proprietor.Models
{
    public class GameAccount
    {
        public int Id { get; set; }
        //public virtual UserAccount UserAccount { get; set; }

        public virtual List<Accounting> Accountings { get; set; }
        public string CurrentLocation { get; set; }

    }
}