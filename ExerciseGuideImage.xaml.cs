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
    /// Interaction logic for ExerciseGuideImage.xaml
    /// </summary>
    public partial class ExerciseGuideImage : Window
    {
        public ExerciseGuideImage(ImageSource mystring)
        {

            //ImageSourceConverter().ConvertFromString(mystring) as ImageSource

            ImageBack.Source = mystring;

            InitializeComponent();
            
            //testlabel.Content = mystring;
        }

    }
}
