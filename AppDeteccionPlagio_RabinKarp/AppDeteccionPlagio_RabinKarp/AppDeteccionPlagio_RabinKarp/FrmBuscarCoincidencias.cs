using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDeteccionPlagio_RabinKarp
{
    public partial class FrmBuscarCoincidencias : Form
    {
        public FrmBuscarCoincidencias()
        {
            InitializeComponent();
        }

        private void lsbOraciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbOraciones.SelectedIndex!=-1)
            Colorear_String_Comun(richTextBox2, lsbOraciones.SelectedItem.ToString());
        }
        private void Colorear_String_Comun(RichTextBox RtxtADN, string Resultado)
        {

            string igual = Resultado;
            int indexOf = 0;
            //colorear mientras existan coincidencias
            while (indexOf != -1)
            {
                // buscamos el indice donde hay una cadena coincidente
                indexOf = RtxtADN.Text.IndexOf(igual, indexOf);
                //si se encontro la coincidencia selecionar la palabra coincidente y colorear de rojo
                if (indexOf != -1)
                {
                    RtxtADN.Select(indexOf, igual.Length);
                    RtxtADN.SelectionColor = Color.Red;
                    indexOf += igual.Length;
                }
            }

        }
    }
}
