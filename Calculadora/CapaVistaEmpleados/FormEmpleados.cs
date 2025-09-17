using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaEmpleados
{
    public partial class FormEmpleados : Form
    {
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
            DataTable dt = cn.llenarTbl(Dgv_Empleados);
            /*nombre del datagrid*/.DataSource = dt;

        }
    }
}
