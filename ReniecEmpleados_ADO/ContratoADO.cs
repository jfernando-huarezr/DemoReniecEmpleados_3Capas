using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using ReniecEmpleados_BE;

namespace ReniecEmpleados_ADO
{
    public class ContratoADO
    {

        ConexionADO miConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarContrato()
        {
            try
            {
                DataSet dts = new DataSet();
                cnx.ConnectionString = miConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarContrato";

                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Contratos");
                return dts.Tables["Contratos"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);


            }
        }

        
    }
}
