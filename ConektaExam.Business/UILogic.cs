using ConektaExam.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConektaExam.Business
{
    /// <summary>
    /// Class for UI program
    /// </summary>
    public class UILogic
    {
        /// <summary>
        /// Action manager interface
        /// </summary>
        private IActionManager actionManager;

        /// <summary>
        /// Constructor
        /// </summary>
        public UILogic()
        {
            actionManager = new ActionManager();
        }

        /// <summary>
        /// Method for menu render
        /// </summary>
        public void MenuRender()
        {
            Console.WriteLine("Insert the comands...");

            for(;;)
            {
                actionManager.ExecuteAction(Console.ReadLine().ToUpper());
            }
        }
    }
}
