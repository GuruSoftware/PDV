using PuntoDeVenta;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DBSqlTest
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para BuscarClientesTest y se pretende que
    ///contenga todas las pruebas unitarias BuscarClientesTest.
    ///</summary>
    [TestClass()]
    public class BuscarClientesTest
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
            BuscarClientes_Accessor target = new BuscarClientes_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            EventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.btnBuscar_Click(sender, e);
            Assert.IsTrue(target.dataGridView1.RowCount>0);
           // Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de button1_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("PuntoDeVenta.exe")]
        public void button1_ClickTest()
        {
            BuscarClientes_Accessor target = new BuscarClientes_Accessor(); // TODO: Inicializar en un valor adecuado
            target.btnID.Text = "111";
            
            target.btnNombre.Text="test";
            target.btnApellido.Text="Test1";
                
            
            object sender = null; // TODO: Inicializar en un valor adecuado
            EventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.button1_Click(sender, e);
            Assert.IsTrue(target.Nombre==target.btnNombre.Text&& target.ID==target.btnID.Text&&target.Apellido==target.btnApellido.Text);
            
           
        }

        /// <summary>
        ///Una prueba de ValidarCampos
        ///</summary>
        [TestMethod()]
        [DeploymentItem("PuntoDeVenta.exe")]
        public void ValidarCamposTest()
        {
            BuscarClientes_Accessor target = new BuscarClientes_Accessor(); // TODO: Inicializar en un valor adecuado
            bool expected = true; // TODO: Inicializar en un valor adecuado
            bool actual;
            target.btnID.Text = "1";
            actual = target.ValidarCampos();
            Assert.AreEqual(expected, actual);

        }
    }
}
