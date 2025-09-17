
namespace CapaVistaEmpleados
{
    partial class CapaVistaEmpleados
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapaVistaEmpleados));
            this.Dgv_Empleados = new System.Windows.Forms.DataGridView();
            this.Btn_Agregar_Empleados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Empleados
            // 
            this.Dgv_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Empleados.Location = new System.Drawing.Point(76, 221);
            this.Dgv_Empleados.Name = "Dgv_Empleados";
            this.Dgv_Empleados.Size = new System.Drawing.Size(713, 150);
            this.Dgv_Empleados.TabIndex = 5;
            // 
            // Btn_Agregar_Empleados
            // 
            this.Btn_Agregar_Empleados.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Agregar_Empleados.Image")));
            this.Btn_Agregar_Empleados.Location = new System.Drawing.Point(358, 39);
            this.Btn_Agregar_Empleados.Name = "Btn_Agregar_Empleados";
            this.Btn_Agregar_Empleados.Size = new System.Drawing.Size(170, 128);
            this.Btn_Agregar_Empleados.TabIndex = 4;
            this.Btn_Agregar_Empleados.UseVisualStyleBackColor = true;
            this.Btn_Agregar_Empleados.Click += new System.EventHandler(this.Btn_Agregar_Empleados_Click);
            // 
            // CapaVistaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Dgv_Empleados);
            this.Controls.Add(this.Btn_Agregar_Empleados);
            this.Name = "CapaVistaEmpleados";
            this.Size = new System.Drawing.Size(890, 423);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Empleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Empleados;
        private System.Windows.Forms.Button Btn_Agregar_Empleados;
    }
}
