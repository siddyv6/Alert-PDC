using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm
{

        /*
         *      SENSOR RELATED ITEMS
         */
        public enum SensorTypeEnum
        {
            Motion,
            Temp,
        DoorPressurePad,
            GlassBreak,
        Fire
    }
        public class Sensor
        {
            int sensorID;
            SensorTypeEnum type;
            string value;

            public Sensor() { }
            public Sensor(int sensorID, SensorTypeEnum type, string value)
            {
                this.sensorID = sensorID;
                this.type = type;
                this.value = value;
            }

            public int SensorID
            {
                get
                {
                    return sensorID;
                }

                set
                {
                    sensorID = value;
                }
            }

            public SensorTypeEnum Type
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

            public string Value
            {
                get
                {
                    return value;
                }

                set
                {
                    this.value = value;
                }
            }
        
        }
    }




