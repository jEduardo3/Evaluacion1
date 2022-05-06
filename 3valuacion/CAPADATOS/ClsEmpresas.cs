using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _3valuacion.CAPADATOS
{
    internal class ClsEmpresas
    {
            private ConexionBD Conexion = new ConexionBD();
            private  sqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable ListarEmpresas()
        {
            DataTable tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarTblEmpresas";
            Comando.Commandtype = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return tabla;
        }
            public void EncontrarRegistros(int idTblEmpresas, int tblpuestos,string Empleado, double Fecha de fin de Relaciones)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.COmmandText = "insertRegistros";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWitchValue("@EmpresasID", ClsEmpresas);
            Comando.Parameters.AddWitchValue("@PuestoID", ClsEmpresas);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();




        }
    }
}
