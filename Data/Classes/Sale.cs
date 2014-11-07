using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Data.Classes
{
    class Sale : Offer, ISaleOffer
    {
        private decimal price;

        public Sale(OfferType type, IEstate estate, decimal price) : base(type, estate)
        {
            this.Price = price;
        }

        public Sale(OfferType type) : base(type)
        {
            this.Price = 0m;
        }

        public decimal Price
        {
            get
            {
               return this.price;
            }
            set
            {
                this.price = Validator.MoneyValueValidator(value);
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Price = {0}", this.price);
        }
    }
}
