using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntPrepProj
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Strings());
            // Application.Run(new Matrix());
            // Application.Run(new Arrays());
            // Application.Run(new Arrays_V2());
            // Application.Run(new LinkedLists());
            // Application.Run(new Recursion());
            // Application.Run(new Numbers());
            // Application.Run(new BinaryTree());
            // Application.Run(new Stack());
            // Application.Run(new MathAndStats());
            Application.Run(new DynamicProgramming());
        }
    }
}
