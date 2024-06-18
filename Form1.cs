using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

// Nombre del Autor: Waren Jesús Sánchez Madé
// Matrícula: 2023-1198

namespace TDS_005_Navegador
{
    public partial class Form1 : Form
    {
        // Variable para rastrear el estado del modo oscuro
        private bool EsModoOscuro = false;

        // Variable para rastrear si el navegador está actualmente refrescando la página.
        private bool estaActualizando = false;

        // Lista para almacenar las URLs favoritas.
        List<string> Favoritos = new List<string>();

        // Constructor del formulario.
        public Form1()
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
            InitializeWebView(); // Inicializa el componente WebView2.
            ConfigurarModoClaro(); // Inicializa con modo claro por defecto
        }

        // Método asincrónico para inicializar WebView2.
        private async void InitializeWebView()
        {
            // Comprueba que webView2 esté correctamente inicializado en el diseñador.
            if (webView2 != null)
            {
                // Inicializa el componente WebView2.
                await webView2.EnsureCoreWebView2Async(null);
                // Asigna el evento de navegación completada.
                webView2.CoreWebView2.NavigationCompleted += webView2_NavigationCompleted;

                // Navega a la página web predeterminada.
                webView2.CoreWebView2.Navigate("https://www.bing.com/");
            }
        }

        // Evento click para el botón 'Atrás' que navega a la página anterior en el historial del navegador.
        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (webView2.CanGoBack)
            {
                webView2.GoBack(); // Navega a la página anterior.
            }
        }

        // Evento click para el botón 'Adelante' que navega a la página siguiente en el historial del navegador.
        private void btnAdelante_Click(object sender, EventArgs e)
        {
            if (webView2.CanGoForward)
            {
                webView2.GoForward(); // Navega a la página siguiente.
            }
        }

        // Evento click para el botón 'Actualizar' que refresca o detiene la actualización de la página.
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!estaActualizando)
            {
                webView2.Reload(); // Refresca la página.
                estaActualizando = true; // Establece la variable de actualización a verdadero.
            }
            else
            {
                webView2.CoreWebView2.Stop(); // Detiene la actualización de la página.
                estaActualizando = false; // Establece la bandera de actualización a falso.
            }
        }

        // Evento KeyDown para el cuadro de texto 'Buscador' que navega a la URL ingresada al presionar 'Enter'.
        private void txtBuscador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Comprueba si la tecla presionada es Enter.
            {
                if (webView2 != null && webView2.CoreWebView2 != null)
                {
                    string url = txtBuscador.Text.Trim(); // Elimina espacios en blanco al principio y al final

                    // Verifica si la URL es válida
                    if (EsLaUrlValida(url))
                    {
                        webView2.CoreWebView2.Navigate(url); // Navega a la URL ingresada
                    }
                    else
                    {
                        // Si la URL no es válida, intenta agregar 'http://' al principio
                        url = "http://" + url;

                        if (EsLaUrlValida(url))
                        {
                            webView2.CoreWebView2.Navigate(url); // Navega a la URL ingresada con 'http://'
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingrese una URL válida que termine con '.com'", "URL no válida",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning); // Muestra un mensaje de advertencia si la URL no es válida.
                        }
                    }
                }
                e.Handled = true; // Previene el sonido de error de Windows.
            }
        }

        // Método para verificar si la URL es válida.
        private bool EsLaUrlValida(string url)
        {
            // Comprueba si la cadena es una URL con formato correcto.
            if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                return false; // Devuelve falso si la URL no tiene un formato correcto.
            }

            // Intenta crear una Uri a partir de la cadena y comprueba si tiene un esquema HTTP o HTTPS.
            Uri uriResult;
            bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            return result; // Devuelve verdadero si la URL es válida y tiene un esquema HTTP o HTTPS.
        }

        // Método para actualizar el ComboBox con las URLs favoritas.
        private void actualizarCmbBox()
        {
            cmbFavoritos.Items.Clear(); // Limpia los items existentes para evitar duplicados.
            foreach (string direccion in Favoritos)
            {
                cmbFavoritos.Items.Add(direccion); // Agrega cada URL favorita al ComboBox.
            }
        }

        // Evento click para el botón 'Favoritos' que agrega la URL actual a la lista de favoritos y actualiza el ComboBox.
        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            Favoritos.Add(webView2.Source.ToString()); // Agrega la URL actual a la lista de favoritos.
            actualizarCmbBox(); // Actualiza el ComboBox de favoritos.
        }

        // Evento que se dispara al seleccionar un item del ComboBox 'Favoritos', navegando a la URL seleccionada.
        private void cmbFavoritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            webView2.CoreWebView2.Navigate(cmbFavoritos.SelectedItem.ToString()); // Navega a la URL seleccionada.
        }

        // Evento click para el botón 'Hogar' que navega a la página de inicio del navegador.
        private void btnHogar_Click(object sender, EventArgs e)
        {
            webView2.CoreWebView2.Navigate("https://www.bing.com/"); // Navega a la página de inicio.
        }

        // Evento que se dispara cuando una página termina de cargar, restableciendo la variable 'estaActualizando'.
        private void webView2_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            estaActualizando = false; // Restablece la variable de actualización a falso.
        }

        private void btnOscuroClaro_Click(object sender, EventArgs e)
        {
            if (EsModoOscuro)
            {
                ConfigurarModoClaro();
            }
            else
            {
                ConfigurarModoOscuro();
            }

            EsModoOscuro = !EsModoOscuro;
        }

        private void ConfigurarModoClaro()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            toolStrip1.BackColor = Color.LightGray;
            toolStrip1.ForeColor = Color.Black;
            tabControl1.BackColor = Color.White;
            tabControl1.ForeColor = Color.Black;
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                tabPage.BackColor = Color.White;
                tabPage.ForeColor = Color.Black;
            }
            tabPage1.BackColor = Color.White;
            tabPage1.ForeColor = Color.Black;
            webView2.DefaultBackgroundColor = Color.White;

            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.BackColor = Color.LightGray;
                item.ForeColor = Color.Black;
            }

            // Cambiar color de fondo y texto para el ToolStripTextBox y ToolStripComboBox
            txtBuscador.BackColor = Color.White;
            txtBuscador.ForeColor = Color.Black;
            cmbFavoritos.BackColor = Color.White;
            cmbFavoritos.ForeColor = Color.Black;

            // Cambiar íconos a modo claro
            btnAtras.Image = Properties.Resources.flecha_cuadrado_izquierda_modo_claro;
            btnAdelante.Image = Properties.Resources.flecha_cuadrado_derecha_modo_claro;
            btnActualizar.Image = Properties.Resources.girar_cuadrado_modo_claro;
            btnHogar.Image = Properties.Resources.hogar_modo_claro;
            btnFavoritos.Image = Properties.Resources.estrella_de_la_lista_de_deseos_modo_claro;
            btnOscuroClaro.Image = Properties.Resources.eclipse_alt_modo_claro;
        }

        private void ConfigurarModoOscuro()
        {
            this.BackColor = Color.FromArgb(45, 45, 48);
            this.ForeColor = Color.White;
            toolStrip1.BackColor = Color.FromArgb(28, 28, 28);
            toolStrip1.ForeColor = Color.White;
            tabControl1.BackColor = Color.FromArgb(45, 45, 48);
            tabControl1.ForeColor = Color.White;
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                tabPage.BackColor = Color.FromArgb(45, 45, 48);
                tabPage.ForeColor = Color.White;
            }
            tabPage1.BackColor = Color.FromArgb(45, 45, 48);
            tabPage1.ForeColor = Color.White;
            webView2.DefaultBackgroundColor = Color.FromArgb(45, 45, 48);

            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.BackColor = Color.FromArgb(28, 28, 28);
                item.ForeColor = Color.White;
            }

            // Cambiar color de fondo y texto para el ToolStripTextBox y ToolStripComboBox
            txtBuscador.BackColor = Color.FromArgb(60, 60, 64);
            txtBuscador.ForeColor = Color.White;
            cmbFavoritos.BackColor = Color.FromArgb(60, 60, 64);
            cmbFavoritos.ForeColor = Color.White;

            // Cambiar íconos a modo oscuro
            btnAtras.Image = Properties.Resources.flecha_cuadrado_izquierda_modo_oscuro;
            btnAdelante.Image = Properties.Resources.flecha_cuadrado_derecha_modo_oscuro;
            btnActualizar.Image = Properties.Resources.girar_cuadrado_modo_oscuro;
            btnHogar.Image = Properties.Resources.hogar_modo_oscuro;
            btnFavoritos.Image = Properties.Resources.estrella_de_la_lista_de_deseos_modo_oscuro;
            btnOscuroClaro.Image = Properties.Resources.eclipse_alt_modo_oscuro;
        }
    }
}
