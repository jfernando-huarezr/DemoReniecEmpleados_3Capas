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
    public class ContratoBL
    {
        ContratoADO objContratoADO = new ContratoADO();

        public DataTable ListarContrato()
        {
            return objContratoADO.ListarContrato();
        }
    }
}
