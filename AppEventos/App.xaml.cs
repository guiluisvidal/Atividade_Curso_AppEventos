using AppEventos.Views;
using AppEventos.Views;

namespace AppEventos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CadastroEventoPage());
        }
    }
}
