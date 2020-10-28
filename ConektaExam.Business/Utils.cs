using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConektaExam.Business
{
    /// <summary>
    /// Class for utilities
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// Validate action command
        /// </summary>
        /// <param name="action">string command</param>
        /// <param name="n">n</param>
        /// <param name="m">m</param>
        /// <returns>result</returns>
        public static bool IsActionValid(string[] action, int n, int m)
        {
            if (!(action.Length == 3))
            {
                return false;
            }

            if (!int.TryParse(action[1], out m))
            {
                return false;
            }

            if (!int.TryParse(action[2], out n))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Validate dimensions
        /// </summary>
        /// <param name="n">n</param>
        /// <param name="m">m</param>
        /// <returns>Result</returns>
        public static bool IsValidDimension(int n, int m)
        {
            return 1 <= m && 1 <= n && n <= 250;
        }

    }
}
