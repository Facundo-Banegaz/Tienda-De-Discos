using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaDeDiscos
{
    public partial class FrmLoader : Form
    {
        public FrmLoader()
        {
            InitializeComponent();
            pb_barra_progreso.Value = 0;
        }

        private void FrmLoader_Load_1(object sender, EventArgs e)
        {
            tm_tiempo.Start();
        }


        private void tm_tiempo_Tick_1(object sender, EventArgs e)
        {

            if (pb_barra_progreso.Value < 100)
            {
                pb_barra_progreso.Value += 1;

                pb_barra_progreso.Text = pb_barra_progreso.Value.ToString() + " %";
            }
            else
            {
                tm_tiempo.Stop();
                this.Hide();
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
            }
        }


    }
}
