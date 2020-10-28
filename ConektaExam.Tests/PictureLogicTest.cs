using ConektaExam.Business;
using ConektaExam.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConektaExam.Tests
{
    [TestClass]
    public class PictureLogicTest
    {
        /// <summary>
        /// picture test object
        /// </summary>
        private Picture picture;

        /// <summary>
        /// logic test object
        /// </summary>
        private PictureLogic logic;

        /// <summary>
        /// Initialize test
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            picture = new Picture();
            logic = new PictureLogic(picture);
        }

        /// <summary>
        /// Create picture assert test
        /// </summary>
        [TestMethod]
        public void CreatePicture_Test_Assert()
        {
            int n = 5;
            int m = 5;
            logic.CreatePicture(n,m);
            Assert.IsTrue(picture.PictureArray.Length > 0);
        }
    }
}
