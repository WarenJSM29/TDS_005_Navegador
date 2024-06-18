namespace TDS_005_Navegador
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAtras = new System.Windows.Forms.ToolStripButton();
            this.btnAdelante = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.txtBuscador = new System.Windows.Forms.ToolStripTextBox();
            this.cmbFavoritos = new System.Windows.Forms.ToolStripComboBox();
            this.btnFavoritos = new System.Windows.Forms.ToolStripButton();
            this.btnHogar = new System.Windows.Forms.ToolStripButton();
            this.btnOscuroClaro = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 614);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webView2);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(879, 588);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webView2
            // 
            this.webView2.AllowExternalDrop = true;
            this.webView2.CreationProperties = null;
            this.webView2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView2.Location = new System.Drawing.Point(0, 31);
            this.webView2.Name = "webView2";
            this.webView2.Size = new System.Drawing.Size(879, 561);
            this.webView2.TabIndex = 1;
            this.webView2.ZoomFactor = 1D;
            this.webView2.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.webView2_NavigationCompleted);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAtras,
            this.btnAdelante,
            this.btnActualizar,
            this.txtBuscador,
            this.cmbFavoritos,
            this.btnFavoritos,
            this.btnHogar,
            this.btnOscuroClaro});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(873, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAtras
            // 
            this.btnAtras.AutoSize = false;
            this.btnAtras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAtras.Image = global::TDS_005_Navegador.Properties.Resources.flecha_cuadrado_izquierda_modo_claro;
            this.btnAtras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(23, 22);
            this.btnAtras.Text = "toolStripButton1";
            this.btnAtras.ToolTipText = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAdelante
            // 
            this.btnAdelante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdelante.Image = global::TDS_005_Navegador.Properties.Resources.flecha_cuadrado_derecha_modo_claro;
            this.btnAdelante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(23, 22);
            this.btnAdelante.Text = "Avanzar";
            this.btnAdelante.Click += new System.EventHandler(this.btnAdelante_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnActualizar.Image = global::TDS_005_Navegador.Properties.Resources.girar_cuadrado_modo_claro;
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(23, 22);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(600, 25);
            this.txtBuscador.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscador_KeyDown);
            // 
            // cmbFavoritos
            // 
            this.cmbFavoritos.Name = "cmbFavoritos";
            this.cmbFavoritos.Size = new System.Drawing.Size(121, 25);
            this.cmbFavoritos.SelectedIndexChanged += new System.EventHandler(this.cmbFavoritos_SelectedIndexChanged);
            // 
            // btnFavoritos
            // 
            this.btnFavoritos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFavoritos.Image = global::TDS_005_Navegador.Properties.Resources.estrella_de_la_lista_de_deseos_modo_claro;
            this.btnFavoritos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFavoritos.Name = "btnFavoritos";
            this.btnFavoritos.Size = new System.Drawing.Size(23, 22);
            this.btnFavoritos.Text = "Favoritos";
            this.btnFavoritos.Click += new System.EventHandler(this.btnFavoritos_Click);
            // 
            // btnHogar
            // 
            this.btnHogar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHogar.Image = global::TDS_005_Navegador.Properties.Resources.hogar_modo_claro;
            this.btnHogar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHogar.Name = "btnHogar";
            this.btnHogar.Size = new System.Drawing.Size(23, 22);
            this.btnHogar.Text = "Hogar";
            this.btnHogar.Click += new System.EventHandler(this.btnHogar_Click);
            // 
            // btnOscuroClaro
            // 
            this.btnOscuroClaro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOscuroClaro.Image = global::TDS_005_Navegador.Properties.Resources.eclipse_alt_modo_claro;
            this.btnOscuroClaro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOscuroClaro.Name = "btnOscuroClaro";
            this.btnOscuroClaro.Size = new System.Drawing.Size(23, 22);
            this.btnOscuroClaro.Text = "Cambiar Modo Oscuro y Claro";
            this.btnOscuroClaro.Click += new System.EventHandler(this.btnOscuroClaro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 614);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Waren";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAtras;
        private System.Windows.Forms.ToolStripButton btnAdelante;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnFavoritos;
        private System.Windows.Forms.ToolStripTextBox txtBuscador;
        private System.Windows.Forms.ToolStripComboBox cmbFavoritos;
        private System.Windows.Forms.ToolStripButton btnHogar;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
        private System.Windows.Forms.ToolStripButton btnOscuroClaro;
    }
}

