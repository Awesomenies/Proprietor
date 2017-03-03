using System.Collections.Generic;

namespace Proprietor.Models
{
    public class City
    {
        public int Id { get; set; }

        public string CityName { get; set; }
        public virtual Country Country { get; set; }
        public virtual List<GameAccount> GameAccounts { get; set; }

    }
}