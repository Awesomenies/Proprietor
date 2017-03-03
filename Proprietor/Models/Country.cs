using System.Collections.Generic;

namespace Proprietor.Models
{
    public class Country
    {
        public int Id { get; set; }
        public int CountryName { get; set; }
        public virtual List<City> Cities { get; set; }

    }
}