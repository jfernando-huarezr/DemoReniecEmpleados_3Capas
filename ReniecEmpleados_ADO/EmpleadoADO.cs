using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ReniecEmpleados_BE;

namespace ReniecEmpleados_ADO
{
    public class EmpleadoADO
    {
        ConexionADO miConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarEmpleado()
        {
            try
            {
                DataSet dts = new DataSet();
                cnx.ConnectionString = miConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarEmpleado";

                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Empleados");
                return dts.Tables["Empleados"];


            } catch (SqlException ex)
            {
                throw new Exception(ex.Message);


            }
        }

        public EmpleadoBE ConsultarEmpleado(String strCodigo)
        {

            try
            {
                //Codifique
                //Creamos la instancia de ProductoBE a retornar
                EmpleadoBE objEmpleadoBE = new EmpleadoBE();

                //conexion
                cnx.ConnectionString = miConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarEmpleado";
                cmd.Parameters.Clear();
                //asigna strcodigo al parametro @vcod
                cmd.Parameters.AddWithValue("@Cod_emp", strCodigo);

                //se abre la conexion
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows)
                {
                    //si devolvio resultados, se lee la fila y sus columnas
                    //se asignan a las propiedades de la instancia objEmpleadoBE
                    dtr.Read();
                    objEmpleadoBE.Cod_emp = dtr["Cod_emp"].ToString();
                    objEmpleadoBE.Nom_emp = dtr["Nom_emp"].ToString();
                    objEmpleadoBE.Ape_emp = dtr["Ape_emp"].ToString();
                    objEmpleadoBE.Dni_emp = dtr["Dni_emp"].ToString();
                    objEmpleadoBE.Dir_emp = dtr["Dir_emp"].ToString();
                    objEmpleadoBE.Id_Ubigeo = dtr["Id_Ubigeo"].ToString();
                    objEmpleadoBE.Tel_emp = dtr["Tel_emp"].ToString();
                    objEmpleadoBE.Cor_emp = dtr["Cor_emp"].ToString();
                    objEmpleadoBE.NivelAc_emp = dtr["NivelAc_emp"].ToString();
                    objEmpleadoBE.Cod_sed = dtr["Cod_sed"].ToString();
                    objEmpleadoBE.Cod_are = dtr["Cod_are"].ToString();
                    objEmpleadoBE.Est_civ = dtr["Est_civ"].ToString();
                    objEmpleadoBE.Sex_emp = dtr["Sex_emp"].ToString();
                    objEmpleadoBE.Fech_nacimiento = Convert.ToDateTime(dtr["Fech_nacimiento"]); 
                    objEmpleadoBE.Id_puesto = dtr["Id_puesto"].ToString();
                    objEmpleadoBE.Id_jefe = dtr["Id_jefe"].ToString();
                    objEmpleadoBE.Estado_emp = Convert.ToInt16(dtr["Estado_emp"]);
                }
                else
                {
                    objEmpleadoBE.Cod_emp = String.Empty;
                }
                dtr.Close();
                return objEmpleadoBE;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }
        public Boolean InsertarEmpleado(EmpleadoBE objEmpleadoBE)
        {

            try
            {
                //Codifique
                //se establece la conexion y limpia parametros, asi como el storedProcedure a usar
                cnx.ConnectionString = miConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_insertarProducto";
                cmd.Parameters.Clear();

                //se establecen nuevos parametros usando los parametros que contiene objEmpleadoBE
                cmd.Parameters.AddWithValue("@Nom_emp", objEmpleadoBE.Nom_emp);
                cmd.Parameters.AddWithValue("@Ape_emp", objEmpleadoBE.Ape_emp);
                cmd.Parameters.AddWithValue("@Dni_Emp", objEmpleadoBE.Dni_emp);
                cmd.Parameters.AddWithValue("@Dir_emp", objEmpleadoBE.Dir_emp);
                cmd.Parameters.AddWithValue("@Id_Ubigeo", objEmpleadoBE.Id_Ubigeo);
                cmd.Parameters.AddWithValue("@Tel_emp", objEmpleadoBE.Tel_emp);
                cmd.Parameters.AddWithValue("@Cor_Emp", objEmpleadoBE.Cor_emp);
                cmd.Parameters.AddWithValue("@NivelAc_emp", objEmpleadoBE.NivelAc_emp);
                cmd.Parameters.AddWithValue("@Cod_sed", objEmpleadoBE.Cod_sed);
                cmd.Parameters.AddWithValue("@Cod_are", objEmpleadoBE.Cod_are);
                cmd.Parameters.AddWithValue("@Est_civ", objEmpleadoBE.Est_civ);
                cmd.Parameters.AddWithValue("@Fech_ingreso", objEmpleadoBE.Fech_ingreso);
                cmd.Parameters.AddWithValue("@Sex_emp", objEmpleadoBE.Sex_emp);
                cmd.Parameters.AddWithValue("@Fec_nacimiento", objEmpleadoBE.Fech_nacimiento);
                cmd.Parameters.AddWithValue("@Id_Puesto", objEmpleadoBE.Id_puesto);
                cmd.Parameters.AddWithValue("@Id_Jefe", objEmpleadoBE.Id_jefe);
                cmd.Parameters.AddWithValue("@Foto_emp", objEmpleadoBE.Foto_emp);
                cmd.Parameters.AddWithValue("@Fecha_registro", objEmpleadoBE.Fecha_registro);
                cmd.Parameters.AddWithValue("@Usuario_registro", objEmpleadoBE.Usuario_Registro);
                cmd.Parameters.AddWithValue("@Estado_emp", objEmpleadoBE.Estado_emp);

                //se abre la conexion y ejecuta el nonQuery(storedProcedure)
                cnx.Open();
                cmd.ExecuteNonQuery();

                //si todo es correcto, se retorna true - si no se pasa al catch
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {   //finalmente se cierra la conexion
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }

        public Boolean ActualizarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            try
            {
                //Codifique
                //se establece la conexion y limpia parametros, asi como el storedProcedure a usar
                cnx.ConnectionString = miConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarEmpleado";
                cmd.Parameters.Clear();

                //se establecen nuevos parametros usando los parametros que contiene objEmpleadoBE
                cmd.Parameters.AddWithValue("@Cod_emp", objEmpleadoBE.Cod_emp);
                cmd.Parameters.AddWithValue("@Nom_emp", objEmpleadoBE.Nom_emp);
                cmd.Parameters.AddWithValue("@Ape_emp", objEmpleadoBE.Ape_emp);
                cmd.Parameters.AddWithValue("@Dni_Emp", objEmpleadoBE.Dni_emp);
                cmd.Parameters.AddWithValue("@Dir_emp", objEmpleadoBE.Dir_emp);
                cmd.Parameters.AddWithValue("@Id_Ubigeo", objEmpleadoBE.Id_Ubigeo);
                cmd.Parameters.AddWithValue("@Tel_emp", objEmpleadoBE.Tel_emp);
                cmd.Parameters.AddWithValue("@Cor_Emp", objEmpleadoBE.Cor_emp);
                cmd.Parameters.AddWithValue("@NivelAc_emp", objEmpleadoBE.NivelAc_emp);
                cmd.Parameters.AddWithValue("@Cod_sed", objEmpleadoBE.Cod_sed);
                cmd.Parameters.AddWithValue("@Cod_are", objEmpleadoBE.Cod_are);
                cmd.Parameters.AddWithValue("@Est_civ", objEmpleadoBE.Est_civ);
                cmd.Parameters.AddWithValue("@Fech_ingreso", objEmpleadoBE.Fech_ingreso);
                cmd.Parameters.AddWithValue("@Sex_emp", objEmpleadoBE.Sex_emp);
                cmd.Parameters.AddWithValue("@Fec_nacimiento", objEmpleadoBE.Fech_nacimiento);
                cmd.Parameters.AddWithValue("@Id_Puesto", objEmpleadoBE.Id_puesto);
                cmd.Parameters.AddWithValue("@Id_Jefe", objEmpleadoBE.Id_jefe);
                cmd.Parameters.AddWithValue("@Foto_emp", objEmpleadoBE.Foto_emp);
                cmd.Parameters.AddWithValue("@Fecha_registro", objEmpleadoBE.Fecha_registro);
                cmd.Parameters.AddWithValue("@Usuario_registro", objEmpleadoBE.Usuario_Registro);
                cmd.Parameters.AddWithValue("@Estado_emp", objEmpleadoBE.Estado_emp);

                //se abre la conexion y ejecuta el nonQuery
                cnx.Open();
                cmd.ExecuteNonQuery();

                //si todo es correcto, se retorna true - si no se pasa al catch
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }

        public Boolean EliminarEmpleado(String strCodigo)
        {

            try
            {
                //Codifique
                //se establece la conexion y limpia parametros, asi como el storedProcedure a usar
                cnx.ConnectionString = miConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarProducto";
                cmd.Parameters.Clear();

                //se establecen nuevos parametros usando los parametros que contiene objProductoBE
                cmd.Parameters.AddWithValue("@Cod_emp", strCodigo);

                // se abre la conexion y ejecuta el nonQuery
                cnx.Open();
                cmd.ExecuteNonQuery();

                //si todo es correcto, se retorna true - si no se pasa al catch
                return true;

            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }


        }
    }
}
