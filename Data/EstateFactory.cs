using Estates.Engine;
using Estates.Interfaces;
using System;
using Estates.Data.Classes;

namespace Estates.Data
{
    public class EstateFactory
    {
        public static IEstateEngine CreateEstateEngine()
        {
            return new CustomEstateEngine();
        }

        public static IEstate CreateEstate(EstateType type)
        {
            switch (type.ToString())
                {
                    case "Apartment":
                        return new Apartment(type);
                    case "Office":
                        return new Office(type);
                    case "House":
                        return new House(type);
                    case "Garage":
                        return new Garage(type);        
                    default:
                        throw new NotImplementedException("Unknown estate to create: " + type);
                }
        }

        public static IOffer CreateOffer(OfferType type)
        {
            switch (type.ToString())
            {
                case "Rent":
                    return new Rent(type);
                case "Sale":
                    return new Sale(type);               
                default:
                    throw new NotImplementedException("Unknown offer to create: " + type);
            }
        }
    }
}