namespace Ejercicio_1._Sueldos
{
    partial class FormModal
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
            button1 = new Button();
            btnCancelar = new Button();
            Nombre = new Label();
            label2 = new Label();
            rbAsalariado = new RadioButton();
            rbJornalero = new RadioButton();
            label3 = new Label();
            label4 = new Label();
            tbxNombre = new TextBox();
            tbxDNI = new TextBox();
            tbxBasico = new TextBox();
            tbxImporte = new TextBox();
            label1 = new Label();
            label5 = new Label();
            tbxRetenciones = new TextBox();
            tbxHoras = new TextBox();
            Aportes = new Label();
            tbxAportes = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(197, 203);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(278, 203);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(45, 60);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 2;
            Nombre.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 93);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 3;
            label2.Text = "DNI";
            // 
            // rbAsalariado
            // 
            rbAsalariado.AutoSize = true;
            rbAsalariado.Location = new Point(468, 108);
            rbAsalariado.Name = "rbAsalariado";
            rbAsalariado.Size = new Size(80, 19);
            rbAsalariado.TabIndex = 4;
            rbAsalariado.TabStop = true;
            rbAsalariado.Text = "Asalariado";
            rbAsalariado.UseVisualStyleBackColor = true;
            rbAsalariado.CheckedChanged += rbAsalariado_CheckedChanged;
            // 
            // rbJornalero
            // 
            rbJornalero.AutoSize = true;
            rbJornalero.Location = new Point(468, 48);
            rbJornalero.Name = "rbJornalero";
            rbJornalero.Size = new Size(73, 19);
            rbJornalero.TabIndex = 5;
            rbJornalero.TabStop = true;
            rbJornalero.Text = "Jornalero";
            rbJornalero.UseVisualStyleBackColor = true;
            rbJornalero.CheckedChanged += rbJornalero_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 112);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 6;
            label3.Text = "Basico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 83);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 7;
            label4.Text = "Importe";
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(123, 52);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(100, 23);
            tbxNombre.TabIndex = 8;
            // 
            // tbxDNI
            // 
            tbxDNI.Location = new Point(123, 90);
            tbxDNI.Name = "tbxDNI";
            tbxDNI.Size = new Size(100, 23);
            tbxDNI.TabIndex = 9;
            // 
            // tbxBasico
            // 
            tbxBasico.Location = new Point(323, 109);
            tbxBasico.Name = "tbxBasico";
            tbxBasico.Size = new Size(100, 23);
            tbxBasico.TabIndex = 10;
            // 
            // tbxImporte
            // 
            tbxImporte.Location = new Point(323, 80);
            tbxImporte.Name = "tbxImporte";
            tbxImporte.Size = new Size(100, 23);
            tbxImporte.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(276, 18);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 12;
            label1.Text = "Horas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 52);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 13;
            label5.Text = "Retenciones";
            // 
            // tbxRetenciones
            // 
            tbxRetenciones.Location = new Point(323, 49);
            tbxRetenciones.Name = "tbxRetenciones";
            tbxRetenciones.Size = new Size(100, 23);
            tbxRetenciones.TabIndex = 14;
            // 
            // tbxHoras
            // 
            tbxHoras.Location = new Point(323, 15);
            tbxHoras.Name = "tbxHoras";
            tbxHoras.Size = new Size(100, 23);
            tbxHoras.TabIndex = 15;
            // 
            // Aportes
            // 
            Aportes.AutoSize = true;
            Aportes.Location = new Point(268, 144);
            Aportes.Name = "Aportes";
            Aportes.Size = new Size(48, 15);
            Aportes.TabIndex = 16;
            Aportes.Text = "Aportes";
            // 
            // tbxAportes
            // 
            tbxAportes.Location = new Point(323, 141);
            tbxAportes.Name = "tbxAportes";
            tbxAportes.Size = new Size(100, 23);
            tbxAportes.TabIndex = 17;
            // 
            // FormModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 238);
            Controls.Add(tbxAportes);
            Controls.Add(Aportes);
            Controls.Add(tbxHoras);
            Controls.Add(tbxRetenciones);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(tbxImporte);
            Controls.Add(tbxBasico);
            Controls.Add(tbxDNI);
            Controls.Add(tbxNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(rbJornalero);
            Controls.Add(rbAsalariado);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Controls.Add(btnCancelar);
            Controls.Add(button1);
            Name = "FormModal";
            Text = "FormModal";
            Load += FormModal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Nombre;
        private Label label2;
        private Label label3;
        private Label label4;
        public Button button1;
        public Button btnCancelar;
        public RadioButton rbAsalariado;
        public RadioButton rbJornalero;
        public TextBox tbxNombre;
        public TextBox tbxDNI;
        public TextBox tbxBasico;
        public TextBox tbxImporte;
        private Label label1;
        private Label label5;
        private Label Aportes;
        public TextBox tbxRetenciones;
        public TextBox tbxHoras;
        public TextBox tbxAportes;
    }
}