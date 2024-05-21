using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ReniecEmpleados_ADO;
using ReniecEmpleados_BE;
namespace ReniecEmpleados_BL
{
    public class EmpleadoBL
    {
        EmpleadoADO objEmpleadoADO = new EmpleadoADO();

        public DataTable ListarEmpleado()
        {
            return objEmpleadoADO.ListarEmpleado();
        }
        public EmpleadoBE ConsultarEmpleado(String strCodigo)
        {
            return objEmpleadoADO.ConsultarEmpleado(strCodigo);
        }

        public Boolean InsertarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            return objEmpleadoADO.InsertarEmpleado(objEmpleadoBE);
        }
        public Boolean ActualizarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            return objEmpleadoADO.ActualizarEmpleado(objEmpleadoBE);
        }
        public Boolean EliminarEmpleado(String strCodigo)
        {
            return objEmpleadoADO.EliminarEmpleado(strCodigo);
        }
    }
}
