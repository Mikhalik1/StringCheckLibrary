using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StringCheckLibrary;

namespace StringChecTest
{
    [TestClass]
    public class StringCheckTest
    {

        //Верные тесты


        /// <summary>
        /// Тест на правилое имя
        /// </summary>
        [TestMethod]
        public void CheckName_Truename_returnedtrue()
        {
            //Arrange
            string text = "Андреев Егор Давидович";

            //Act
            StringCheck obj = new StringCheck();
            bool result = obj.CheckName(text);

            //Assert
            Assert.IsTrue(result);
        }


        /// <summary>
        /// Тест на тире после фамилии
        /// </summary>
        [TestMethod]
        public void CheckName_dashFIO_returnedtrue()
        {
            //Arrange
            string text = "Андреев-Егор Давидович";

            //Act
            StringCheck obj = new StringCheck();
            bool result = obj.CheckName(text);

            //Assert
            Assert.IsTrue(result);
        }



        /// <summary>
        /// Тест на тире после имеени
        /// </summary>
        [TestMethod]
        public void CheckName_fidasho_returnedTrue()
        {
            //Arrange
            string text = "Андреев Егор-Давидович";

            //Act
            StringCheck obj = new StringCheck();
            bool result = obj.CheckName(text);

            //Assert
            Assert.IsTrue(result);
        }



        /// <summary>
        /// Тест на длинную фамилию в строке
        /// </summary>
        [TestMethod]
        public void CheckName_longname_returnedTrue()
        {
            //Arrange
            string text = "Ульянов Евгенийвикторалексей Маркович";

            //Act
            StringCheck obj = new StringCheck();
            bool result = obj.CheckName(text);

            //Assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Тест на длинную фамилию в строке
        /// </summary>
        [TestMethod]
        public void CheckName_Truename2_returnedTrue()
        {
            //Arrange
            string text = "Бурова Мария Владимировна";

            //Act
            StringCheck obj = new StringCheck();
            bool result = obj.CheckName(text);

            //Assert
            Assert.IsTrue(result);
        }





        //Ложные тесты

        /// <summary>
        /// Тест на пустоту
        /// </summary>
        [TestMethod]
        public void CheckName_empty_returnedfalse()
        {
            //Arrange
            string text = "";

            //Act
            StringCheck obj = new StringCheck();
            bool result = obj.CheckName(text);

            //Assert
            Assert.IsFalse(result);
        }



        /// <summary>
        /// Тест на длинное имя в строке
        /// </summary>
        [TestMethod]
        public void CheckName_longsurname_returnedfalse()
        {
            //Arrange
            string text = "фывапролджэячсмйцукенгшщзфывапролджэячсмйцукенгшщзыы Георгий Олегович";

            //Act
            StringCheck obj = new StringCheck();
            bool result = obj.CheckName(text);

            //Assert
            Assert.IsFalse(result);
        }




        /// <summary>
        /// Тест на пробелы
        /// </summary>
        [TestMethod]
        public void CheckName_space_returnedFalse()
        {
            //Arrange
            string text = "  ";

            //Act
            StringCheck obj = new StringCheck();
            bool result = obj.CheckName(text);

            //Assert
            Assert.IsFalse(result);
        }



        /// <summary>
        /// Тест на спец символы
        /// </summary>

        [TestMethod]
        public void CheckName_specsimvol_returnedFalse()
        {
            //Arrange
            string text = "Андреев$Егор$Давидович";

            //Act
            StringCheck obj = new StringCheck();
            bool result = obj.CheckName(text);

            //Assert
            Assert.IsFalse(result);
        }

        

        /// <summary>
        /// Тест на соединёное ФИО
        /// </summary>
        [TestMethod]
        public void CheckName_falsename_returnedFalse()
        {
            //Arrange
            string text = "АндреевЕгорДавидович";

            //Act
            StringCheck obj = new StringCheck();
            bool result = obj.CheckName(text);

            //Assert
            Assert.IsFalse(result);
        }



        /// <summary>
        /// Тест на длинную фамилию в строке
        /// </summary>
        [TestMethod]
        public void CheckName_dash_returnedFalse()
        {
            //Arrange
            string text = "- - -";

            //Act
            StringCheck obj = new StringCheck();
            bool result = obj.CheckName(text);

            //Assert
            Assert.IsFalse(result);
        }


    }
}
