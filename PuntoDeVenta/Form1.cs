using System.Windows.Forms;
using Operaciones;
namespace ABARROTES
{
    public partial class Form1 : Form
    {
        OperacionesBD Conexion = new OperacionesBD();
        public Form1()
        {
            InitializeComponent();
       
        }

        private void BtnIniciarSesion_Click(object sender, System.EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            string Database = "AbarrotesBD";
            string servidor = "msi";
            if (Conexion.AbrirConexion(servidor,"SQL",usuario, contraseña, Database))
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

        private void txtUsuario_Enter(object sender, System.EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, System.EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }

        private void txtContraseña_Enter(object sender, System.EventArgs e)
        {
           if(txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                
            }
            txtContraseña.PasswordChar = '*';
        }

        private void txtContraseña_Leave(object sender, System.EventArgs e)
        {
            if(txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.PasswordChar = '\0';
            }
        }

        private void txtContraseña_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            txtUsuario.TabStop = false;
            txtContraseña.TabStop = false;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
