using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace masControles
{
    public partial class frmJuego : Form
    {

        //ver videeo controles 1------
        //atributos variables o constantes de esta clase

        //guardo en variable string la direccion de mis archivos de imagen globales
        string dir_img_alegre = Path.Combine(Application.StartupPath, "Image", "alegre.png");
        string dir_img_user = Path.Combine(Application.StartupPath, "Image", "user.png");
        string dir_img_abajo = Path.Combine(Application.StartupPath, "Image", "dedo_abajo.png");
        string dir_img_arriba = Path.Combine(Application.StartupPath, "Image", "dedo_arriba.png");
        string dir_img_pensando = Path.Combine(Application.StartupPath, "Image", "pensando.png");



        public frmJuego()
        {
            InitializeComponent();
        }

        private void frmJuego_Load(object sender, EventArgs e)
        {
            //llamar la funcio en el load
            Aleatorio();
            pbxEstado.Image = Image.FromFile(dir_img_pensando);
        }

        //crear una funcion como en sus tps ----------------
        private void Aleatorio() {

            //creo un nro aleatorio
            Random rnd = new Random();
           
            int nro_secreto = rnd.Next(1, 12);

            txtNroInicial.Text = nro_secreto.ToString();

        }

        private void btn_intentar_Click(object sender, EventArgs e)
        {
            //lo da la funcion aleatorio
            int secreto = int.Parse(txtNroInicial.Text);
            //lo ponemos nosotros
            int intento = int.Parse(txt_intento.Text);

            if (secreto == intento ) {
                lblRespuesta.Text = "GANO..... el  nro secreto era:  " + secreto;
                pbxEstado.Image = Image.FromFile(dir_img_alegre);
            }
            else
            {
                if (intento > secreto)
                {
                    lblRespuesta.Text = "su nro es mas <<[Grande]>> al secreto... intente de nuevo";
                    txt_intento.Text = "";
                    txt_intento.Focus();
                    pbxEstado.Image = Image.FromFile(dir_img_arriba);
                }
                else
                {
                    if (intento < secreto)
                    {
                        lblRespuesta.Text = "su nro es mas <<[Pequeño]>> al secreto... intente de nuevo";
                        txt_intento.Text = "";
                        txt_intento.Focus();
                        pbxEstado.Image = Image.FromFile(dir_img_abajo);

                    }
                    
                }
                
            }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Aleatorio();
            lblRespuesta.Text = "RESPUESTA";
            txt_intento.Text = "";
            txt_intento.Focus();
            pbxEstado.Image = Image.FromFile(dir_img_pensando);
        }

        private void lblRespuesta_Click(object sender, EventArgs e)
        {

        }
    }
}
