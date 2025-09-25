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
    public partial class Form1 : Form
    {
        //atributos variables o constantes de esta clase

        //guardo en variable string la direccion de mis archivos de imagen globales
        string dir_img_alegre = Path.Combine(Application.StartupPath, "Image", "alegre.png");
        string dir_img_user = Path.Combine(Application.StartupPath, "Image", "user.png");
        string dir_img_dudoso = Path.Combine(Application.StartupPath, "Image", "dudoso.png");
        string dir_img_pensando = Path.Combine(Application.StartupPath, "Image", "pensando.png");


        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pbxEstado.Image = Image.FromFile(dir_img_user);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //al cargar el formulario cargar la imagen alegre que esta en el proyecto
            pbxEstado.Image = Image.FromFile(dir_img_user);
            
            //cargar un item
            cboEstadoAnimico.Items.Add("Seleccione Opciones");
            //le di el texto desde su indice tipo vector
            cboEstadoAnimico.Text   =cboEstadoAnimico.Items[4].ToString();


        }

        private void rdbFeliz_CheckedChanged(object sender, EventArgs e)
        {
            pbxEstado.Image= Image.FromFile(dir_img_alegre);
        }

        private void rdbPensativo_CheckedChanged(object sender, EventArgs e)
        {
            pbxEstado.Image=Image.FromFile(dir_img_pensando);
        }

        private void rdbTriste_CheckedChanged(object sender, EventArgs e)
        {
            pbxEstado.Image = Image.FromFile (dir_img_dudoso);
        }

        private void cboEstadoAnimico_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cuando cambie voy a guardarme el texto en una variable 
            string texto = cboEstadoAnimico.Text;

            //swich case es un if anidado yo lo vieron 

            switch (texto)
            {
                case "user":
                    pbxEstado.Image = Image.FromFile(dir_img_user);
                    break;
                case "feliz":
                    pbxEstado.Image = Image.FromFile(dir_img_alegre);
                    break;
                case "pensativo":
                    pbxEstado.Image = Image.FromFile(dir_img_pensando);
                    break;
                case "triste":
                    pbxEstado.Image = Image.FromFile(dir_img_dudoso);
                    break;
                default:
                    break;
            }


        }

        private void btn_Ir_juego_Click(object sender, EventArgs e)
        {
            frmJuego formulario = new frmJuego();
            formulario.ShowDialog();
        }
    }
}
