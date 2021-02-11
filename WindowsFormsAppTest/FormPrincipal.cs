using System;
using System.Windows.Forms;
using WindowsFormsAppTest.Procedimientos;
using WindowsFormsAppTest.Clases;

namespace WindowsFormsAppTest
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            CambiarUsuario();
        }

        private void BtnCambiar_MouseHover(object sender, EventArgs e)
        {

        }

        private void CambiarUsuario()
        {
            Usuario user = new Usuario();
            LblUsuario.Text = TxtUsuario.Text;
            user.Nombre = TxtUsuario.Text;
            LblUsuario.Text = TxtUsuario.Text;

        }

        private void BtnCrearUsuario_Click(object sender, EventArgs e)
        {
            CrearUsuario();
        }

        public void CrearUsuario() {



            Usuario user = new Usuario
            {
                Nombre = TxtUsuario.Text,
                Email = TxtEmail.Text,
                Password = TxtPassword.Text
            };

            SPHelper.InsertarUsuario(user);

            



        }



    }
}
