using PuntoDeVenta;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DBSqlTest
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para SessionTest y se pretende que
    ///contenga todas las pruebas unitarias SessionTest.
    ///</summary>
    [TestClass()]
    public class SessionTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de la prueba que proporciona
        ///la información y funcionalidad para la ejecución de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        // 
        //Puede utilizar los siguientes atributos adicionales mientras escribe sus pruebas:
        //
        //Use ClassInitialize para ejecutar código antes de ejecutar la primera prueba en la clase 
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup para ejecutar código después de haber ejecutado todas las pruebas en una clase
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize para ejecutar código antes de ejecutar cada prueba
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup para ejecutar código después de que se hayan ejecutado todas las pruebas
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Una prueba de Login
        ///</summary>
        [TestMethod()]
        public void LoginTest()
        {
            Session target = new Session(); // TODO: Inicializar en un valor adecuado
            string expected = string.Empty; // TODO: Inicializar en un valor adecuado
            string actual;
            target.Login = expected;
            actual = target.Login;
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///Una prueba de UserID
        ///</summary>
        [TestMethod()]
        public void UserIDTest()
        {
            Session target = new Session(); // TODO: Inicializar en un valor adecuado
            string expected = string.Empty; // TODO: Inicializar en un valor adecuado
            string actual;
            target.UserID = expected;
            actual = target.UserID;
            Assert.AreEqual(expected, actual);
        }
    }
}
