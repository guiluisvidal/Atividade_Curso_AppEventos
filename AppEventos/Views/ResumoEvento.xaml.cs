using AppEventos.Models;

namespace AppEventos.Views
{
    public partial class ResumoEventoPage : ContentPage
    {
        public ResumoEventoPage(Evento evento)
        {
            InitializeComponent();
            BindingContext = evento;
        }
    }
}
