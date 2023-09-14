
namespace AppDeteccionPlagio_RabinKarp
{
    partial class FormPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBuscar1 = new FontAwesome.Sharp.IconButton();
            this.ipbPdf1 = new FontAwesome.Sharp.IconPictureBox();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblR2 = new System.Windows.Forms.Label();
            this.lblR1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblCoincidencias = new System.Windows.Forms.Label();
            this.btnEjecutar = new FontAwesome.Sharp.IconButton();
            this.tcrlMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rtbPdf2 = new System.Windows.Forms.RichTextBox();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.btnBuscar2 = new FontAwesome.Sharp.IconButton();
            this.ipbPdf2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rtbPdf1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.RichTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.ipbPdf1)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tcrlMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbPdf2)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar1
            // 
            this.btnBuscar1.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnBuscar1.IconColor = System.Drawing.Color.Goldenrod;
            this.btnBuscar1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnBuscar1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar1.Location = new System.Drawing.Point(67, 59);
            this.btnBuscar1.Name = "btnBuscar1";
            this.btnBuscar1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 5);
            this.btnBuscar1.Size = new System.Drawing.Size(159, 42);
            this.btnBuscar1.TabIndex = 15;
            this.btnBuscar1.Text = "BUSCAR";
            this.btnBuscar1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar1.UseVisualStyleBackColor = true;
            this.btnBuscar1.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ipbPdf1
            // 
            this.ipbPdf1.BackColor = System.Drawing.Color.Transparent;
            this.ipbPdf1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ipbPdf1.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.ipbPdf1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ipbPdf1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbPdf1.IconSize = 67;
            this.ipbPdf1.Location = new System.Drawing.Point(334, 34);
            this.ipbPdf1.Name = "ipbPdf1";
            this.ipbPdf1.Size = new System.Drawing.Size(67, 67);
            this.ipbPdf1.TabIndex = 16;
            this.ipbPdf1.TabStop = false;
            this.ipbPdf1.Visible = false;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.BorderSize = 1;
            this.gunaGroupBox1.Controls.Add(this.lblTitulo1);
            this.gunaGroupBox1.Controls.Add(this.btnBuscar1);
            this.gunaGroupBox1.Controls.Add(this.ipbPdf1);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(20, 27);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(497, 131);
            this.gunaGroupBox1.TabIndex = 17;
            this.gunaGroupBox1.Text = "Documento 1";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.Location = new System.Drawing.Point(244, 104);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(241, 19);
            this.lblTitulo1.TabIndex = 17;
            this.lblTitulo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 66);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1082, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "DETECCION DE PLAGIO EN DOCUMENTOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.lblR2);
            this.panel2.Controls.Add(this.lblR1);
            this.panel2.Controls.Add(this.lblResultado);
            this.panel2.Controls.Add(this.lblPorcentaje);
            this.panel2.Controls.Add(this.lblCoincidencias);
            this.panel2.Controls.Add(this.btnEjecutar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 575);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 188);
            this.panel2.TabIndex = 19;
            // 
            // lblR2
            // 
            this.lblR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR2.Location = new System.Drawing.Point(956, 80);
            this.lblR2.Name = "lblR2";
            this.lblR2.Size = new System.Drawing.Size(102, 27);
            this.lblR2.TabIndex = 5;
            // 
            // lblR1
            // 
            this.lblR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR1.Location = new System.Drawing.Point(355, 80);
            this.lblR1.Name = "lblR1";
            this.lblR1.Size = new System.Drawing.Size(98, 27);
            this.lblR1.TabIndex = 4;
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(258, 132);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(561, 34);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.Location = new System.Drawing.Point(576, 80);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(386, 27);
            this.lblPorcentaje.TabIndex = 2;
            this.lblPorcentaje.Text = "El porcentaje de similitud entre los 2 textos:";
            // 
            // lblCoincidencias
            // 
            this.lblCoincidencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoincidencias.Location = new System.Drawing.Point(24, 80);
            this.lblCoincidencias.Name = "lblCoincidencias";
            this.lblCoincidencias.Size = new System.Drawing.Size(325, 27);
            this.lblCoincidencias.TabIndex = 1;
            this.lblCoincidencias.Text = "Total de esquema hash coincidentes: ";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnEjecutar.IconColor = System.Drawing.Color.ForestGreen;
            this.btnEjecutar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEjecutar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEjecutar.Location = new System.Drawing.Point(416, 15);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnEjecutar.Size = new System.Drawing.Size(261, 49);
            this.btnEjecutar.TabIndex = 0;
            this.btnEjecutar.Text = "VERIFICAR PLAGIO";
            this.btnEjecutar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // tcrlMenu
            // 
            this.tcrlMenu.Controls.Add(this.tabPage1);
            this.tcrlMenu.Controls.Add(this.tabPage2);
            this.tcrlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcrlMenu.Location = new System.Drawing.Point(0, 0);
            this.tcrlMenu.Name = "tcrlMenu";
            this.tcrlMenu.SelectedIndex = 0;
            this.tcrlMenu.Size = new System.Drawing.Size(1082, 509);
            this.tcrlMenu.TabIndex = 0;
            this.tcrlMenu.SelectedIndexChanged += new System.EventHandler(this.tcrlMenu_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1074, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PDF";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.rtbPdf2);
            this.panel4.Controls.Add(this.gunaGroupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(537, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(534, 474);
            this.panel4.TabIndex = 21;
            // 
            // rtbPdf2
            // 
            this.rtbPdf2.Location = new System.Drawing.Point(19, 180);
            this.rtbPdf2.Name = "rtbPdf2";
            this.rtbPdf2.ReadOnly = true;
            this.rtbPdf2.Size = new System.Drawing.Size(497, 272);
            this.rtbPdf2.TabIndex = 19;
            this.rtbPdf2.Text = "";
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.BorderSize = 1;
            this.gunaGroupBox2.Controls.Add(this.lblTitulo2);
            this.gunaGroupBox2.Controls.Add(this.btnBuscar2);
            this.gunaGroupBox2.Controls.Add(this.ipbPdf2);
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Location = new System.Drawing.Point(19, 27);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(497, 131);
            this.gunaGroupBox2.TabIndex = 18;
            this.gunaGroupBox2.Text = "Documento 1";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.Location = new System.Drawing.Point(244, 104);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(241, 19);
            this.lblTitulo2.TabIndex = 17;
            this.lblTitulo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnBuscar2.IconColor = System.Drawing.Color.Goldenrod;
            this.btnBuscar2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnBuscar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar2.Location = new System.Drawing.Point(67, 59);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 5);
            this.btnBuscar2.Size = new System.Drawing.Size(159, 42);
            this.btnBuscar2.TabIndex = 15;
            this.btnBuscar2.Text = "BUSCAR";
            this.btnBuscar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar2.UseVisualStyleBackColor = true;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // ipbPdf2
            // 
            this.ipbPdf2.BackColor = System.Drawing.Color.Transparent;
            this.ipbPdf2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ipbPdf2.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.ipbPdf2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ipbPdf2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbPdf2.IconSize = 67;
            this.ipbPdf2.Location = new System.Drawing.Point(334, 34);
            this.ipbPdf2.Name = "ipbPdf2";
            this.ipbPdf2.Size = new System.Drawing.Size(67, 67);
            this.ipbPdf2.TabIndex = 16;
            this.ipbPdf2.TabStop = false;
            this.ipbPdf2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rtbPdf1);
            this.panel3.Controls.Add(this.gunaGroupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(534, 474);
            this.panel3.TabIndex = 20;
            // 
            // rtbPdf1
            // 
            this.rtbPdf1.Location = new System.Drawing.Point(20, 180);
            this.rtbPdf1.Name = "rtbPdf1";
            this.rtbPdf1.ReadOnly = true;
            this.rtbPdf1.Size = new System.Drawing.Size(497, 272);
            this.rtbPdf1.TabIndex = 18;
            this.rtbPdf1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel7);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1074, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TEXTO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.text2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(537, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(534, 474);
            this.panel7.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Escriba el texto nro 2:";
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(19, 76);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(497, 378);
            this.text2.TabIndex = 21;
            this.text2.Text = "";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.text1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(534, 474);
            this.panel6.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Escriba el texto nro 1:";
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(19, 76);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(497, 378);
            this.text1.TabIndex = 19;
            this.text1.Text = "";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tcrlMenu);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 66);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1082, 509);
            this.panel5.TabIndex = 22;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.ForestGreen;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(895, 127);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(175, 49);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.Text = "BUSAR COINCIDENCIAS";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 763);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1100, 810);
            this.MinimumSize = new System.Drawing.Size(1100, 810);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deteccion de Plagio : Rabin Karp";
            ((System.ComponentModel.ISupportInitialize)(this.ipbPdf1)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tcrlMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.gunaGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbPdf2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnBuscar1;
        private FontAwesome.Sharp.IconPictureBox ipbPdf1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcrlMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private System.Windows.Forms.Label lblTitulo2;
        private FontAwesome.Sharp.IconButton btnBuscar2;
        private FontAwesome.Sharp.IconPictureBox ipbPdf2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton btnEjecutar;
        private System.Windows.Forms.RichTextBox rtbPdf2;
        private System.Windows.Forms.RichTextBox rtbPdf1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lblCoincidencias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox text2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox text1;
        private System.Windows.Forms.Label lblR2;
        private System.Windows.Forms.Label lblR1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

