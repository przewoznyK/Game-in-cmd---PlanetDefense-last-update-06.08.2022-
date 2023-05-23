using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetDefense3
{
    public class Planet
    {
        public Planet(string name, int gold, int materials, int minerals)
        {
            this.name = name;
            this.gold = gold;
            this.materials = materials;
            this.minerals = minerals;
        }

        public Planet()
        {

        }

        public string name;
        public int gold;
        public int materials;
        public int minerals;

        public void display(int x, int y, string s)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }
        public void displayint(int x, int y, int s)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }

    }
}