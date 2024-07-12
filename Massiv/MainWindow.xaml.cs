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

namespace Massiv
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void itog_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(vvod1.Text);
            int y = int.Parse(vvod2.Text);
            Random random = new Random();
            int[,] array = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    array[i, j] = random.Next(1, 100); // заполняем случайными значениями от 1 до 100
                }
            }
            vivod.Content = " ";
            // Печать массива
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    vivod.Content += $"{array[i, j],10}";
                }
                vivod.Content += "\n";
            }
        }
    }
}
