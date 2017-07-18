using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name:Gursharan Singh
 * Date:July11,2017
 * Version:0.1 Implemented SuperVillain Class
 -*/

namespace Comp123_Sum2017_Lesson10B
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("SuperHero dude", 20);
            superHero.AddedPower("SpiderClimbing", 50);
            superHero.AddedPower("Webcasting", 40);
            superHero.AddedPower("Phasing", 30);
            Console.WriteLine(superHero.ToString());
            Console.WriteLine("Karma: " + superHero.Karma);
            Console.WriteLine("\nSuperVillain\n");
            SuperVillain supervillain = new SuperVillain("Joker", 1);
            supervillain.AddedPower("Doomsday", 10);
            supervillain.AddedPower("Unpredictable", 15);
            Console.WriteLine(supervillain.ToString());
            Console.WriteLine("Malice: " + supervillain.Malice);

            Console.WriteLine(supervillain._getPowerIndex("Doomsday"));
            
        }
    }
}
