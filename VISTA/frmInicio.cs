using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ProyectoContabilidadDeCosto
{
    public partial class frmInicio : Form
    {
        int tri = 3;
        Thread th;
        string Usuario = "a", Clave = "a";
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtContrasena.Text;
            if (usuario == Usuario)
            {
                Error.SetError(txtUsuario, "");
                if (clave == Clave)
                {
                    Error.SetError(txtContrasena, "");
                    time.Enabled = true;
                }
                else
                {
                    Error.SetError(txtContrasena, "Contrase�a Incorrecta");
                    txtContrasena.Clear(); 
                    txtContrasena.Focus();
                    return;
                }
            }
            else
            {
                Error.SetError(txtUsuario, "Usuario Incorrecto");
                Limpiar();
                txtUsuario.Focus();
                return;
            }
            if (usuario !=Usuario && clave != Clave)
            {
                tri--;
                if (tri == 0)
                {
                    MessageBox.Show("Ha llegado al n�mero m�ximo de intentos");
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            tri = 3;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void AbrirNuevoFrom()
        {
            Application.Run(new frmPrincipalMenu());
        }
        public void Limpiar()
        {
            txtUsuario.Clear();
            txtContrasena.Clear();
        }

        private void time_Tick(object sender, EventArgs e)
        {
            if (pbrContinuar.Value < 100)
                pbrContinuar.Value += 5;
            if (pbrContinuar.Value == 100)
            {
                time.Enabled = false;
                th = new Thread(AbrirNuevoFrom);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();
            }
        }
        private void Mostrar_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Mostrar.Checked == true)
                txtContrasena.PasswordChar = '\0';
            else if (Mostrar.Checked == false)
                txtContrasena.PasswordChar = '�';
        }
    }
}