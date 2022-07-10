using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;
using System.Xml.XPath;

namespace JuegoAhorcado
{
    public partial class Juego : Form
    {

        List<String> palabras;
        String palabraAdivinar;
        List<char> letrasDichas;
        Menu catMenu;
        public int puntos = 0;
        public int ronda = 1;
        int intentos;

        public Juego()
        {
            InitializeComponent();

            menu();

        }

        private void menu()
        {
            resolver.Enabled = true;

            cancelar.Visible = false;

            palabraResolver.Visible = false;
            palabraResolver.Text = "";

            letraPulsada.Visible = false;

            palabras = new List<string>();
            letrasDichas = new List<char>();

            palabraAdivinar = "";

            palabraOculta.Text = "";

            intentos = 0;

            Random nRandom = new Random();

            catMenu = new Menu(this);

            this.Hide();

            if (catMenu.ShowDialog() == DialogResult.OK)
            {

                imgAhorcado.Image = null;

                catMenu.Hide();
                if (!this.IsDisposed)
                    this.Show();

                XPathDocument ficheroPalabras = new XPathDocument("../../Diccionario.xml");
                XPathNavigator xpathPalabras = ficheroPalabras.CreateNavigator();
                XPathNodeIterator resultadoXpathPalabras = xpathPalabras.Select("//cat[./@tipo=" + '"' + catMenu.categorias.Text + '"' + "]/p/node()");

                catMenu.Close();


                while (resultadoXpathPalabras.MoveNext())
                {
                    palabras.Add(resultadoXpathPalabras.Current.Value);
                }

                palabraAdivinar = palabras[nRandom.Next(0, palabras.Count)];

                foreach (char temp in palabraAdivinar)
                {
                    if (temp == ' ')
                        palabraOculta.Text = palabraOculta.Text + "   ";
                    else
                        palabraOculta.Text = palabraOculta.Text + " _ ";
                }

            }
            else if (catMenu.DialogResult == DialogResult.Cancel)
                this.Close();
            if (catMenu.reiniciarPuntos)
            {
                puntos = 0;
                ronda = 1;
            }

            nIntentos.Text = 7 - intentos + "";
            nPuntos.Text = puntos + "";
        }

        private void nuevaLetra(char letraInput)
        {

            SoundPlayer tiza = new SoundPlayer("../../wav/tiza1.wav");
            tiza.Play();

            if (letraInput.ToString()!=null)
            {
                if (letrasDichas.Contains(letraInput))
                {
                    letraPulsada.Visible = true;
                }
                else
                {
                    palabraOculta.Text = "";
                    letrasDichas.Add(letraInput);

                    bool acertada = false;

                    foreach (char temp in palabraAdivinar)
                    {
                        if (letrasDichas.Contains(char.ToUpper(temp)) || letrasDichas.Contains(char.ToLower(temp)))
                        {
                            palabraOculta.Text = palabraOculta.Text + " " + temp + " ";
                            if (char.ToUpper(temp) == letraInput)
                                acertada = true;
                        }
                        else
                        {
                            if (temp == ' ')
                                palabraOculta.Text = palabraOculta.Text + "   ";
                            else
                                palabraOculta.Text = palabraOculta.Text + " _ ";
                        }
                    }
                    if (acertada)
                    {
                        puntos += 2;
                        comprobarPalabra();
                    }
                    else
                    {
                        puntos--;
                        intentos++;
                        comprobarPalabra();
                    }
                    
                }
            }
        }

        private void comprobarPalabra()
        {
            String[] listaTemp = palabraOculta.Text.Split(' ');
            String palabraCompleta = "";

            foreach (String temp in listaTemp)
            {
                palabraCompleta += temp;
            }

            listaTemp = palabraAdivinar.Split(' ');
            String palabraAdivinarSinEspacios = "";

            foreach (String temp in listaTemp)
            {
                palabraAdivinarSinEspacios += temp;
            }

            if (palabraCompleta.Equals(palabraAdivinarSinEspacios))
            {
                puntos += 10;
                sigRonda.Visible = true;
                this.KeyDown -= Juego_KeyDown;
                
            }
            else if (intentos >= 7)
            {
                puntos -= 5;
                Perdido vPerdido = new Perdido();

                this.Hide();

                if (vPerdido.ShowDialog() == DialogResult.OK || true)
                {
                    ronda++;
                    menu();
                }

                vPerdido.Close();
                if (!this.IsDisposed)
                    this.Show();

            }
        }

        private void Juego_KeyDown(object sender, KeyEventArgs e)
        {

            int intentosTemp = intentos;

            letraPulsada.Visible = false;

            try
            {
                if (e.KeyCode.ToString().Equals("Oemtilde"))
                    nuevaLetra('Ñ');
                else
                    nuevaLetra(char.ToUpper(char.Parse(e.KeyCode.ToString())));
            }
            catch (FormatException)
            {

            }

            nIntentos.Text = 7 - intentos + "";
            nPuntos.Text = puntos + "";

            if  (intentosTemp!=intentos && intentos>0 && intentos<8)
                imgAhorcado.Image = Image.FromFile("../../img/e"+intentos+".png");
        }

        private void sigRonda_Click(object sender, EventArgs e)
        {
            intentos = 0;
            ronda++;
            sigRonda.Visible = false;
            this.KeyDown += new KeyEventHandler(this.Juego_KeyDown);
            menu();
            
        }

        private void resolver_Click(object sender, EventArgs e)
        {
            if (palabraResolver.Visible)
            {
                if (palabraResolver.Text != null)
                    if (palabraAdivinar.ToUpper().Equals(palabraResolver.Text.ToUpper()))
                    {
                        puntos += 10;

                        palabraOculta.Text = "";

                        foreach (char temp in palabraAdivinar)
                        {
                            palabraOculta.Text += " " + temp + " ";
                        }

                        sigRonda.Visible = true;
                        resolver.Enabled = false;
                        this.KeyDown -= Juego_KeyDown;
                    }
                    else
                    {
                        puntos -= 5;
                        Perdido vPerdido = new Perdido();

                        this.Hide();

                        if (vPerdido.ShowDialog() == DialogResult.OK || true)
                        {
                            ronda++;
                            menu();
                        }

                        vPerdido.Close();
                        if (!this.IsDisposed)
                            this.Show();
                    }
            }
            else
            {
                palabraResolver.Visible = true;
                cancelar.Visible = true;
            }
                    
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            palabraResolver.Visible = false;
            cancelar.Visible = false;
        }
    }
}
