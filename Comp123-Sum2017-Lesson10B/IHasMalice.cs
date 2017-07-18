using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name:Gursharan Singh
 * Date:July13,2017
 * Description: This is an interface that defines the Malice Property that
 * must be implemented in every class that subscribes to it.
 * Version:0.1 Created IHasMalice Interface
 */

namespace Comp123_Sum2017_Lesson10B
{
    public interface IHasMalice
    {
        /// <summary>
        /// This is the IHasMalice Interface
        /// </summary>
        //Public properties
        int Malice { get; set; }
    }
}