using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm
{

    /*
     *      HOUSE RELATED ITEMS
     */

    public enum AlarmS
    {
        On,
        Off,
        Set
    }

    public class House
    {
        AlarmS state;
        public static int homeIDs;

        Room[,] rooms;
        int idhome;
        string hName;

        public House() { }

        public House(int idhome, AlarmS state)
        {
            this.Idhome = idhome;
            this.state = state;
        }

        public AlarmS State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        public Room[,] Rooms
        {
            get
            {
                return rooms;
            }

            set
            {
                rooms = value;
            }
        }

        public static int HomeIDs
        {
            get
            {
                return homeIDs;
            }

            set
            {
                homeIDs = value;
            }
        }

        public int Idhome
        {
            get
            {
                return idhome;
            }

            set
            {
                idhome = value;
            }
        }

        public int size { get; internal set; }

        public string HName
        {
            get
            {
                return hName;
            }

            set
            {
                hName = value;
            }
        }
    }
}
