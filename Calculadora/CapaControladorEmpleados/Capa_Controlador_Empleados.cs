using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using CapaModeloEmpleados;

namespace CapaControladorEmpleados
{
    public class Capa_Controlador_Empleados
    {
        EmpleadosDAO sn = new EmpleadosDAO();

        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

    }
}
