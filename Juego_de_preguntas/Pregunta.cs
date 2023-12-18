using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_de_preguntas
{

    internal class Pregunta : ObservableObject
    {
        private string textoPregunta;
        public string TextoPregunta
        {
            get => textoPregunta;
            set { SetProperty(ref textoPregunta, value); }
        }

        private string respuesta;
        public string Respuesta
        {
            get => respuesta;
            set { SetProperty(ref respuesta, value); }
        }

        private string imagen;
        public string Imagen
        {
            get => imagen;
            set { SetProperty(ref imagen, value); }
        }

        private string dificultad;
        public string Dificultad
        {
            get => dificultad;
            set { SetProperty(ref dificultad, value); }
        }

        private string categoria;
        public string Categoria
        {
            get => categoria;
            set { SetProperty(ref categoria, value); }
        }

        public Pregunta(string textoPregunta, string respuesta, string imagen, string dificultad, string categoria)
        {
            this.textoPregunta = textoPregunta;
            this.respuesta = respuesta;
            this.imagen = imagen;
            this.dificultad = dificultad;
            this.categoria = categoria;
        }

        public Pregunta() { }
    }
}
