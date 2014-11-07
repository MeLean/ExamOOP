using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Data.Classes
{
    class Rent : Offer, IRentOffer
    {
        private decimal pricePerMonth;

        public Rent(OfferType type, IEstate estate, decimal pricePerMonth)
            : base(type, estate)
        {
            this.PricePerMonth = pricePerMonth;
        }

        public Rent(OfferType type) : base(type)
        {
            
        }


        public decimal PricePerMonth
        {
            get
            {
                return this.pricePerMonth;
            }
            set
            {
                this.pricePerMonth = Validator.MoneyValueValidator(value);
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Price = {0}", this.pricePerMonth);
        }
    }
}
