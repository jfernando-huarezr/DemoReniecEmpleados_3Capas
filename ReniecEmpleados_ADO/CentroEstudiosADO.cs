using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ReniecEmpleados_ADO
{
    public class CentroEstudiosADO
    {
        ConexionADO miConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarCentroEstudio()
        {
            try
            {
                DataSet dts = new DataSet();
                cnx.ConnectionString = miConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarCentroEstudio";

                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "CentroEstudios");
                return dts.Tables["CentroEstudios"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);


            }
        }
    }
}
