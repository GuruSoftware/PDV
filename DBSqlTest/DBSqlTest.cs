using PuntoDeVenta;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.Data;

namespace DBSqlTest
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para DBSqlTest y se pretende que
    ///contenga todas las pruebas unitarias DBSqlTest.
    ///</summary>
    [TestClass()]
    public class DBSqlTest
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
        ///Una prueba de SetConnectionString
        ///</summary>
        [TestMethod()]
        public void SetConnectionStringTest()
        {
            string value = @"Data Source=Mayelin\SQLEXPRESS;Initial Catalog=INF522;Integrated Security=True"; // TODO: Inicializar en un valor adecuado
            //value = null;
            //value = string.Empty;
            DBSql.SetConnectionString(value);
            
            Assert.IsNull(DBSql.Exception,DBSql.Exception);
        }

        /// <summary>
        ///Una prueba de GetDataSource
        ///</summary>
        [TestMethod()]
        public void GetDataSourceTest()
        {
            SqlCommand Command = new SqlCommand(); // TODO: Inicializar en un valor adecuado
            
            DataTable actual;
            Command.CommandText="SELECT Usuario,Contrasena, Permisos, ID FROM tblUsuarios";
            DBSql.SetConnectionString(@"Data Source=Mayelin\SQLEXPRESS;Initial Catalog=INF522;Integrated Security=True");
            actual = DBSql.GetDataSource(Command);
            Assert.IsTrue( actual.Rows.Count>=1,DBSql.Exception);
        }

        /// <summary>
        ///Una prueba de GetDataSource
        ///</summary>
        [TestMethod()]
        public void GetDataSourceTest1()
        {
            string consulta = string.Empty; // TODO: Inicializar en un valor adecuado
            DataTable actual;
            consulta = "SELECT Usuario,Contrasena, Permisos, ID FROM tblUsuarios";
            DBSql.SetConnectionString(@"Data Source=Mayelin\SQLEXPRESS;Initial Catalog=INF522;Integrated Security=True");
            actual = DBSql.GetDataSource(consulta);
            Assert.IsTrue(actual.Rows.Count >= 1,DBSql.Exception);
        }

        /// <summary>
        ///Una prueba de ExecuteReader
        ///</summary>
        [TestMethod()]
        public void ExecuteReaderTest()
        {//TODO: estoy en aprietos
            DBSql.SetConnectionString(@"Data Source=Mayelin\SQLEXPRESS;Initial Catalog=INF522;Integrated Security=True");
            string Value = "select * from tblUsuarios"; // TODO: Inicializar en un valor adecuado
            SqlDataReader actual;
            actual = DBSql.ExecuteReader(Value);
            
            Assert.IsNotNull(actual, DBSql.Exception);
        }

        /// <summary>
        ///Una prueba de ExecuteNonQuery
        ///</summary>
        [TestMethod()]
        public void ExecuteNonQueryTest()
        {
            DBSql.SetConnectionString(@"Data Source=Mayelin\SQLEXPRESS;Initial Catalog=INF522;Integrated Security=True");
            string consulta = "update tblUsuarios set Usuario='NULL' where ID=10"; // TODO: Inicializar en un valor adecuado
            DBSql.ExecuteNonQuery(consulta);
            Assert.IsTrue(DBSql.GetDataSource("select *from tblUsuarios where Usuario='NULL'").Rows.Count == 1,DBSql.Exception);
        }

        /// <summary>
        ///Una prueba de ExecuteNonQuery
        ///</summary>
        [TestMethod()]
        public void ExecuteNonQueryTest1()
        {
       
            // TODO: Inicializar en un valor adecuado
            DBSql.SetConnectionString(@"Data Source=Mayelin\SQLEXPRESS;Initial Catalog=INF522;Integrated Security=True");
            string consulta = "update tblUsuarios set Usuario='NULLs' where ID=10"; // TODO: Inicializar en un valor adecuado
            SqlCommand command = new SqlCommand(consulta); 
               DBSql.ExecuteNonQuery(consulta);
            Assert.IsTrue(DBSql.GetDataSource("select *from tblUsuarios where Usuario='NULLs'").Rows.Count == 1, DBSql.Exception);
        }
    }
}
