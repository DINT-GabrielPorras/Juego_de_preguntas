using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

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

        public void AñadirPregunta(string textoPregunta, string respuesta, string imagen, string dificultad, string categoria)
        {
            pregunta = new Pregunta(textoPregunta, respuesta, imagen, dificultad, categoria);
            ListaPreguntas.Add(pregunta);
            MessageBox.Show("Se ha añadido la pregunta correctamente");
        } 
    }
}
