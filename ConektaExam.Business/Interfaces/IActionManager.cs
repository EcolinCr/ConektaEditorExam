using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConektaExam.Business.Interfaces
{
    /// <summary>
    /// Interface for action manager
    /// </summary>
    public interface IActionManager
    {
        /// <summary>
        /// Execute Action
        /// </summary>
        /// <param name="action"></param>
        void ExecuteAction(string action);
    }
}
