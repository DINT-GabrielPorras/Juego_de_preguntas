using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_de_preguntas
{

    internal class Pregunta : INotifyPropertyChanged
    {
        private string textoPregunta;
        public string TextoPregunta
        {
            get => textoPregunta;
            set
            {
                textoPregunta = value;
                NotifyPropertyChanged("Pregunta");
            }
        }

        private string respuesta;
        public string Respuesta
        {
            get => respuesta;
            set
            {
                respuesta = value;
                NotifyPropertyChanged("Respuesta");
            }
        }

        private string imagen;
        public string Imagen
        {
            get => imagen;
            set
            {
                imagen = value;
                NotifyPropertyChanged("Imagen");
            }
        }

        private string dificultad;
        public string Dificultad
        {
            get => dificultad;
            set
            {
                dificultad = value;
                NotifyPropertyChanged("Dificultad");
            }
        }

        private string categoria;
        public string Categoria
        {
            get => categoria;
            set
            {
                categoria = value;
                NotifyPropertyChanged("Categoria");
            }
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

        private void NotifyPropertyChanged(string v)
        {
            throw new NotImplementedException();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
