using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



/*
 * Name:Gursharan Singh
 * Date:July13,2017
 * Description: This is the SuperVillain class that inherits from SuperHuman Class
 * and implements the IHasMallice Interface.
 * Version:0.1 Created Supervillain class
 */
namespace Comp123_Sum2017_Lesson10B
{
    /// <summary>
    /// This is the supervillain class
    /// </summary>
    public class SuperVillain : SuperHuman, IHasMalice
    {

        //Private Instance Variables
        private int _malice;
        //Public Properties
        public int Malice { get { return this._malice; } set { this._malice = value; } }
        //Constructors
        /// <summary>
        /// This is the supervillain constructor 
        /// It takes two argument - name(string), malice(int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="Malice"></param>
        public SuperVillain(string name, int malice) : base(name)
        {
            this.Malice = malice;
        }
        //Public Methods 
        //Private Methods
    }
}