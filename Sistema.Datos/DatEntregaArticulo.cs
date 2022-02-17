using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sistema.Entidades;

namespace Sistema.Datos
{
    public class DatEntregaArticulo
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("EntregaArticuloListar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public DataTable Buscar(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("EntregaArticuloBuscar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Valor", SqlDbType.VarChar).Value = Valor;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public string Existe(string Valor)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("EntregaArticuloExistir", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Valor", SqlDbType.VarChar).Value = Valor;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@Existe";
                ParExiste.SqlDbType = SqlDbType.Int;
                ParExiste.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ParExiste);
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Respuesta = Convert.ToString(ParExiste.Value);
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }
        public string Insertar(EntregaArticulo Obj)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("EntregaArticuloInsertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@NumSerie", SqlDbType.VarChar).Value = Obj.NumSerie;
                Comando.Parameters.Add("@FechaEntrega", SqlDbType.Date).Value = Obj.FechaEntrega;
                Comando.Parameters.Add("@Condicion", SqlDbType.VarChar).Value = Obj.Condicion;
                Comando.Parameters.Add("@IdArticulo", SqlDbType.Int).Value = Obj.IdArticulo;
                Comando.Parameters.Add("@IdEmpleado", SqlDbType.Int).Value = Obj.IdEmpleado;
                Comando.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = Obj.IdUsuario;
                SqlCon.Open();
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "Bueno" : "No se realizo el registro";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }
        public string Actualizar(EntregaArticulo Obj)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("EntregaArticuloActualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@IdEntrega", SqlDbType.Int).Value = Obj.IdEntrega;
                Comando.Parameters.Add("@NumSerie", SqlDbType.VarChar).Value = Obj.NumSerie;
                Comando.Parameters.Add("@FechaEntrega", SqlDbType.Date).Value = Obj.FechaEntrega;
                Comando.Parameters.Add("@Condicion", SqlDbType.VarChar).Value = Obj.Condicion;
                Comando.Parameters.Add("@IdArticulo", SqlDbType.Int).Value = Obj.IdArticulo;
                Comando.Parameters.Add("@IdEmpleado", SqlDbType.Int).Value = Obj.IdEmpleado;
                Comando.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = Obj.IdUsuario;
                SqlCon.Open();
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "Bueno" : "No se realizo la actualizacion";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }
        public string Activar(int Id)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("EntregaArticuloActivar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@IdEntrega", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "Bueno" : "No se pudo activar el registro";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }
        public string Desactivar(int Id)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("EntregaArticuloDesactivar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@IdEntrega", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "Bueno" : "No se pudo desactivar el registro";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }
    }
}
