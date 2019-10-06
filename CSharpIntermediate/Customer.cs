using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating();
        }

        private int CalculateRating()
        {
            return 0;
        }
    }

    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            //this.
        }
    }
}
