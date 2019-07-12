using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Samuel_OperacionesBasicas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Samuel_OperacionesBasicas.Model;

namespace Samuel_OperacionesBasicas.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TransaccionAritmeticaView : ContentPage
    {
        public UsuarioModel mynewUser { get; set; }
        public TransaccionAritmeticaView(UsuarioModel myUser)
        {
            InitializeComponent();
            mynewUser = myUser;
        }

        private void ButtonEjecutarOperacion_Clicked(object sender, EventArgs e)
        {
            TransaccionAritmeticaModel MiObjeto = new TransaccionAritmeticaModel();
            MiObjeto.PrimerNumero = Convert.ToDouble(EntryPrimerNumero.Text);
            MiObjeto.SegundoNumero = Convert.ToDouble(EntrySegundoNumero.Text);
            string OperacionElegida = EntryOperacionElegida.Text;
            bool AccionInvalida = false;
            if (OperacionElegida == "suma")
            {
                MiObjeto.Sumar();
            } else if (OperacionElegida == "resta")
            {
                MiObjeto.Restar();
            } else if (OperacionElegida == "multiplicar") {
                MiObjeto.Multiplicar();
            } else if (OperacionElegida == "dividir")
            {
                MiObjeto.Dividir();
            }
            else
            {
                AccionInvalida = true;
            }
            if (AccionInvalida == true)
            {
                LabelResultado.Text = "POR FAVOR elija una operacion valida, escriba en minusculas";
            }
            else
            {
                LabelResultado.Text = MiObjeto.Respuesta_Operacion;
            }
            //UsuarioModel UsuarioActual = new UsuarioModel();

            string PresentandoAlUsuario = "";
            PresentandoAlUsuario = "El usuario se llama:" + mynewUser.Nombre + "\n";
            PresentandoAlUsuario += "Y te buscare en :" + mynewUser.Correo + "\n";
            PresentandoAlUsuario += "Y encontrare en :" + mynewUser.Telefono + "\n";
            LabelResultado.Text += "\n"+ PresentandoAlUsuario;
        }
    }
}