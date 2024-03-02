using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Logica;

namespace TiendaDeDiscos
{
    public partial class FrmProducto : Form
    {
        private Metodos metodos = new Metodos();
        public FrmProducto()
        {
            InitializeComponent();
        }
        private void FrmProducto_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }

        private void CargarComboBox()
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();

            try
            {
                cbo_estilo.DataSource = elementoNegocio.ListarEstilo();
                cbo_estilo.ValueMember = "Id";
                cbo_estilo.DisplayMember = "Descripcion";

                cbo_edicion.DataSource = elementoNegocio.ListarTipoEdicion();
                cbo_edicion.ValueMember = "Id";
                cbo_edicion.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void menu_volver_Click(object sender, EventArgs e)
        {
            FrmTienda frmVolver = new FrmTienda();
            frmVolver.Show();
            this.Hide();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            CargarDisco();
        }
        
        private void CargarDisco()
        {
            Disco disco = new Disco();
            CN_Genero logicaNegocio = new CN_Genero();
            

            try
            {
                if(ValidarCamposVacios())
                {
                    disco.Titulo = txt_titulo.Text;
                    disco.FechaLanzamiento = dtp_fecha.Value;
                    disco.CantidadCanciones = int.Parse(txt_cantidad.Text);
                    disco.Precio = decimal.Parse(txt_precio.Text);
                    disco.UrlImagenTapa = txt_img.Text;
                    disco.Estilo = (Estilo)cbo_estilo.SelectedItem;
                    disco.TipoEdicion = (TipoEdicion)cbo_edicion.SelectedItem;


                    logicaNegocio.Agregar(disco);
                    MessageBox.Show("Agregado exitosamente");
                    FrmTienda frmVolver = new FrmTienda();
                    frmVolver.Show();
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            FrmTienda frmVolver = new FrmTienda();
            frmVolver.Show();
            this.Hide();
        }



        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_precio_TextChanged(object sender, EventArgs e)
        {
            Metodos metodos = new Metodos();
            metodos.FormatoMoneda(txt_precio);
        }

        private void txt_img_TextChanged(object sender, EventArgs e)
        {
            metodos.CargarImg(pbx_img,txt_img.Text);
        }

        private bool ValidarCamposVacios()
        {
            bool validar = true;
            
            if(txt_titulo.Text == string.Empty)
            {
                validar = false;
                error_icono.SetError(txt_titulo,"Debe completar el campo Titulo!!");    
            }
            else if (dtp_fecha.Value == DateTime.MinValue)
            {
                validar = false;
                error_icono.SetError(dtp_fecha, "Debe completar el campo Fecha!!");
            }
            else if (txt_img.Text == string.Empty)
            {
                validar = false;
                error_icono.SetError(txt_img, "Debe completar el campo Imagen!!");
            }
            else if (txt_cantidad.Text == string.Empty)
            {
                validar = false;
                error_icono.SetError(txt_cantidad, "Debe completar el campo Cantidad Canciones!!");
            }
            else if (txt_precio.Text == string.Empty)
            {
                validar = false;
                error_icono.SetError(txt_precio, "Debe completar el campo Precio!!");
            }
            return validar;
        }
    }
}
