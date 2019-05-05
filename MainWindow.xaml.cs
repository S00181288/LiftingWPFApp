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
using MahApps.Metro.Controls;

namespace Lifting_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    { 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TDEECalc(object sender, RoutedEventArgs e)
        {
            TdeeCaclculatorWindow Tdee = new TdeeCaclculatorWindow();
            Tdee.Owner = this;
            Tdee.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OneRepMaxCalc oneRepMax = new OneRepMaxCalc();
            oneRepMax.Owner = this;
            oneRepMax.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LiftingPlans LiftingPlans = new LiftingPlans();
            LiftingPlans.Owner = this;
            LiftingPlans.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ExerciseGuide exerciseGuide = new ExerciseGuide();
            exerciseGuide.Owner = this;
            exerciseGuide.ShowDialog();
        }
    }
}
