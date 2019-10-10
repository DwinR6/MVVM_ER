using MVVM_ER.Model;
using MVVM_ER.View;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MVVM_ER.ViewModel
{
    public class InicioViewModel
    {
        public PersonaModel persona { get; set; }
        public Command NavegarCommand { get; set; }
        public InicioViewModel()
        {
            persona.Nombre = "Edwin Noel Ramos Bonilla";
            persona.Curso = "Desarrollo de Mobile Apps con Xamarin";
            persona.Cohorte = 6;
            NavegarCommand = new Command(IrAPagina);
        }
        private void IrAPagina()
        {
            App.Current.MainPage.Navigation.PushAsync(new OperacionesView());
        }
    }
}
