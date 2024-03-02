using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TiendaDeDiscos
{
    public partial class FrmTienda : Form
    {

        public FrmTienda()
        {
            InitializeComponent();
        }



        private void tm_tiempo_Tick_1(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss tt", CultureInfo.InvariantCulture);
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void MenuItemGeneroMusical_Click(object sender, EventArgs e)
        {
            FrmGenero genero = new FrmGenero();
            genero.ShowDialog();
        }
    }
}
