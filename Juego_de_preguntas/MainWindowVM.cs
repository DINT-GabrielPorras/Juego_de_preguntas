using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_de_preguntas
{
    class MainWindowVM : ObservableObject
    {
        private ObservableCollection<Pregunta> listaPreguntas;
        public ObservableCollection<Pregunta> ListaPreguntas
        {
            get => listaPreguntas;
            set { SetProperty(ref listaPreguntas, value); }
        }

        private Pregunta pregunta;
        public Pregunta Pregunta
        {
            get => pregunta;
            set { SetProperty(ref pregunta, value); }
        }

        public MainWindowVM()
        {
            ListaPreguntas = new ObservableCollection<Pregunta>();
            Pregunta = null;
        }

        public void AñadirTextoPregunta()
        {

        }

        public void AñadirTextoRespuesta()
        {

        }

        public void AñadirImagen()
        {

        }

        public void Examinar()
        {

        }

        public void AñadirDificultad()
        {

        }

        public void AñadirCategoria()
        {

        }

        public void AñadirPregunta()
        {

        }

        public void LimpiarFormulario()
        {

        }
    }
}
