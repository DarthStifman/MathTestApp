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

            InitializeComponent();

            LbQuestionNumber.Content = "Question #1";
            LbQuestion.Content = questionText + Questions[0][0];
        }

        public int questionNumber = 1;

        public string questionText = "Solve the mathematical example: ";

        public List<string[]> Questions = new List<string[]>
        {
            new string[] {"14 x 10", "140"},
            new string[] {"89465 + 1123", "90588"},
            new string[] {"6 x 6", "36"},
            new string[] {"250 : 5", "50"},
            new string[] {"1024 : 4", "256"},
            new string[] {"14 x 2", "28"},
            new string[] {"112 : 2", "66"},
            new string[] {"5136 + 211", "5347"},
            new string[] {"32174 - 3945", "28229"},
            new string[] {"8645213 - 432148", "8213065"},
        };

        //Kontrola odpovedi, vyvolani dialogu.
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultWindow newResultWindow = new ResultWindow();

            
            string currentResult = Questions[questionNumber - 1][1];
            newResultWindow.correctAnswer = currentResult;

            if (TbAnswer.Text != "")
            {
                if (Convert.ToInt32(currentResult) == Convert.ToInt32(TbAnswer.Text))
                {
                    newResultWindow.userAnswer = "Correct!";
                }
                else
                {
                    newResultWindow.userAnswer = "Wrong...";
                }

                newResultWindow.ChangeLabels();
                newResultWindow.ShowDialog();

                if (questionNumber != 10)
                {
                    string currentExample = Questions[questionNumber][0];
                    ++questionNumber;
                    LbQuestionNumber.Content = "Question #" + questionNumber;
                    LbQuestion.Content = questionText + currentExample;
                    TbAnswer.Clear();
                }
                else
                {
                    MessageBox.Show("Math training is over...See you next time ;-)");
                    Close();
                }

            }
            else
            {
                MessageBox.Show("Your answer can´t be blank!");
            }            
                                    
        }
        
        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to close the app?", "Exit", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Close();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Do you want to close the app?", "Exit", MessageBoxButton.YesNo) == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
            
        }
    }
}
