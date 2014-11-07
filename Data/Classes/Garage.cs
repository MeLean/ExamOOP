using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;

namespace Estates.Data.Classes
{
    class Garage : Estate, IGarage
    {
        private const int DefaultWidth = 0;
        private const int DefaultHeight = 0;

        private const int MaxWidth = 500;
        private const int MinWidth = 0;
        private const int MaxHeight = 500;
        private const int MinHeight = 0;

        private int width;
        private int height;

        public Garage(string name, EstateType type, double area, string location, bool isFurnished,
            int width, int height) : base(name, type, area, location, isFurnished)
        {
            this.Width = width;
            this.Height = height;
        }

        public Garage(EstateType type) : base(type)
        {
            this.Width = DefaultWidth;
            this.Height = DefaultHeight;
        }

        public int Width
        {
            get
            {
                return this.width;
            }

            set
            {
                this.width = Validator.IntPropertyValidator("Width", value, MinWidth, MaxWidth);
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }

            set
            {
                this.height = Validator.IntPropertyValidator("Height", value, MinHeight, MaxHeight);
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Width: {0}, Height: {1}", this.width, this.height);
        }
    }
}
