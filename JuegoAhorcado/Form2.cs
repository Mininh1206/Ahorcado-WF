using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace JuegoAhorcado
{
    public partial class Menu : Form
    {

        public bool reiniciarPuntos;

        public Menu(Juego vJuego)
        {

            InitializeComponent();

            nPuntos.Text = vJuego.puntos+"";
            nRonda.Text = vJuego.ronda+"";

            reiniciarPuntos = false;

            XPathDocument ficheroPalabras = new XPathDocument("../../Diccionario.xml");
            XPathNavigator xpathPalabras = ficheroPalabras.CreateNavigator();
            XPathNodeIterator resultadoXpathPalabras = xpathPalabras.Select("//cat/@tipo");
            while (resultadoXpathPalabras.MoveNext())
            {
                categorias.Items.Add(resultadoXpathPalabras.Current.Value);
            }
        }

        private void categorias_SelectedValueChanged(object sender, EventArgs e)
        {
            jugar.Enabled = true;
        }

        private void reiniciar_Click(object sender, EventArgs e)
        {

            nPuntos.Text = "0";
            nRonda.Text = "1";

            reiniciarPuntos = true;
        }
    }
}
