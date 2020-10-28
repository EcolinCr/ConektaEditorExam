using ConektaExam.Business.Interfaces;
using ConektaExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConektaExam.Business
{
    /// <summary>
    /// Cladd for manage the actions
    /// </summary>
    public class ActionManager : IActionManager
    {
        /// <summary>
        /// Exite code
        /// </summary>
        private readonly int ExiteCode = 0;

        /// <summary>
        /// Execute action method
        /// </summary>
        public void ExecuteAction(string action)
        {
            var picture = new Picture();
            var pictureLogic = new PictureLogic(picture);
            var actions = action.Split(' ');
            if(actions.Length == 0 && action != string.Empty)
            {
                NotValidOption();
            }
            else
            {
                switch (actions[0])
                {
                    case "I":
                        GeneratePicture(picture, action, pictureLogic);
                        break;
                    case "C":
                        ClearArray(action, pictureLogic);
                        break;
                    case "L":
                        SetColorInPixel(action, pictureLogic);
                        break;
                    case "V":
                        //TODO : Me falta el de la diagonal
                    case "H":
                        //TODO : Me falta el de la horizontal
                    case "F":
                        //TODO: Me falta el del rango
                    case "S":
                        CurrentInfoPicture(pictureLogic, action);
                        break;
                    case "X":
                        ExitProgram();
                        break;
                    default:
                        NotValidOption();
                        break;
                }
            }
        }

        /// <summary>
        /// Not valid option result
        /// </summary>
        private void NotValidOption()
        {
            Console.WriteLine($"Is not a valid action");
        }

        /// <summary>
        /// Gen erate picture method
        /// </summary>
        /// <param name="picture">picture object</param>
        /// <param name="action">logic object</param>
        private void GeneratePicture(Picture picture, string action, PictureLogic logic)
        {
            bool result = true;
            if (!Utils.IsActionValid(action.Split(' '),picture.N, picture.M))
            {
                Console.WriteLine($"The chosen action does not exist, please verify it");
                result = false;
            }
            if (!Utils.IsValidDimension(picture.N, picture.N))
            {
                Console.WriteLine($"The values provided they are out range");
                result = false;
            }
            if (result)
            {
                logic.CreatePicture(picture.N, picture.M);
            }
        }

        /// <summary>
        /// GClear picture
        /// </summary>
        /// <param name="action">logic object</param>
        private void ClearArray(string action, PictureLogic logic)
        {
            if (action.Length < 1)
            {
                logic.ClearPicture();
            }
            else
            {
                Console.WriteLine($"The chosen action is incorrect");
            }
        }

        /// <summary>
        /// Exit program
        /// </summary>
        private void ExitProgram()
        {
            Environment.Exit(ExiteCode);
        }

        /// <summary>
        /// Current info picture
        /// </summary>
        /// <param name="logic">logic</param>
        /// <param name="action">commands</param>
        private void CurrentInfoPicture(PictureLogic logic, string action)
        {
            var split = action.Split(' ');
            if (split.Length != 0 && split[0] == "s")
            {
                logic.ShowPicture();
            }
        }

        /// <summary>
        /// Set color Pixel
        /// </summary>
        /// <param name="actions"></param>
        /// <param name="logic"></param>
        private void SetColorInPixel(string actions, PictureLogic logic)
        {
            var split = actions.Split(' ');
            var color = string.Empty;
            int x = 0;
            int y = 0;

            if (split[3].Any(i => !char.IsLetter(i)))
            {
                return;
            }

            if (!(split.Length == 4) && !int.TryParse(split[1], out x)
                && !int.TryParse(split[2], out y))
            {
                return;
            }
            color = split[3];

            logic.SetColorPixel(x - 1, y - 1, color);

        }
    }
}
