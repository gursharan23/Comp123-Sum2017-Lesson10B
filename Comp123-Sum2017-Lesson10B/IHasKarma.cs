using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name:Gursharan Singh
 * Date:July13,2017
 * Description: This is an interface that defines the Karma Property that
 * must be implemented in every class that subscribes to it.
 * Version:0.1 Created IHasKarma Interface
 */
namespace Comp123_Sum2017_Lesson10B
{
    /// <summary>
    /// This is the IHasKarma Interface
    /// </summary>
    public interface IHasKarma
    {

        //Public properties
        int Karma { get; set; }
    }
}