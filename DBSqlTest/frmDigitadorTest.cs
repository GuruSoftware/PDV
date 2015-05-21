using PuntoDeVenta;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DBSqlTest
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para frmDigitadorTest y se pretende que
    ///contenga todas las pruebas unitarias frmDigitadorTest.
    ///</summary>
    [TestClass()]
    public class frmDigitadorTest
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
        ///Una prueba de btnBuscar_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("PuntoDeVenta.exe")]
        public void btnBuscar_ClickTest()
        {
            frmDigitador_Accessor target = new frmDigitador_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            EventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.btnBuscar_Click(sender, e);
            Assert.IsTrue(target.dataGridView1.RowCount > 0);
        }
    }
}
