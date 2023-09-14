using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;


namespace AppDeteccionPlagio_RabinKarp
{
    public partial class FormPrincipal : Form
    {
        /*DESARROLLADO PARA EL CURSO DE ALGORITMOS AVANZADOS UNSAAC 2020-2
         INGENIERIA INFORMATICA Y DE SISTEMAS
         INTEGRANTES:
        -Alex Helder Huancara
        -Ronaldo Quispe
        -Daniel Eduardo Sarco
        -Ronaldinho Vega Centeno
        */

        private string Ruta1;
        private string Ruta2;
        private string texto1;
        private string texto2;
        string[] Oraciones1;
        string[] Oraciones2;
        FrmBuscarCoincidencias FC = new FrmBuscarCoincidencias();
        public FormPrincipal()
        {
            InitializeComponent();
            
        }        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fd = new OpenFileDialog())
                {
                    fd.Filter = "Archivos PDF(*.pdf) |*.pdf";
                    if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fd.FileName))
                    {
                        Ruta1 = fd.FileName;
                        ipbPdf1.Visible = true;
                        lblTitulo1.Text = System.IO.Path.GetFileNameWithoutExtension(fd.FileName);
                    }
                }
                
                PDDocument pdf = PDDocument.load(Ruta1);
                PDFTextStripper stripper = new PDFTextStripper();
                rtbPdf1.Text = (stripper.getText(pdf)).ToUpper();
            }
            catch
            {
                MessageBox.Show("No se selecciono ningun archivo", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fd = new OpenFileDialog())
                {
                    fd.Filter = "Archivos PDF(*.pdf) |*.pdf";
                    if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fd.FileName))
                    {
                        Ruta2 = fd.FileName;
                        ipbPdf2.Visible = true;
                        lblTitulo2.Text = System.IO.Path.GetFileNameWithoutExtension(fd.FileName);

                    }
                }
                PDDocument pdf = PDDocument.load(Ruta2);
                PDFTextStripper stripper = new PDFTextStripper();
                rtbPdf2.Text = (stripper.getText(pdf)).ToUpper();
                
            }
            catch
            {
                MessageBox.Show("No se selecciono ningun archivo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            bool validar = false;
            if (tcrlMenu.SelectedIndex == 0)
            {
                transformar_mayusculas(rtbPdf1.Text, rtbPdf2.Text);
                if (rtbPdf1.Text != "" && rtbPdf2.Text != "")
                    validar = true;
            }
                  
            else if (tcrlMenu.SelectedIndex == 1)
            {
                transformar_mayusculas(text1.Text, text2.Text);
                if (text1.Text != "" && text2.Text != "")
                    validar = true;
            }
            if(validar)
            {
                filtrado();
                Eliminar_Palabras_irrelevantes();
                separar_unidades();
                float[] Resultados = calcular_hash_Textos();
                lblR1.Text = "";
                lblR2.Text = "";
                lblR1.Text = Resultados[1].ToString();
                lblR2.Text = Resultados[0].ToString() + "%";
                if (Resultados[0] >= 30)
                {
                    lblResultado.ForeColor = Color.Red;
                    lblResultado.Text = "EXISTE PLAGIO ENTRE LOS DOCUMENTOS";
                }
                else
                {
                    lblResultado.ForeColor = Color.Green;
                    lblResultado.Text = "NO EXISTE PLAGIO ENTRE LOS DOCUMENTOS";
                }
            }
            else
            MessageBox.Show("Debe seleccionar 2 documentos de texto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }


    
        private void transformar_mayusculas(string pdf1,string pdf2)
        {
            texto1 = pdf1.ToUpper();
            texto2 = pdf2.ToUpper();
        }
        private void filtrado()
        {
            //texto1 = String.Concat(texto1.Where(c => !Char.IsWhiteSpace(c)));
            //texto2 = String.Concat(texto2.Where(c => !Char.IsWhiteSpace(c)));
            //texto1 = texto1.Replace("\n", ".");
            //texto2 = texto2.Replace("\n", ".");
            texto1 = Regex.Replace(texto1, @"[^\w\s\n\.,;@-]", " ",RegexOptions.None, TimeSpan.FromSeconds(1.5));
            texto2 = Regex.Replace(texto2, @"[^\w\s\n\.,;@-]", " ", RegexOptions.None, TimeSpan.FromSeconds(1.5));
        }
        private void Eliminar_Palabras_irrelevantes()
        {
            string[] palabrasIrrelevantes = { "A", "DE", "DESDE", "EN", "HASTA", "POR", "SOBRE", "Y", "E", "O", "PORQUE", "IS" };

            foreach (string palabra in palabrasIrrelevantes)
            {
                string remplazo = " " + palabra + " ";
                texto1 = Regex.Replace(texto1, @remplazo, " ");
                texto2 = Regex.Replace(texto2, @remplazo, " ");
            }
        }

        private void separar_unidades()
        {
            Oraciones1 = texto1.Split(',', ';', ':', '.', '\n');
            //Oraciones1 = String.Concat(Oraciones1.Where(c => !Char.IsWhiteSpace(c)));
            //Oraciones1 = Oraciones1.Where(i => i != "\n").ToArray();
            
            Oraciones1 = Oraciones1.Where(i => i != " ").ToArray();
            //Oraciones1 = Oraciones1.Where(i => i != "").ToArray();
            //foreach (string o in Oraciones1)
            //    richTextBox1.Text += o + "\n";
            Oraciones2 = texto2.Split(',', ';', ':', '.', '\n');
            //Oraciones2 = Oraciones2.Where(i => i != "\n").ToArray();
            Oraciones2 = Oraciones2.Where(i => i != " ").ToArray();
            //Oraciones2 = Oraciones2.Where(i => i != "").ToArray();
        }

        private float[] calcular_hash_Textos()
        {
            double[] hash1 = rabinKarp(Oraciones1);
            int n1 = hash1.Length;
            double[] hash2 = rabinKarp(Oraciones2);
            int n2 = hash2.Length;
            double[] hashIgual = hash1.Intersect(hash2).ToArray();


            FC.lsbOraciones.Items.Clear();
            foreach (double hash in hashIgual)
            {
                int indice=hashIgual.ToList().IndexOf(hash);
                
                if (Oraciones1[indice]!=" ")
                    FC.lsbOraciones.Items.Add(Oraciones1[indice]);
            }
            
            int n_hashIgual = (hashIgual).Count();
            float porcentaje_similitud = (2 * (float) n_hashIgual / (float)(n1 + n2))*100;
            float[] resultados = new float[4];
            resultados[0] = (float)Math.Round(porcentaje_similitud,2);
            resultados[1] = n_hashIgual;
            resultados[2] = n1;
            resultados[3] = n2;
            return resultados;
        }

     

        private double[] rabinKarp(String[] texto)
        {
            int N = texto.Length;
            double[] a = new double[N];
            for (int i = 0; i < N; i++)
            {
                a[i] = hashPalabra(texto[i]);
            }
            return a;
        }
        
        static double hashPalabra(string oracion)
        {
            int kgram = oracion.Length;
            int primo = 7;
            int[] listaHash = new int[oracion.Length];
            int i = 0;
            foreach (char pal in oracion)
            {
                listaHash[i] = (int)pal;
                i++;
            }

            double has = 0;
            int j = 1;
            for (int k = 0; k < listaHash.Length; k++)
            {
                has += listaHash[k] * Math.Pow(primo, kgram - j);
                j++;
            }

            return has;
        }

        private void tcrlMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            texto1 = "";
            texto2 = "";
            Ruta1 = "";
            Ruta2 = "";
            rtbPdf1.Clear();
            rtbPdf2.Clear();
            text1.Clear();
            text2.Clear();
            lblR1.Text = "";
            lblR2.Text = "";
            ipbPdf1.Visible = false;
            ipbPdf2.Visible = false;
            lblTitulo1.Text = "";
            lblTitulo2.Text = "";
            FC.lsbOraciones.Items.Clear();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FC.lsbOraciones.SelectedIndex = -1;
            FC.richTextBox2.Text = texto1;
            FC.ShowDialog();
        }

    }
}
