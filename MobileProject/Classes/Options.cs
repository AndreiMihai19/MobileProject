using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileProject.Classes
{
    class Options
    {
        private static int lights;
        private static int temperature = 18;
        private static int door_status = 1;

        //public int getLights() { return lights;}

        //public void setLights(int value) { lights = value; }

        public static int GetTemperature() { return temperature; }

        public static string GetDoorStatus()
        {
            if (door_status == 1)
            {
                return "Open";
            }
            else
                return "Closed";
        }
            // return door_status; }
        public static void Door_Open(){ door_status = 1; }
        public static void Door_Close(){ door_status = 0; }

        public static void IncreaseTemperature() { temperature++; }

        public static void DecreaseTemperature() { temperature--; }

        //public int getDoorStatus() {  return door_status; }

        //public void setDoorStatus(int value) {  door_status = value; }
    }
}
