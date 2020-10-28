using ConektaExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConektaExam.Business
{
    /// <summary>
    /// Class for picture logic
    /// </summary>
    public class PictureLogic
    {
        /// <summary>
        /// Picture
        /// </summary>
        private Picture _picture;

        /// <summary>
        /// Constant color
        /// </summary>
        private const string ColorO = "O";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="picture"></param>
        public PictureLogic(Picture picture)
        {
            _picture = picture;
        }

        /// <summary>
        /// Create image
        /// </summary>
        /// <param name="n">rows</param>
        /// <param name="m">columns</param>
        public void CreatePicture(int n, int m)
        {
            _picture.N = n;
            _picture.M = m;
            _picture.PictureArray = new string[n, m];
            IteratePictureArray((i, j) => 
                _picture.PictureArray[i, j] = ColorO);
        }

        
        /// <summary>
        /// Iterate the array
        /// </summary>
        /// <param name="exec">exec action</param>
        private void IteratePictureArray(Action<int, int> exec)
        {
            for (int i = 0; i < _picture.N; i++)
            {
                for (int j = 0; j < _picture.M; j++)
                {
                    exec(i, j);
                }
            }
        }

        /// <summary>
        /// Show picture method
        /// </summary>
        public void ShowPicture()
        {
            for (int i = 0; i < _picture.N; i++)
            {
                for (int j = 0; j < _picture.M; j++)
                {
                    Console.Write("{0} ", _picture.PictureArray[i, j]);
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

        /// <summary>
        /// recursive function to fill array
        /// </summary>
        /// <param name="coordX">X</param>
        /// <param name="coordY">Y</param>
        /// <param name="otherColor">New color</param>
        public void RecursiveFill(int coordX, int coordY, string otherColor)
        {
            if (ValidSetPixel(coordX, coordY) &&
                _picture.PictureArray[coordX, coordY].Equals(_picture.PixelColor))
            {
                _picture.PictureArray[coordX, coordY] = otherColor;
                RecursiveFill(coordX + 1, coordY, otherColor);
                RecursiveFill(coordX - 1, coordY, otherColor);
                RecursiveFill(coordX, coordY + 1, otherColor);
                RecursiveFill(coordX, coordY - 1, otherColor);
            }
        }

        /// <summary>
        /// Set color pixel method
        /// </summary>
        /// <param name="coordX">X</param>
        /// <param name="coordY">Y</param>
        /// <param name="color">the color</param>
        public void SetColorPixel(int coordX, int coordY, string color)
        {
            _picture.PictureArray[coordX, coordY] = color;
        }

        /// <summary>
        /// clear picture method
        /// </summary>
        public void ClearPicture()
        {
            IteratePictureArray((i, j) 
                => _picture.PictureArray[i, j] = ColorO);
        }

        /// <summary>
        /// Validate set pixel
        /// </summary>
        /// <param name="coordX">X</param>
        /// <param name="coordY">Y</param>
        /// <returns></returns>
        private bool ValidSetPixel(int coordX, int coordY)
        {
            return coordX >= 0 && coordX < CountRows() 
                && coordY >= 0 && coordY < CountColumns();
        }

        /// <summary>
        /// Count rows method
        /// </summary>
        /// <returns></returns>
        public int CountRows() 
        {
            return _picture.N;
        }

        /// <summary>
        /// Count columns method
        /// </summary>
        /// <returns></returns>
        public int CountColumns()
        {
            return _picture.N;
        }
    }
}
