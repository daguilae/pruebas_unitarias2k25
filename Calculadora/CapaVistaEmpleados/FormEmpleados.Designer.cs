
namespace CapaVistaEmpleados
{
    partial class FormEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleados));
            this.Btn_Agregar_Empleados = new System.Windows.Forms.Button();
            this.Dgv_Empleados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Agregar_Empleados
            // 
            this.Btn_Agregar_Empleados.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Agregar_Empleados.Image")));
            this.Btn_Agregar_Empleados.Location = new System.Drawing.Point(316, 61);
            this.Btn_Agregar_Empleados.Name = "Btn_Agregar_Empleados";
            this.Btn_Agregar_Empleados.Size = new System.Drawing.Size(170, 128);
            this.Btn_Agregar_Empleados.TabIndex = 0;
            this.Btn_Agregar_Empleados.UseVisualStyleBackColor = true;
            this.Btn_Agregar_Empleados.Click += new System.EventHandler(this.Btn_Agregar_Empleados_Click);
            // 
            // Dgv_Empleados
            // 
            this.Dgv_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Empleados.Location = new System.Drawing.Point(34, 243);
            this.Dgv_Empleados.Name = "Dgv_Empleados";
            this.Dgv_Empleados.Size = new System.Drawing.Size(713, 150);
            this.Dgv_Empleados.TabIndex = 1;
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dgv_Empleados);
            this.Controls.Add(this.Btn_Agregar_Empleados);
            this.Name = "FormEmpleados";
            this.Text = "FormEmpleados";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Empleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Agregar_Empleados;
        private System.Windows.Forms.DataGridView Dgv_Empleados;
    }
}