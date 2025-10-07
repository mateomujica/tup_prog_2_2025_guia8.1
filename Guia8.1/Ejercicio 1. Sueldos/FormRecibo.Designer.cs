namespace Ejercicio_1._Sueldos
{
    partial class FormRecibo
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
            tbxVer = new TextBox();
            SuspendLayout();
            // 
            // tbxVer
            // 
            tbxVer.Location = new Point(12, 12);
            tbxVer.Multiline = true;
            tbxVer.Name = "tbxVer";
            tbxVer.Size = new Size(326, 230);
            tbxVer.TabIndex = 0;
            tbxVer.TabStop = false;
            // 
            // FormRecibo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 297);
            Controls.Add(tbxVer);
            Name = "FormRecibo";
            Text = "FormRecibo";
            Load += FormRecibo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox tbxVer;
    }
}