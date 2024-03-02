namespace TiendaDeDiscos
{
    partial class FrmProducto
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
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.btn_img_local = new System.Windows.Forms.Button();
            this.pbx_img = new System.Windows.Forms.PictureBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.cbo_estilo = new System.Windows.Forms.ComboBox();
            this.cbo_edicion = new System.Windows.Forms.ComboBox();
            this.txt_img = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.lbl_estilo = new System.Windows.Forms.Label();
            this.lbl_edicion = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_img = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menu_volver = new System.Windows.Forms.ToolStripMenuItem();
            this.error_icono = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_img)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_icono)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_precio
            // 
            this.txt_precio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_precio.BackColor = System.Drawing.SystemColors.Window;
            this.txt_precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_precio.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_precio.Location = new System.Drawing.Point(289, 328);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(513, 32);
            this.txt_precio.TabIndex = 4;
            this.txt_precio.TextChanged += new System.EventHandler(this.txt_precio_TextChanged);
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_precio.Location = new System.Drawing.Point(151, 327);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(98, 29);
            this.lbl_precio.TabIndex = 64;
            this.lbl_precio.Text = "Precio $:";
            // 
            // btn_img_local
            // 
            this.btn_img_local.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_img_local.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_img_local.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_img_local.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_img_local.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_img_local.Location = new System.Drawing.Point(946, 559);
            this.btn_img_local.Name = "btn_img_local";
            this.btn_img_local.Size = new System.Drawing.Size(481, 42);
            this.btn_img_local.TabIndex = 9;
            this.btn_img_local.Text = "Subir Imagen Local";
            this.btn_img_local.UseVisualStyleBackColor = false;
            // 
            // pbx_img
            // 
            this.pbx_img.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbx_img.Location = new System.Drawing.Point(860, 12);
            this.pbx_img.Name = "pbx_img";
            this.pbx_img.Size = new System.Drawing.Size(633, 519);
            this.pbx_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_img.TabIndex = 62;
            this.pbx_img.TabStop = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancelar.Location = new System.Drawing.Point(423, 559);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(290, 42);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aceptar.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_aceptar.Location = new System.Drawing.Point(92, 559);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(290, 42);
            this.btn_aceptar.TabIndex = 7;
            this.btn_aceptar.Text = "Agregar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // cbo_estilo
            // 
            this.cbo_estilo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_estilo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_estilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_estilo.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_estilo.FormattingEnabled = true;
            this.cbo_estilo.Location = new System.Drawing.Point(289, 444);
            this.cbo_estilo.Name = "cbo_estilo";
            this.cbo_estilo.Size = new System.Drawing.Size(513, 28);
            this.cbo_estilo.TabIndex = 6;
            // 
            // cbo_edicion
            // 
            this.cbo_edicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_edicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_edicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_edicion.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_edicion.FormattingEnabled = true;
            this.cbo_edicion.Location = new System.Drawing.Point(289, 389);
            this.cbo_edicion.Name = "cbo_edicion";
            this.cbo_edicion.Size = new System.Drawing.Size(513, 28);
            this.cbo_edicion.TabIndex = 5;
            // 
            // txt_img
            // 
            this.txt_img.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_img.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_img.Location = new System.Drawing.Point(289, 214);
            this.txt_img.Name = "txt_img";
            this.txt_img.Size = new System.Drawing.Size(513, 27);
            this.txt_img.TabIndex = 2;
            this.txt_img.TextChanged += new System.EventHandler(this.txt_img_TextChanged);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cantidad.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(289, 275);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(513, 27);
            this.txt_cantidad.TabIndex = 3;
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fecha.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha.Location = new System.Drawing.Point(289, 160);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(513, 26);
            this.dtp_fecha.TabIndex = 1;
            // 
            // txt_titulo
            // 
            this.txt_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_titulo.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titulo.Location = new System.Drawing.Point(289, 112);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(513, 27);
            this.txt_titulo.TabIndex = 0;
            // 
            // lbl_estilo
            // 
            this.lbl_estilo.AutoSize = true;
            this.lbl_estilo.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estilo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_estilo.Location = new System.Drawing.Point(176, 444);
            this.lbl_estilo.Name = "lbl_estilo";
            this.lbl_estilo.Size = new System.Drawing.Size(70, 29);
            this.lbl_estilo.TabIndex = 53;
            this.lbl_estilo.Text = "Estilo:";
            // 
            // lbl_edicion
            // 
            this.lbl_edicion.AutoSize = true;
            this.lbl_edicion.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edicion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_edicion.Location = new System.Drawing.Point(160, 384);
            this.lbl_edicion.Name = "lbl_edicion";
            this.lbl_edicion.Size = new System.Drawing.Size(89, 29);
            this.lbl_edicion.TabIndex = 52;
            this.lbl_edicion.Text = "Edicion:";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_fecha.Location = new System.Drawing.Point(16, 160);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(233, 29);
            this.lbl_fecha.TabIndex = 51;
            this.lbl_fecha.Text = "Fecha De Lanzamiento:";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_cantidad.Location = new System.Drawing.Point(7, 271);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(242, 29);
            this.lbl_cantidad.TabIndex = 50;
            this.lbl_cantidad.Text = "Cantidad De Canciones:";
            // 
            // lbl_img
            // 
            this.lbl_img.AutoSize = true;
            this.lbl_img.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_img.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_img.Location = new System.Drawing.Point(124, 214);
            this.lbl_img.Name = "lbl_img";
            this.lbl_img.Size = new System.Drawing.Size(125, 29);
            this.lbl_img.TabIndex = 49;
            this.lbl_img.Text = "Url Imagen:";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_titulo.Location = new System.Drawing.Point(176, 107);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(73, 29);
            this.lbl_titulo.TabIndex = 48;
            this.lbl_titulo.Text = "Titulo:";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menu.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.GripMargin = new System.Windows.Forms.Padding(2);
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_volver});
            this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(1505, 43);
            this.menu.TabIndex = 10;
            this.menu.Text = "menuStrip1";
            // 
            // menu_volver
            // 
            this.menu_volver.BackColor = System.Drawing.Color.White;
            this.menu_volver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menu_volver.Name = "menu_volver";
            this.menu_volver.Size = new System.Drawing.Size(203, 39);
            this.menu_volver.Text = "Menu Principal";
            this.menu_volver.Click += new System.EventHandler(this.menu_volver_Click);
            // 
            // error_icono
            // 
            this.error_icono.ContainerControl = this;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1505, 695);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.btn_img_local);
            this.Controls.Add(this.pbx_img);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.cbo_estilo);
            this.Controls.Add(this.cbo_edicion);
            this.Controls.Add(this.txt_img);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.lbl_estilo);
            this.Controls.Add(this.lbl_edicion);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lbl_img);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProducto";
            this.Text = "FrmProducto";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_img)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_icono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Button btn_img_local;
        private System.Windows.Forms.PictureBox pbx_img;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.ComboBox cbo_estilo;
        private System.Windows.Forms.ComboBox cbo_edicion;
        private System.Windows.Forms.TextBox txt_img;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.Label lbl_estilo;
        private System.Windows.Forms.Label lbl_edicion;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lbl_img;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menu_volver;
        private System.Windows.Forms.ErrorProvider error_icono;
    }
}