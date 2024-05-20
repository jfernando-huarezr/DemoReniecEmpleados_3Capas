using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReniecEmpleados_BE
{
    public class CentroEstudiosBE
    {
        public String Id_Cestudio { get; set; }
        public String Des_Cestudio { get; set; }
        public Int16 Tip_Cestudio { get; set; }
        public DateTime Fecha_registro { get; set; }
        public String Usuario_registro { get; set; }
        public DateTime Fecha_Ult_Modif {get;set;}
        public String Usuario_Ult_Modif { get; set; }
        public Int16 Estado_Cestudio { get; set; }
    }
}
