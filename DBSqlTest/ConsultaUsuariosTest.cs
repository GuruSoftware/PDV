using PuntoDeVenta;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DBSqlTest
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para ConsultaUsuariosTest y se pretende que
    ///contenga todas las pruebas unitarias ConsultaUsuariosTest.
    ///</summary>
    [TestClass()]
    public class ConsultaUsuariosTest
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
        ///Una prueba de ActualizaTotal
        ///</summary>
        [TestMethod()]
        [DeploymentItem("PuntoDeVenta.exe")]
        public void ActualizaTotalTest()
        {
            ConsultaUsuarios_Accessor target = new ConsultaUsuarios_Accessor(); // TODO: Inicializar en un valor adecuado
           
            target.ActualizaTotal();
           // target.txtTotalRegistros.Text = "nsahsj,dhkajs";
           // Assert.AreNotEqual(target.txtTotalRegistros.Text, target.dt.Rows.Count.ToString());





            Assert.AreEqual(target.txtTotalRegistros.Text, target.dt.Rows.Count.ToString());
        }

        /// <summary>
        ///Una prueba de button2_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("PuntoDeVenta.exe")]
        public void button2_ClickTest()
        {
            ConsultaUsuarios_Accessor target = new ConsultaUsuarios_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            EventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.txtGrupo.Text = "prueba";
            target.txtUsuario.Text = "Prueba";
            target.dataGridView1.DataSource = DBSql.GetDataSource("select * from tblUsuarios");
            target.txtTotalRegistros.Text = "0";

            target.button2_Click(sender, e);
            Assert.IsTrue(  target.txtGrupo.Text ==  string.Empty &&
                target.txtUsuario.Text == string.Empty&&
                target.dataGridView1.DataSource == null&&
                target.txtTotalRegistros.Text == "0");           
        }

        /// <summary>
        ///Una prueba de button2_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("PuntoDeVenta.exe")]
        public void button2_ClickTest1()
        {
            ConsultaUsuarios_Accessor target = new ConsultaUsuarios_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            EventArgs e = null; // TODO: Inicializar en un valor adecuado
           target.txtGrupo.Text = "1";
           target.txtUsuario.Text = "1";
           target.dataGridView1.DataSource = DBSql.GetDataSource("select * from tblUsuarios");
           target.txtTotalRegistros.Text = "0";
            target.button2_Click(sender, e);
            Assert.IsTrue( target.txtGrupo.Text == string.Empty&&
           target.txtUsuario.Text == string.Empty &&
           target.dataGridView1.DataSource == null&&
           target.txtTotalRegistros.Text == "0");
        }

        /// <summary>
        ///Una prueba de btnBuscar_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("PuntoDeVenta.exe")]
        public void btnBuscar_ClickTest()
        {
            ConsultaUsuarios_Accessor target = new ConsultaUsuarios_Accessor(); // TODO: Inicializar en un valor adecuado
            object sender = null; // TODO: Inicializar en un valor adecuado
            EventArgs e = null; // TODO: Inicializar en un valor adecuado
            target.btnBuscar_Click(sender, e);
            Assert.IsTrue(target.dataGridView1.RowCount > 0);
        }
    }
}
