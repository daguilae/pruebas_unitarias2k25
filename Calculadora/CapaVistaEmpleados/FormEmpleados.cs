using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorEmpleados;

namespace CapaVistaEmpleados
{

    public partial class FormEmpleados : Form
    {
        // Instancia del controlador
        Capa_Controlador_Empleados cn = new Capa_Controlador_Empleados();
        public FormEmpleados()
        {
            InitializeComponent();
            
        }

        private void Btn_Agregar_Empleados_Click(object sender, EventArgs e)
        {
            Pro_actualizardatagriew();
        }

        public void Pro_actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl("NombreTabla");
            Dgv_Empleados.DataSource = dt;

        }
    }
}
