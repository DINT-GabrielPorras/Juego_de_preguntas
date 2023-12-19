using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Juego_de_preguntas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string textoPregunta;
        private string textRespuesta;
        private string rutaImagen;
        private string dificultad;
        private string categoria;

        private MainWindowVM vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = new MainWindowVM();
            this.DataContext = vm;
        }

        private void AñadirPregunta_Click(object sender, RoutedEventArgs e)
        {
            textoPregunta = preguntaTextBox.Text;
            textRespuesta = respuestaTextBox.Text;
            rutaImagen = imagenTextBox.Text;
            dificultad = dificultadComboBox.Text;
            categoria = categoriaComboBox.Text;

            vm.AñadirPregunta(textoPregunta, textRespuesta, rutaImagen, dificultad, categoria);
        }

        private void LimpiarFormulario_Click(object sender, RoutedEventArgs e)
        {
            preguntaTextBox.Text = "";
            respuestaTextBox.Text = "";
            imagenTextBox.Text = "";
            dificultadComboBox.Text = "Fácil";
            categoriaComboBox.Text = "Ciencia";

            imagenTextBox.IsEnabled = false;
            imagenPregunta.Source = null;
        }

        private void AbrirExplorador_Click(object sender, RoutedEventArgs e)
        {
            imagenTextBox.IsEnabled = true;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                imagenTextBox.Text = openFileDialog.FileName; 
        }
    }
}
