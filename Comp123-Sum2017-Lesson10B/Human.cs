using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/*
* Name:Gursharan Singh
* Date:July11,2017
* Description: Human Abstract CLass
* Version:0.2 Added public abstract method display skill
*/

namespace Comp123_Sum2017_Lesson10B
{
    /// <summary>
    /// This is the abstract human class
    /// </summary>

    public abstract class Human
    {
        //PRIVATE INSTANCE VARIABLES

        private string _name;

        // Public Properties
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>
        /// This is the main constructor for the human class
        /// It takes one parameter -name(string)
        /// </summary>
        /// <param name="name"></param>
        //CONSTRUCTORS-----------------------------
        public Human(string name)
        {
            this.Name = name;
        }
        //PRIVATE METHODS
        //PUBLIC ABSTRACT METHODS
        public abstract void DisplaySkills();
    }
}