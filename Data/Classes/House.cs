using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Data.Classes
{
    class House : Estate, IHouse
    {
        private const int DefaultFloors = 0;

        private const int MinFloors = 0;
        private const int MaxFloors = 10;

        private int floors;

        public House(string name, EstateType type, double area, string location, bool isFurnished,
            int floors)
            : base(name, type, area, location, isFurnished)
        {
            this.Floors = floors;
        }

        public House(EstateType type) : base(type) 
        {
            this.Floors = DefaultFloors;
        }

        public int Floors
        {
            get
            {
                return this.floors;
            }

            set
            {
                this.floors = Validator.IntPropertyValidator("Floors", value, MinFloors, MaxFloors);                
            }
        }
        public override string ToString()
        {
            return base.ToString() + string.Format(", Floors: {0}", this.floors);
        }
    }
}
