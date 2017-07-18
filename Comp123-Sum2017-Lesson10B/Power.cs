using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/*
 * Name:Gursharan Singh
 * Date:July11,2017
 * Description: This is the power class
 * Version:0.2 Added constructor
 */
namespace Comp123_Sum2017_Lesson10B
{
    /// <summary>
    /// This is the power class which is used as a datatype
    /// </summary>
    public class Power
    {

        //Public properties
        public string Name { get; set; }
        public int Rank { get; set; }
        //Constructors
        /// <summary>
        /// This is the main constructor with two arguments -name(string),rank(int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }
        // Methods

    }
}