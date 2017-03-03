namespace Proprietor.Models
{
    public class Accounting
    {
        public int Id { get; set; }
        public virtual GameAccount GameAccount { get; set; }

        public decimal Value { get; set; }
    }
}