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
using MahApps.Metro.Controls;

namespace Lifting_App
{
    /// <summary>
    /// Interaction logic for OneRepMaxCalc.xaml
    /// </summary>
    public partial class OneRepMaxCalc : Window
    {
        public OneRepMaxCalc()
        {
            InitializeComponent();
        }

        private void CalcMax_Click(object sender, RoutedEventArgs e)
        {
            int weightcalc = int.Parse(Weight.Text);
            int repscalc = int.Parse(Reps.Text);

         /*   if(repscalc != )
            {

            } */

            double RepsMultiple = 0;

            if(repscalc > 10 || repscalc <= 0)
            {

                MessageBox.Show("Enter a rep range between 1 and 10.", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                switch (repscalc)
                {
                    case 1:
                        RepsMultiple = 1;
                        break;

                    case 2:
                        RepsMultiple = 1.05;
                        break;

                    case 3:
                        RepsMultiple = 1.08;
                        break;

                    case 4:
                        RepsMultiple = 1.11;
                        break;

                    case 5:
                        RepsMultiple = 1.15;
                        break;

                    case 6:
                        RepsMultiple = 1.18;
                        break;

                    case 7:
                        RepsMultiple = 1.20;
                        break;

                    case 8:
                        RepsMultiple = 1.25;
                        break;

                    case 9:
                        RepsMultiple = 1.30;
                        break;

                    case 10:
                        RepsMultiple = 1.33;

                        break;



                    default:
                        break;
                }

                double Estimate = weightcalc * RepsMultiple;



                string MaxEstimate = string.Format("Max Estimate {0} {1}", Environment.NewLine, Estimate);
                Max.Text = (MaxEstimate);

            }



            //string text = "Your 1 rep max estimate is: ";

          
        }

        private void Weight_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Reps_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Prevents any key other than numeric key to be pressed inside form.
            TextBox textBox = sender as TextBox;
            Int32 selectionStart = textBox.SelectionStart;
            Int32 selectionLength = textBox.SelectionLength;
            String newText = String.Empty;
            int count = 0;
            foreach (Char c in textBox.Text.ToCharArray())
            {
                if (Char.IsDigit(c) || Char.IsControl(c) || (c == '.' && count == 0))
                {
                    newText += c;
                    if (c == '.')
                        count += 1;
                }
            }
            textBox.Text = newText;
            textBox.SelectionStart = selectionStart <= textBox.Text.Length ? selectionStart : textBox.Text.Length;
        }
    }
}
