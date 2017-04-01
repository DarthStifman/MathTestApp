using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            new string[] {"2x=16", "x=8"},
            new string[] {"5136 + 211", "5347"},
            new string[] {"32174 - 3945", "28229"},
            new string[] {"8645213 - 432148", "8213065"},
        };

        //Kontrola odpovedi, vyvolani dialogu.
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultWindow newResultWindow = new ResultWindow();

            
            string currentResult = Questions[questionNumber - 1][1];
            Regex.Replace(currentResult, @"\s+", "");
            newResultWindow.correctAnswer = currentResult;

            if (TbAnswer.Text != "")
            {
                if (currentResult == Regex.Replace(TbAnswer.Text, @"\s+", ""))
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
            //if (MessageBox.Show("Do you want to close the app?", "Exit", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            //{
            Close();
            //}
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Do you want to close the app?", "Exit", MessageBoxButton.YesNo) == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
            
        }

        //Prepnuti uvidni obrazovky. Start testu.
        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            StpWelcomeLabel.Visibility = Visibility.Collapsed;
            StpStartButton.Visibility = Visibility.Collapsed;
            StpQuestionLabel.Visibility = Visibility.Visible;
            StpBody.Visibility = Visibility.Visible;
        }

#region

        //string path = "";

        //OpenFileDialog ofd = new OpenFileDialog();

        //ofd.Filter = "CSV files (*.jpg)|*.jpg";
        //bool? result = ofd.ShowDialog();

        //if (result.HasValue && result.Value == true)
        //{
        //    path = ofd.FileName;
        //}

        //byte[] data = File.ReadAllBytes(path);

        //myImage.Source = LoadImage(data);

        //var image = new BitmapImage(new Uri(path));

        //images.Add(image);

        //MessageBox.Show("You can choose from " + (images.Count) + " images.");


        //private void btnShow_Click(object sender, RoutedEventArgs e)
        //{

        //    int imageNumber = Convert.ToInt32(tbChooseImage.Text);
        //    myImage.Source = images[imageNumber - 1];
        //}


        private static BitmapImage LoadImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }
#endregion

    }
}
