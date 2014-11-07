using Estates.Data.Classes;
using Estates.Engine;
using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Data
{
    class CustomEstateEngine : EstateEngine, IEstateEngine
    {

        public override string ExecuteCommand(string cmdName, string[] cmdArgs)
        {
            if (cmdName =="find-rents-by-location")
	        {
		        return this.ExecuteFindRentByLocationCommand(cmdArgs[0]);
	        }
            else if (cmdName == "find-rents-by-price")
            {
                decimal minPrice = decimal.Parse(cmdArgs[0]);
                decimal maxPrice = decimal.Parse(cmdArgs[1]);
                return this.ExecuteFindRentByPriceCommand(minPrice, maxPrice);
            }
            else
	        {
                return base.ExecuteCommand(cmdName, cmdArgs);
	        }              
        }


        private string ExecuteFindRentByLocationCommand(string location)
        {
            var offers = this.Offers
                .Where(o => o.Estate.Location == location && o.Type == OfferType.Rent)
                .OrderBy(o => o.Estate.Name);
            return FormatQueryResults(offers);
        }

        private string ExecuteFindRentByPriceCommand(decimal minPrice, decimal maxPrice)
        {
            var Rents = this.Offers.Where(r => r is IRentOffer);
            var offers = Rents.Where(o => ((IRentOffer)o).PricePerMonth >= minPrice && ((IRentOffer)o).PricePerMonth <= maxPrice)
                .OrderBy(o => ((IRentOffer)o).PricePerMonth)
                .ThenBy(o => o.Estate.Name);
            return FormatQueryResults(offers);
        }
    }
}

