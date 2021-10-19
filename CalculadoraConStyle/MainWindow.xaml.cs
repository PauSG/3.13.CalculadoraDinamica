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

namespace CalculadoraConStyle
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int fila = 1; fila < 4; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    int n = (fila - 1) * 3 + columna + 1;

                    Button boton = new Button();
                    Grid.SetRow(boton, fila);
                    Grid.SetColumn(boton, columna);
                    boton.Margin = new Thickness(5);
                    boton.Click += Button_Click;
                    boton.Tag = n;

                    TextBlock texto = new TextBlock();
                    texto.Text = n.ToString();
                    Viewbox box = new Viewbox();
                    box.Child = texto;
                    boton.Content = box;
                    boton.Style = (Style)this.Resources["StyleBoton"];

                    MainGrid.Children.Add(boton);
                }
            }

            Button boton0 = new Button();
            Grid.SetRow(boton0, 4);
            Grid.SetColumnSpan(boton0, 3);
            boton0.Margin = new Thickness(5);
            boton0.Click += Button_Click;
            boton0.Tag = 0;

            TextBlock texto0 = new TextBlock();
            texto0.Text = 0.ToString();
            Viewbox box0 = new Viewbox();
            box0.Child = texto0;
            boton0.Content = box0;
            boton0.Style = (Style)this.Resources["StyleBoton"];

            MainGrid.Children.Add(boton0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NumerosTextBlock.Text += ((Button)sender).Tag.ToString();
        }
    }
}







