namespace TiendaDeDiscos
{
    partial class FrmTienda
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTienda));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_item_articulo = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_proveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemGeneroMusical = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generoMusicalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.tm_tiempo = new System.Windows.Forms.Timer(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_articulo,
            this.formatoToolStripMenuItem,
            this.statusToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.configuracionToolStripMenuItem,
            this.generoMusicalesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(5, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.menuStrip1.Size = new System.Drawing.Size(1521, 83);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // menu_item_articulo
            // 
            this.menu_item_articulo.Image = ((System.Drawing.Image)(resources.GetObject("menu_item_articulo.Image")));
            this.menu_item_articulo.Name = "menu_item_articulo";
            this.menu_item_articulo.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.menu_item_articulo.Size = new System.Drawing.Size(167, 59);
            this.menu_item_articulo.Text = "Gestión de Album";
            this.menu_item_articulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menu_item_articulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_proveedor});
            this.formatoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("formatoToolStripMenuItem.Image")));
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(183, 59);
            this.formatoToolStripMenuItem.Text = "Gestión de Canción";
            this.formatoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.formatoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_item_proveedor
            // 
            this.menu_item_proveedor.Name = "menu_item_proveedor";
            this.menu_item_proveedor.Size = new System.Drawing.Size(197, 34);
            this.menu_item_proveedor.Text = "Proveedor";
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("statusToolStripMenuItem.Image")));
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(190, 59);
            this.statusToolStripMenuItem.Text = "Gestión de Cantante";
            this.statusToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.statusToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemGeneroMusical});
            this.inventarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inventarioToolStripMenuItem.Image")));
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(218, 59);
            this.inventarioToolStripMenuItem.Text = "Gestión Genero Musical";
            this.inventarioToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.inventarioToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuItemGeneroMusical
            // 
            this.MenuItemGeneroMusical.BackColor = System.Drawing.Color.Khaki;
            this.MenuItemGeneroMusical.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemGeneroMusical.Name = "MenuItemGeneroMusical";
            this.MenuItemGeneroMusical.Size = new System.Drawing.Size(263, 38);
            this.MenuItemGeneroMusical.Text = "GeneroMusical";
            this.MenuItemGeneroMusical.Click += new System.EventHandler(this.MenuItemGeneroMusical_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriaToolStripMenuItem.Image")));
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(208, 59);
            this.categoriaToolStripMenuItem.Text = "Gestión Grupo Musical";
            this.categoriaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.categoriaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayudaToolStripMenuItem.Image")));
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(127, 59);
            this.ayudaToolStripMenuItem.Text = "Gestión Pais";
            this.ayudaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ayudaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 59);
            this.toolStripMenuItem1.Text = "Formato Musical";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("configuracionToolStripMenuItem.Image")));
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(101, 59);
            this.configuracionToolStripMenuItem.Text = "Reportes";
            this.configuracionToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.configuracionToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // generoMusicalesToolStripMenuItem
            // 
            this.generoMusicalesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("generoMusicalesToolStripMenuItem.Image")));
            this.generoMusicalesToolStripMenuItem.Name = "generoMusicalesToolStripMenuItem";
            this.generoMusicalesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.generoMusicalesToolStripMenuItem.Size = new System.Drawing.Size(142, 59);
            this.generoMusicalesToolStripMenuItem.Text = "Configuración";
            this.generoMusicalesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.generoMusicalesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightYellow;
            this.label1.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(986, 955);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightYellow;
            this.label2.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 955);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hora:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_fecha.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(1155, 955);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(178, 39);
            this.lbl_fecha.TabIndex = 5;
            this.lbl_fecha.Text = "xcvxcvxcvxc";
            this.lbl_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_hora.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.Location = new System.Drawing.Point(472, 955);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(106, 39);
            this.lbl_hora.TabIndex = 4;
            this.lbl_hora.Text = "sdfsffs";
            this.lbl_hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tm_tiempo
            // 
            this.tm_tiempo.Enabled = true;
            this.tm_tiempo.Tick += new System.EventHandler(this.tm_tiempo_Tick_1);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.toolStripMenuItem2.Size = new System.Drawing.Size(77, 59);
            this.toolStripMenuItem2.Text = "Ayuda";
            this.toolStripMenuItem2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // FrmTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1531, 1013);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTienda";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido a la Tienda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_item_articulo;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_item_proveedor;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generoMusicalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Timer tm_tiempo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemGeneroMusical;
    }
}