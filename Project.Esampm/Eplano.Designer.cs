namespace Project.Esampm
{
    partial class Eplano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eplano));
            this.ToolMenu = new System.Windows.Forms.ToolStrip();
            this.toolArchivo = new System.Windows.Forms.ToolStripSplitButton();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.haberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEditar = new System.Windows.Forms.ToolStripSplitButton();
            this.toolLimpiar = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolHerramientas = new System.Windows.Forms.ToolStrip();
            this.toolNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolAbrir = new System.Windows.Forms.ToolStripButton();
            this.toolSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolPuntero = new System.Windows.Forms.ToolStripButton();
            this.toolSep4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTriangulo = new System.Windows.Forms.ToolStripButton();
            this.toolSep5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolRombo = new System.Windows.Forms.ToolStripButton();
            this.toolSep6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripRectangulo = new System.Windows.Forms.ToolStripButton();
            this.AreaDraw = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolCoord = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolMenu.SuspendLayout();
            this.ToolHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AreaDraw)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolMenu
            // 
            this.ToolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolArchivo,
            this.toolEditar});
            this.ToolMenu.Location = new System.Drawing.Point(0, 0);
            this.ToolMenu.Name = "ToolMenu";
            this.ToolMenu.Size = new System.Drawing.Size(1033, 25);
            this.ToolMenu.TabIndex = 2;
            this.ToolMenu.Text = "toolStrip1";
            // 
            // toolArchivo
            // 
            this.toolArchivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.toolSalir,
            this.haberToolStripMenuItem});
            this.toolArchivo.Image = ((System.Drawing.Image)(resources.GetObject("toolArchivo.Image")));
            this.toolArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolArchivo.Name = "toolArchivo";
            this.toolArchivo.Size = new System.Drawing.Size(64, 22);
            this.toolArchivo.Text = "&Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.nuevoToolStripMenuItem.Text = "N&uevo";
            // 
            // toolSalir
            // 
            this.toolSalir.Name = "toolSalir";
            this.toolSalir.Size = new System.Drawing.Size(109, 22);
            this.toolSalir.Text = "&Salir";
            // 
            // haberToolStripMenuItem
            // 
            this.haberToolStripMenuItem.Name = "haberToolStripMenuItem";
            this.haberToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.haberToolStripMenuItem.Text = "haber";
            // 
            // toolEditar
            // 
            this.toolEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolLimpiar});
            this.toolEditar.Image = ((System.Drawing.Image)(resources.GetObject("toolEditar.Image")));
            this.toolEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEditar.Name = "toolEditar";
            this.toolEditar.Size = new System.Drawing.Size(53, 22);
            this.toolEditar.Text = "&Editar";
            // 
            // toolLimpiar
            // 
            this.toolLimpiar.Name = "toolLimpiar";
            this.toolLimpiar.Size = new System.Drawing.Size(114, 22);
            this.toolLimpiar.Text = "&Limpiar";
            // 
            // ToolHerramientas
            // 
            this.ToolHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNuevo,
            this.toolSep1,
            this.toolAbrir,
            this.toolSep2,
            this.toolGuardar,
            this.toolSep3,
            this.toolPuntero,
            this.toolSep4,
            this.toolTriangulo,
            this.toolSep5,
            this.toolRombo,
            this.toolSep6,
            this.toolStripRectangulo});
            this.ToolHerramientas.Location = new System.Drawing.Point(0, 25);
            this.ToolHerramientas.Name = "ToolHerramientas";
            this.ToolHerramientas.Size = new System.Drawing.Size(1033, 25);
            this.ToolHerramientas.TabIndex = 3;
            this.ToolHerramientas.Text = "toolStrip1";
            this.ToolHerramientas.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolHerramientas_ItemClicked);
            // 
            // toolNuevo
            // 
            this.toolNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNuevo.Image = ((System.Drawing.Image)(resources.GetObject("toolNuevo.Image")));
            this.toolNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNuevo.Name = "toolNuevo";
            this.toolNuevo.Size = new System.Drawing.Size(23, 22);
            this.toolNuevo.Text = "Nuevo";
            // 
            // toolSep1
            // 
            this.toolSep1.Name = "toolSep1";
            this.toolSep1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolAbrir
            // 
            this.toolAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAbrir.Image = ((System.Drawing.Image)(resources.GetObject("toolAbrir.Image")));
            this.toolAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAbrir.Name = "toolAbrir";
            this.toolAbrir.Size = new System.Drawing.Size(23, 22);
            this.toolAbrir.Text = "Abrir";
            // 
            // toolSep2
            // 
            this.toolSep2.Name = "toolSep2";
            this.toolSep2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolGuardar
            // 
            this.toolGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolGuardar.Image = ((System.Drawing.Image)(resources.GetObject("toolGuardar.Image")));
            this.toolGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolGuardar.Name = "toolGuardar";
            this.toolGuardar.Size = new System.Drawing.Size(23, 22);
            this.toolGuardar.Text = "Guardar";
            // 
            // toolSep3
            // 
            this.toolSep3.Name = "toolSep3";
            this.toolSep3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolPuntero
            // 
            this.toolPuntero.CheckOnClick = true;
            this.toolPuntero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPuntero.Image = ((System.Drawing.Image)(resources.GetObject("toolPuntero.Image")));
            this.toolPuntero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPuntero.Name = "toolPuntero";
            this.toolPuntero.Size = new System.Drawing.Size(23, 22);
            this.toolPuntero.Text = "Puntero";
            this.toolPuntero.Click += new System.EventHandler(this.toolPuntero_Click);
            // 
            // toolSep4
            // 
            this.toolSep4.Name = "toolSep4";
            this.toolSep4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolTriangulo
            // 
            this.toolTriangulo.CheckOnClick = true;
            this.toolTriangulo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolTriangulo.Image = ((System.Drawing.Image)(resources.GetObject("toolTriangulo.Image")));
            this.toolTriangulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTriangulo.Name = "toolTriangulo";
            this.toolTriangulo.Size = new System.Drawing.Size(23, 22);
            this.toolTriangulo.Text = "Triángulo";
            this.toolTriangulo.Click += new System.EventHandler(this.toolTriangulo_Click);
            // 
            // toolSep5
            // 
            this.toolSep5.Name = "toolSep5";
            this.toolSep5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolRombo
            // 
            this.toolRombo.CheckOnClick = true;
            this.toolRombo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRombo.Image = ((System.Drawing.Image)(resources.GetObject("toolRombo.Image")));
            this.toolRombo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRombo.Name = "toolRombo";
            this.toolRombo.Size = new System.Drawing.Size(23, 22);
            this.toolRombo.Text = "Rombo";
            this.toolRombo.Click += new System.EventHandler(this.toolRombo_Click);
            // 
            // toolSep6
            // 
            this.toolSep6.Name = "toolSep6";
            this.toolSep6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripRectangulo
            // 
            this.toolStripRectangulo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRectangulo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRectangulo.Image")));
            this.toolStripRectangulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRectangulo.Name = "toolStripRectangulo";
            this.toolStripRectangulo.Size = new System.Drawing.Size(23, 22);
            this.toolStripRectangulo.Text = "Cuadrado";
            this.toolStripRectangulo.Click += new System.EventHandler(this.toolStripRectangulo_Click);
            // 
            // AreaDraw
            // 
            this.AreaDraw.BackColor = System.Drawing.Color.White;
            this.AreaDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AreaDraw.Location = new System.Drawing.Point(0, 50);
            this.AreaDraw.Name = "AreaDraw";
            this.AreaDraw.Size = new System.Drawing.Size(1033, 552);
            this.AreaDraw.TabIndex = 4;
            this.AreaDraw.TabStop = false;
            this.AreaDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.AreaDraw_Paint);
            this.AreaDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AreaDraw_MouseDown);
            this.AreaDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AreaDraw_MouseMove);
            this.AreaDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AreaDraw_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbLocation,
            this.toolCoord,
            this.lbEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 580);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1033, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbLocation
            // 
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(72, 17);
            this.lbLocation.Text = "Localización";
            // 
            // toolCoord
            // 
            this.toolCoord.Name = "toolCoord";
            this.toolCoord.Size = new System.Drawing.Size(0, 17);
            // 
            // lbEstado
            // 
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbEstado.Size = new System.Drawing.Size(48, 17);
            this.lbEstado.Text = "Estado: ";
            // 
            // Eplano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 602);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.AreaDraw);
            this.Controls.Add(this.ToolHerramientas);
            this.Controls.Add(this.ToolMenu);
            this.Name = "Eplano";
            this.Text = "Eplano";
            this.Load += new System.EventHandler(this.Eplano_Load);
            this.ToolMenu.ResumeLayout(false);
            this.ToolMenu.PerformLayout();
            this.ToolHerramientas.ResumeLayout(false);
            this.ToolHerramientas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AreaDraw)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolMenu;
        private System.Windows.Forms.ToolStripSplitButton toolArchivo;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolSalir;
        private System.Windows.Forms.ToolStripMenuItem haberToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolEditar;
        private System.Windows.Forms.ToolStripMenuItem toolLimpiar;
        private System.Windows.Forms.ToolStrip ToolHerramientas;
        private System.Windows.Forms.ToolStripButton toolNuevo;
        private System.Windows.Forms.ToolStripSeparator toolSep1;
        private System.Windows.Forms.ToolStripButton toolAbrir;
        private System.Windows.Forms.ToolStripSeparator toolSep2;
        private System.Windows.Forms.ToolStripButton toolGuardar;
        private System.Windows.Forms.ToolStripSeparator toolSep3;
        private System.Windows.Forms.ToolStripButton toolPuntero;
        private System.Windows.Forms.ToolStripSeparator toolSep4;
        private System.Windows.Forms.ToolStripButton toolTriangulo;
        private System.Windows.Forms.ToolStripSeparator toolSep5;
        private System.Windows.Forms.ToolStripButton toolRombo;
        private System.Windows.Forms.ToolStripSeparator toolSep6;
        private System.Windows.Forms.PictureBox AreaDraw;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbLocation;
        private System.Windows.Forms.ToolStripStatusLabel toolCoord;
        private System.Windows.Forms.ToolStripStatusLabel lbEstado;
        private System.Windows.Forms.ToolStripButton toolStripRectangulo;
    }
}