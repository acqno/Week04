using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControlDemo
{
    public static class InventoryDb
    {
        public static Random rand = new Random();
        public static int Honda = 500;
        public static int Mazda = 300;
        public static int Ford = 600;
        public static int Nissan = 700;

        public static int GetInventory(string car)
        {
            int result = 0;
            int delta = rand.Next(20) - 10;
            switch (car)
            {
                case "Honda":
                    result = Honda;
                    Honda += delta;
                    break;
                case "Mazda":
                    result = Mazda;
                    Mazda += delta;
                    break;
                case "Ford":
                    result = Ford;
                    Ford += delta;
                    break;
                default:
                    result = Nissan;
                    Nissan += delta;
                    break;
            }
            return result;
        }
    }
}
