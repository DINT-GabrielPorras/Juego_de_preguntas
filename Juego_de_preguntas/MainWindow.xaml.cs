using System;
using System.Collections.Generic;
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
        private MainWindowVM vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = new MainWindowVM();
            this.DataContext = vm;
        }

        private void Pregunta_TextChanged(object sender, TextChangedEventArgs e)
        {
            vm.AñadirTextoPregunta();
        }

        private void Respuesta_TextChanged(object sender, TextChangedEventArgs e)
        {
            vm.AñadirTextoRespuesta();
        }

        private void Imagen_TextChanged(object sender, TextChangedEventArgs e)
        {
            vm.AñadirImagen();
        }

        private void Dificultad_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vm.AñadirDificultad();
        }

        private void Categoria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vm.AñadirCategoria();
        }

        private void AñadirPregunta_Click(object sender, RoutedEventArgs e)
        {
            vm.AñadirPregunta();
        }

        private void Examinar_Click(object sender, RoutedEventArgs e)
        {
            vm.Examinar();
        }

        private void LimpiarFormulario_Click(object sender, RoutedEventArgs e)
        {
            vm.LimpiarFormulario();
        }
    }
}
