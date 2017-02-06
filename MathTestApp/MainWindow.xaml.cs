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

namespace MathTestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            questionNumber = 1;

            InitializeComponent();
        }

        public int questionNumber;

        public List<string[]> Questions = new List<string[]>
        {
            new string[] {"14 x 10", "140"},
            new string[] {"5 x 10", "50"},
            new string[] {"6 x 6", "36"},
            new string[] {"250 : 5", "50"},
            new string[] {"1024 : 4", "256"},
        };

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ++questionNumber;
        }
    }
}
