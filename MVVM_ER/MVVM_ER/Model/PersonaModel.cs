using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_ER.Model
{
    public class PersonaModel : ModelBase
    {
        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; OnPropertyChanged(); }
        }
        private string _Curso;

        public string Curso
        {
            get { return _Curso; }
            set { _Curso = value; OnPropertyChanged(); }
        }
        private int _Cohorte;

        public int Cohorte
        {
            get { return _Cohorte; }
            set { _Cohorte = value; OnPropertyChanged(); }
        }



    }
}
