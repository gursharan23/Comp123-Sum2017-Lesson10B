using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/*
 * Name:Gursharan Singh
 * Date:July11,2017
 * Description: This is the super human class extends the human abstract class
 * Version:0.1 Created the super human class
 * Version:0.7 Added GetPower method 
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
        /// <summary>
        /// This private method returns the index of the power name in th power list
        /// if not found it returns -1
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Returns the index of the power in the power list by name</returns>
        private int _getPowerIndex(string name)
        {
            int index = 0;
            foreach (Power power in this.Powers)
            {
                if (name.Equals(power.Name))
                {
                    break;
                }
                index++;
                if (this.Powers.Count == index)
                {
                    index = -1;//This means that we did not find the power list.
                }
            }
            return index;
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

        /// <summary>
        /// This method returns a power object that matches the power name.
        /// If the power is not found then it will return Power not found
        /// </summary>
        /// <param name="powername"></param>
        /// <returns></returns>
        public Power getPower(string powername)
        {
            int index = this._getPowerIndex(powername);
            if (index != -1)
            { return this.Powers[index]; }
            return new Power("Power not found", 0);//means the power not found.
        }
        
    }
}