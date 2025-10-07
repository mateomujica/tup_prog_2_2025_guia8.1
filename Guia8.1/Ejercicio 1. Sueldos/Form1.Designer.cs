namespace Ejercicio_1._Sueldos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnImportar = new Button();
            lsbDatosFormPrincipal = new ListBox();
            btnMostrarListado = new Button();
            btnExportar = new Button();
            btnRecibos = new Button();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(533, 77);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(75, 23);
            btnImportar.TabIndex = 0;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // lsbDatosFormPrincipal
            // 
            lsbDatosFormPrincipal.FormattingEnabled = true;
            lsbDatosFormPrincipal.ItemHeight = 15;
            lsbDatosFormPrincipal.Location = new Point(21, 12);
            lsbDatosFormPrincipal.Name = "lsbDatosFormPrincipal";
            lsbDatosFormPrincipal.Size = new Size(494, 244);
            lsbDatosFormPrincipal.TabIndex = 1;
            lsbDatosFormPrincipal.SelectedIndexChanged += lsbDatosFormPrincipal_SelectedIndexChanged;
            // 
            // btnMostrarListado
            // 
            btnMostrarListado.Location = new Point(533, 27);
            btnMostrarListado.Name = "btnMostrarListado";
            btnMostrarListado.Size = new Size(75, 23);
            btnMostrarListado.TabIndex = 2;
            btnMostrarListado.Text = "Ver Listado";
            btnMostrarListado.UseVisualStyleBackColor = true;
            btnMostrarListado.Click += btnMostrarListado_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(533, 122);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(75, 23);
            btnExportar.TabIndex = 3;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnRecibos
            // 
            btnRecibos.Location = new Point(533, 171);
            btnRecibos.Name = "btnRecibos";
            btnRecibos.Size = new Size(127, 23);
            btnRecibos.TabIndex = 4;
            btnRecibos.Text = "Generar Recibo";
            btnRecibos.UseVisualStyleBackColor = true;
            btnRecibos.Click += btnRecibos_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(533, 218);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(127, 23);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar Empleados";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 475);
            Controls.Add(btnAgregar);
            Controls.Add(btnRecibos);
            Controls.Add(btnExportar);
            Controls.Add(btnMostrarListado);
            Controls.Add(lsbDatosFormPrincipal);
            Controls.Add(btnImportar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnImportar;
        private ListBox lsbDatosFormPrincipal;
        private Button btnMostrarListado;
        private Button btnExportar;
        private Button btnRecibos;
        private Button btnAgregar;
    }
}
