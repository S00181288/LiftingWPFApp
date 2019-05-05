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
using System.Windows.Shapes;

namespace Lifting_App
{
    /// <summary>
    /// Interaction logic for ExerciseGuide.xaml
    /// </summary>
    public partial class ExerciseGuide : Window
    {
        public ExerciseGuide()
        {
            InitializeComponent();

        }

        
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri ("C:\\Users\\conor\\Desktop\\Lifting App\\Images\\Weights.jpg", UriKind.Absolute);
            ImageSource imgSource = new BitmapImage(uri);
            MyImage.Source = imgSource;

            ExerciseGuideImage exerciseGuide = new ExerciseGuideImage(imgSource);

            exerciseGuide.Owner = this;
            exerciseGuide.ShowDialog();

        }
    }
}
