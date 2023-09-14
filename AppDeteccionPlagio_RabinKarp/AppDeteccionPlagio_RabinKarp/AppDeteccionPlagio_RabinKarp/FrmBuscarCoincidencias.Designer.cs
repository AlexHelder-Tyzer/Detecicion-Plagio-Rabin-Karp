
namespace AppDeteccionPlagio_RabinKarp
{
    partial class FrmBuscarCoincidencias
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
            this.lsbOraciones = new System.Windows.Forms.ListBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbOraciones
            // 
            this.lsbOraciones.FormattingEnabled = true;
            this.lsbOraciones.ItemHeight = 16;
            this.lsbOraciones.Location = new System.Drawing.Point(12, 65);
            this.lsbOraciones.Name = "lsbOraciones";
            this.lsbOraciones.Size = new System.Drawing.Size(444, 676);
            this.lsbOraciones.TabIndex = 24;
            this.lsbOraciones.SelectedIndexChanged += new System.EventHandler(this.lsbOraciones_SelectedIndexChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(478, 17);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(592, 724);
            this.richTextBox2.TabIndex = 25;
            this.richTextBox2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Oraciones que se encuentran en ambos textos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Seleccione la oracion para buscar:";
            // 
            // FrmBuscarCoincidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 763);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.lsbOraciones);
            this.MaximumSize = new System.Drawing.Size(1100, 810);
            this.MinimumSize = new System.Drawing.Size(1100, 810);
            this.Name = "FrmBuscarCoincidencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar oraciones coincidentes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListBox lsbOraciones;
        public System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}