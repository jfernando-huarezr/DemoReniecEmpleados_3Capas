using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                cmd.CommandText = "usp_ListarEmpleados";

                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter();
                ada.Fill(dts, "Empleados");
                return dts.Tables["Empleados"];


            } catch (SqlException ex)
            {
                throw new Exception(ex.Message);


            }
        }
    }
}
