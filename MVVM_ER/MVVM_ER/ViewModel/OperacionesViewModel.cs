using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVM_ER.ViewModel
{
    public class OperacionesViewModel : INotifyPropertyChanged
    {
        public int Numero1{ get; set; }
        public int Numero2 { get; set; }
        public Command OperarCommand { get; set; }
        public Command OperarAsyncCommand { get; set; }
        private int _Resultado;

        public int Resultado
        {
            get { return _Resultado; }
            set { _Resultado = value; OnPropertyChanged(); }
        }

        public OperacionesViewModel()
        {
            OperarCommand = new Command(SumarNumeros);
            OperarAsyncCommand = new Command(async ()=> await SumarNumeroAsync());

        }

        

        private async Task SumarNumeroAsync()
        {
            await Task.Run(() => { Resultado = Numero1 + Numero2; });
        }
        private void SumarNumeros()
        {
            Resultado = Numero1 + Numero2;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
