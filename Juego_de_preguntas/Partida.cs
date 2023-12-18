using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_de_preguntas
{
    internal class Partida : ObservableObject
    {
        private List<Pregunta> listaPreguntas;
        public List<Pregunta> ListaPreguntas
        {
            get { return listaPreguntas; }
            set { SetProperty(ref listaPreguntas, value); }
        }

        private string dificultad;
        public string Difucultad
        {
            get { return dificultad; } 
            set { SetProperty(ref dificultad, value); }
        }

        public Partida(List<Pregunta> listaPreguntas, string dificultad)
        {
            this.listaPreguntas = listaPreguntas;
            this.dificultad = dificultad;
        }
    }
}
