using PuntoDeVenta;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DBSqlTest
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para LoginTest y se pretende que
    ///contenga todas las pruebas unitarias LoginTest.
    ///</summary>
    [TestClass()]
    public class LoginTest
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
        ///Una prueba de ValidarCampos
        ///</summary>
        [TestMethod()]
        [DeploymentItem("PuntoDeVenta.exe")]
        public void ValidarCamposTest()
        {
            Login_Accessor target = new Login_Accessor(); // TODO: Inicializar en un valor adecuado
            bool expected = true; // TODO: Inicializar en un valor adecuado
            bool actual;
            target.Usuario.Text = "m";//string.Empty;//"";
            target.Password.Text = "   esta bien  ";//"";
            actual = target.ValidarCampos();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Una prueba de InsertarEntrada
        ///</summary>
        [TestMethod()]
        [DeploymentItem("PuntoDeVenta.exe")]
        public void InsertarEntradaTest()
        {
            Login_Accessor target = new Login_Accessor(); // TODO: Inicializar en un valor adecuado
            target.Usuario.Text = "1";
            target.txtFecha.Text = @"1/1/1";
            target.txtHora.Text = "1:15";
            string comprobar = "select * from tblControlEntrada where Usuario='1'and Fecha='1/1/1' and Hora='1:15'  ";
            target.InsertarEntrada();
            /*SqlCommand cmd = new SqlCommand("INSERT INTO tblControlEntrada (Usuario, Fecha , Hora )" +
                                                       " VALUES (@Usuario, @Fecha, @Hora  );", conn);

                        cmd.Parameters.AddWithValue("@Usuario", this.Usuario.Text);
                        cmd.Parameters.AddWithValue("@Fecha", this.txtFecha.Text);
                        cmd.Parameters.AddWithValue("@Hora", this.txtHora.Text);
*/
            Assert.IsTrue(DBSql.GetDataSource(comprobar).Rows.Count > 0,DBSql.Exception);
            
        }
    }
}
