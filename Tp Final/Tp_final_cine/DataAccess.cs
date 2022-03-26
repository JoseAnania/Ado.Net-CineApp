using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Tp_final_cine
{
    class DataAccess
    {
        OleDbConnection conexion;
        OleDbCommand comando;
        OleDbDataReader dr;
        DataTable dt;
        string cadenaConexion;

        public OleDbDataReader Dr
        {
            get
            {
                return dr;
            }

            set
            {
                dr = value;
            }
        }

        public string CadenaConexion
        {
            get
            {
                return cadenaConexion;
            }

            set
            {
                cadenaConexion = value;
            }
        }
        public DataAccess ()
        {
            conexion = new OleDbConnection();
            comando = new OleDbCommand();
            dt = new DataTable();
            dr = null;
            cadenaConexion = "";
        }
        public DataAccess (string strConexion)
        {
            conexion = new OleDbConnection();
            comando = new OleDbCommand();
            dt = new DataTable();
            dr = null;
            cadenaConexion = strConexion;
        }
        public void conectar()
        {
            if(conexion.State==ConnectionState.Closed)
            { 
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            }

        }
        public void desconectar ()
        {
            if (conexion.State==ConnectionState.Open)
            { 
            conexion.Close();
            conexion.Dispose();
            }
        }
        public DataTable consultarTabla(string tabla)
        {
            dt = new DataTable();
            conectar();
            comando.CommandText = "Select * from " + tabla;
            dt.Load(comando.ExecuteReader());
            desconectar();
            return dt;
        }
        public DataTable consultar(string sql)
        {
            dt = new DataTable();
            conectar();
            comando.CommandText = sql;
            dt.Load(comando.ExecuteReader());
            desconectar();
            return dt;
        }
        public int consultarDato (string sql)
        {
            int dato;
            
            conectar();
            comando.CommandText = sql;
            
            dato = Convert.ToInt32( comando.ExecuteScalar());
            desconectar();
            return dato;
        }
        public void leerTabla (string tabla)
        {
            conectar();
            comando.CommandText = "Select * from " + tabla;
            dr = comando.ExecuteReader();
        }
        public void leer(string sql)
        {
            conectar();
            comando.CommandText = sql;
            dr = comando.ExecuteReader();
        }

        public void actualizar(string sql)
        {
            conectar();
            comando.CommandText = sql;
            comando.ExecuteNonQuery();
            desconectar();
        }

    }
}
