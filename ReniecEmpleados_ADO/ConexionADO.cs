using System.Configuration;

namespace ReniecEmpleados_ADO
{
    public class ConexionADO
    {
        public string GetCnx()
        {
            string strCnx = ConfigurationManager.ConnectionStrings["Empleados"].ConnectionString;
            if (object.ReferenceEquals(strCnx, string.Empty))
            {
                return string.Empty;
            } else
            {
                return strCnx;
            }
        }

    }
}
