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

            Console.WriteLine();
            if (superHero is SuperHero)
            {
                Console.WriteLine("SuperHero is a superHERO");
            }
            Console.WriteLine();
            if (superHero is SuperHuman)
            {
                Console.WriteLine("SuperHero is a superhuman");
            }
            Console.WriteLine();
            if (superHero is Human)
            {
                Console.WriteLine("SuperHero is a human");
            }
           


            Console.WriteLine();
            if (superHero is object)
            {
                Console.WriteLine("SuperHero is an object");
            }
            Console.WriteLine();
            if (superHero is IHasKarma)
            {
                Console.WriteLine("SuperHero has Karma");
            }
            Console.WriteLine();
            if (superHero is SuperVillain)
            {
                Console.WriteLine("SuperHero is not a supervillain");
            }
        }
    }
}
