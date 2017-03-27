using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm
{

    /*
     *      ROOM RELATED ITEMS
     */

    public enum RLocation
    {
        Border,
        Middle
    }

    public enum RoomType
    {
        Bedroom,
        Kitchen,
        LivingRoom,
        Bathroom,
        Corridor,
        Storage
    }

    public class Room
    {
        public static Room rom = null;
        public int IdHouse { get; set; }
        //public string RoomType { get; set; }
        private int romId;

        int roomID;

        RLocation category;
        RoomType type;

        int x;
        int y;

        string dLocations = "";

        Sensor[] sensors;

        public Room() { }

        public Room(int roomID, RLocation category, RoomType type, int x, int y, string doorLocations)
        {
            this.roomID = roomID;
            this.category = category;
            this.type = type;
            this.x = x;
            this.y = y;
            this.dLocations = doorLocations;
        }

        public int RoomID
        {
            get
            {
                return roomID;
            }

            set
            {
                roomID = value;
            }
        }

        public RLocation Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        public RoomType Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public string DLocations
        {
            get
            {
                return dLocations;
            }

            set
            {
                dLocations = value;
            }
        }

        public Sensor[] Sensors { get; internal set; }

        public int X1
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int RomId
        {
            get
            {
                return romId;
            }

            set
            {
                romId = value;
            }
        }

        //public sensor[] sensors
        //{
        //    get
        //    {
        //        return sensors;
        //    }

        //    set
        //    {
        //        sensors = value;
        //    }
        //}
    }
}
