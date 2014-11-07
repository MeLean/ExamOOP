using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Data.Classes
{
    public abstract class Estate : IEstate
    {
        private const string DefaultName = "None";
        private const double DefaultArea = 0.0;
        private const string DefaultLocation = "Not Specified";
        private const bool DefaultIsFurnished = false;

        private const int MinArea = 0;
        private const int MaxArea = 10000;

        private string name;
        private EstateType type;
        private double area;
        private string location;
        private bool isFurnished;

        public Estate(string name, EstateType type, double area, string location, bool isFurnished) 
        {
            this.Name = name;
            this.Type = type;
            this.Area = area;
            this.Location = location;
            this.IsFurnished = isFurnished;
        }

        public Estate(EstateType type) 
            : this(DefaultName, type, DefaultArea, DefaultLocation, DefaultIsFurnished)
        {           
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentNullException("Estate name can not be empty!");
                }
            }
        }

        public EstateType Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.type = value;
            }
        }

        public double Area
        {
            get
            {
                return this.area;
            }

            set
            {
                this.area = Validator.DoublePropertyValidator("Area", value, MinArea, MaxArea);      
            }
        }

        public string Location
        {
            get
            {
                return this.location;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.location = value;
                }
                else
                {
                    throw new ArgumentNullException("Estate location can not be empty!");
                }
            }
        }

        public bool IsFurnished
        {
            get
            {
                return this.isFurnished;
            }

            set
            {
                this.isFurnished = value;
            }
        }

        public override string ToString()
        {
            string furnuituredStr = Validator.BooleanToString(isFurnished);

            return string.Format(
                "{0}: Name = {1}, Area = {2}, Location = {3}, Furnitured = {4}", 
                this.GetType().Name,
                this.name,
                this.area,
                this.location,
                furnuituredStr);
        }
    }
}
