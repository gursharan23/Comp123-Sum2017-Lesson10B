using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/*
 * Name:Gursharan Singh
 * Date:July11,2017
 * Description: This is the super human class extends the human abstract class
 * Version:0.1 Created the super human class
 * Version:0.6 Added Stub  method DisplaySkills to confirm to Human Abstract Superclass
 */
namespace Comp123_Sum2017_Lesson10B
{
    /// <summary>
    /// This is the super human class
    /// </summary>
    public class SuperHuman : Human
    {
        //Private instance variables
        /// <summary>
        /// This is the main constructor
        /// </summary>
        private List<Power> _powers;
        //Public properties
        public List<Power> Powers
        {
            get
            { return this._powers; }
        }
        //Constructors
        public SuperHuman(string name) : base(name)
        {
            this._initializer();
        }
        //Private methods
        private void _initializer()
        {
            this._powers = new List<Power>();//creates an empty list
        }
        //Public methods
        public void AddedPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }
        /// <summary>
        /// This method displays each of the powers stored in the powers list
        /// </summary>
        public void DiplayPower()
        {
            foreach (Power power in this.Powers)
            {
                Console.WriteLine("Power" + power.Name + "Rank:" + power.Rank);
            }
        }
        //Public ovverridden ToString method
        public override string ToString()
        {
            string Outputstring = "";
            Outputstring += "=======================================\n";
            Outputstring += "SuperHuman Name: " + this.Name + "\n";
            foreach (Power power in this.Powers)

            {
                Outputstring += "Name: " + power.Name + " Rank: " + power.Rank + "\n";
            }
            Outputstring += "=======================================\n";
            return Outputstring;

        }
        /// <summary>
        /// This is the DisplaySkills Method.
        /// Need to be Implemented.
        /// </summary>
        public override void DisplaySkills()
        {
            Console.WriteLine("Not Implemented");
        }
    }
}