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
        public PersonaModel Persona { get; set; }
        public Command NavegarCommand { get; set; }
        public InicioViewModel()
        {
            Persona = new PersonaModel();
            Persona.Nombre = "Edwin Noel Ramos Bonilla";
            Persona.Curso = "Desarrollo de Mobile Apps con Xamarin";
            Persona.Cohorte = 6;
            NavegarCommand = new Command(IrAPagina);
        }
        private void IrAPagina()
        {
            App.Current.MainPage.Navigation.PushAsync(new OperacionesView());
        }
    }
}
