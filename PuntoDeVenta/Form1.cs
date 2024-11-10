using PuntoDeVenta;
using System;
using System.Windows.Forms;

namespace ABARROTES
{
    public partial class Form1 : Form
    {
       
        private OperacionesBD Conexion = new OperacionesBD();

        public Form1()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }
      
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                BtnIniciarSesion_Click(this, new EventArgs());

                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
     
       
        public static class UsuarioActual
        {
            public static string Usuario { get; set; }
        }
        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            UsuarioActual.Usuario = txtUsuario.Text;
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            string Database = "AbarrotesBD";
            string servidor = "msi";

            if (Conexion.AbrirConexion(servidor, "SQL", usuario, contraseña, Database))
            {
               
                FormPrincipal formPrincipal = new FormPrincipal(Conexion);
                formPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
            }
            txtContraseña.PasswordChar = '*';
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.PasswordChar = '\0';
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
