using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Samuel_OperacionesBasicas.Model;

namespace Samuel_OperacionesBasicas.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsuarioView : ContentPage
    {
        public UsuarioView()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            UsuarioModel um = new UsuarioModel();
            um.Nombre = ENombre.Text;
            um.Contrasena = EContrasena.Text;
            um.Telefono = Telefono.Text;
            um.Correo = ECorreo.Text;
            Navigation.PushAsync(new TransaccionAritmeticaView(um));

        }
    }
}