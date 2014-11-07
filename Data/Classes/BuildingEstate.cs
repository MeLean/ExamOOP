using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Data.Classes
{
    public abstract class BuildingEstate : Estate, IBuildingEstate
    {
        private const int DefaultRoomsCount = 0;
        private const bool DefaultHasElevator = false;

        private const int MinRooms = 0;
        private const int MaxRooms = 20;

        private int rooms;
        private bool hasElevator;

        public BuildingEstate(string name, EstateType type, double area, string location, bool isFurnished,
            int rooms, bool hasElevator) : base (name, type, area, location, isFurnished)
        {
            this.Rooms = rooms;
            this.HasElevator = hasElevator;
        }

        public BuildingEstate(EstateType type)
            : base(type)
        {
            this.Rooms = DefaultRoomsCount;
            this.HasElevator = DefaultHasElevator;
        }    
       
        public int Rooms
        {
            get
            {
                return this.rooms;
            }

            set
            {
                this.rooms = Validator.IntPropertyValidator("Rooms", value, MinRooms, MaxRooms);                
            }
        }

        public bool HasElevator
        {
            get
            {
                return this.hasElevator;
            }

            set
            {
                this.hasElevator = value;
            }
        }

        public override string ToString()
        {
            string hasElevatorStr = Validator.BooleanToString(hasElevator);

            return base.ToString() + string.Format(", Rooms: {0}, Elevator: {1}", this.rooms, hasElevatorStr);
        }
    }
}
