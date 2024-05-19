using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReniecEmpleados_BE
{
    public class ContratoBE 
    {
        public String Cod_con { get; set; }
        public String Cod_emp { get; set; }
        public DateTime Fec_ini { get; set; }
        public DateTime Fec_fin { get; set; }
        public String Usuario_registro { get; set; }
        public DateTime Fecha_Ult_Modif { get; set; }
        public String Usuario_Ult_Modif { get; set; }
        public Int16 Estado_con { get; set; }
    }
}
