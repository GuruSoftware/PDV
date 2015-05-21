using PuntoDeVenta;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DBSqlTest
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para ConsultaInventarioTest y se pretende que
    ///contenga todas las pruebas unitarias ConsultaInventarioTest.
    ///</summary>
    [TestClass()]
    public class ConsultaInventarioTest
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
        ///Una prueba de btnLimpiar_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("PuntoDeVenta.exe")]
        public void btnLimpiar_ClickTest()
        {
            ConsultaInventario_Accessor target = new ConsultaInventario_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            EventArgs e = null;
            target.txtCodigo.Text = "1";
            target.txtReferencia.Text = "1";
            target.txtDescripcion.Text = "1";
            target.dataGridView1.DataSource = DBSql.GetDataSource("Select * from tblUsuarios");
            target.txtTotalRegistros.Text = "0";
            target.btnLimpiar_Click(sender, e);
           Assert.IsTrue(target.txtCodigo.Text == string.Empty&&target.txtReferencia.Text == string.Empty &&  target.txtDescripcion.Text == string.Empty &&  target.dataGridView1.DataSource == null && target.txtTotalRegistros.Text == "0");
        }
    }
}
