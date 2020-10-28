using ConektaExam.Business;
using ConektaExam.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConektaExam
{
    /// <summary>
    /// Class program
    /// </summary>
    class Program
    {
        private IActionManager action;
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var interfaceRender = new UILogic();
            interfaceRender.MenuRender();
        }
    }
}
