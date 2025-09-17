using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe_Calculadora
{
    public partial class Frm_Calculadora : Form
    {
        TextBox txtActivo; // variable para que el textbox se active
        public Frm_Calculadora()
        {
            InitializeComponent();
            Txt_Num1.MouseClick += (s, e) => txtActivo = Txt_Num1;
            Txt_Num2.MouseClick += (s, e) => txtActivo = Txt_Num2;
        }

        private void Btn_Suma_Click(object sender, EventArgs e)
        {
            // guardar el dato que ingreso el usuario
            int num1 = int.Parse(Txt_Num1.Text);
            int num2 = int.Parse(Txt_Num2.Text);

            // resultado
            int resultado = CalculadoraEjemplo.CalculadoraEjemplo.Suma(num1, num2);

            Txt_Resultado.Clear();//limpiar
            Txt_Resultado.Text = "El resultado de la Suma es: " + resultado;
        }

        private void Btn_Division_Click(object sender, EventArgs e)
        {
            // guardar el dato que ingreso el usuario
            int num1 = int.Parse(Txt_Num1.Text);
            int num2 = int.Parse(Txt_Num2.Text);

            // resultado
            int resultado = CalculadoraEjemplo.CalculadoraEjemplo.Division(num1, num2);

            Txt_Resultado.Clear();//limpiar
            Txt_Resultado.Text = "El resultado de la Division es: " + resultado;
        }

        private void Btn_Multiplicacion_Click(object sender, EventArgs e)
        {
            // guardar el dato que ingreso el usuario
            int num1 = int.Parse(Txt_Num1.Text);
            int num2 = int.Parse(Txt_Num2.Text);

            // resultado
            int resultado = CalculadoraEjemplo.CalculadoraEjemplo.Multiplicacion(num1, num2);

            Txt_Resultado.Clear();//limpiar
            Txt_Resultado.Text = "El resultado de la Multiplicacion es: " + resultado;
        }

        private void Btn_Resta_Click(object sender, EventArgs e)
        {
            // guardar el dato que ingreso el usuario
            int num1 = int.Parse(Txt_Num1.Text);
            int num2 = int.Parse(Txt_Num2.Text);

            // La funcion resta lo hace Kevin Natareno
            //int resultado = CalculadoraEjemplo.CalculadoraEjemplo.Resta(num1, num2);

            Txt_Resultado.Clear();//limpiar
            //Txt_Resultado.Text = "El resultado de la Suma es: " + resultado;
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Txt_Num1.Clear();
            Txt_Num2.Clear();
            Txt_Resultado.Clear();
        }

        private void Btn_Num1_Click(object sender, EventArgs e)
        {
            if (txtActivo != null && sender is Button btn)
            {
                txtActivo.Text += btn.Text; // añade el número al textbox activo
            }
        }

        private void Btn_Num2_Click(object sender, EventArgs e)
        {
            if (txtActivo != null && sender is Button btn)
            {
                txtActivo.Text += btn.Text; // añade el número al textbox activo
            }
        }

        private void Btn_Num3_Click(object sender, EventArgs e)
        {
            if (txtActivo != null && sender is Button btn)
            {
                txtActivo.Text += btn.Text; // añade el número al textbox activo
            }
        }

        private void Btn_Num4_Click(object sender, EventArgs e)
        {
            if (txtActivo != null && sender is Button btn)
            {
                txtActivo.Text += btn.Text; // añade el número al textbox activo
            }
        }

        private void Btn_Num5_Click(object sender, EventArgs e)
        {
            if (txtActivo != null && sender is Button btn)
            {
                txtActivo.Text += btn.Text; // añade el número al textbox activo
            }
        }

        private void Btn_Num6_Click(object sender, EventArgs e)
        {
            if (txtActivo != null && sender is Button btn)
            {
                txtActivo.Text += btn.Text; // añade el número al textbox activo
            }
        }

        private void Btn_Num7_Click(object sender, EventArgs e)
        {
            if (txtActivo != null && sender is Button btn)
            {
                txtActivo.Text += btn.Text; // añade el número al textbox activo
            }
        }

        private void Btn_Num8_Click(object sender, EventArgs e)
        {
            if (txtActivo != null && sender is Button btn)
            {
                txtActivo.Text += btn.Text; // añade el número al textbox activo
            }
        }

        private void Btn_Num9_Click(object sender, EventArgs e)
        {
            if (txtActivo != null && sender is Button btn)
            {
                txtActivo.Text += btn.Text; // añade el número al textbox activo
            }
        }

        private void Btn_Num0_Click(object sender, EventArgs e)
        {
            if (txtActivo != null && sender is Button btn)
            {
                txtActivo.Text += btn.Text; // añade el número al textbox activo
            }
        }
    }
}
