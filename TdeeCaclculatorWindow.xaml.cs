using MahApps.Metro.Controls;
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
    /// Interaction logic for TdeeCaclculatorWindow.xaml
    /// </summary>
    public partial class TdeeCaclculatorWindow : MetroWindow
    {


        public TdeeCaclculatorWindow()
        {
            InitializeComponent();
        }

        private void ComboBoxActivity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CalcMax_Click(object sender, RoutedEventArgs e)
        {


            if (Male.IsChecked == false && Female.IsChecked == false || ComboBoxActivity.SelectedIndex == 5 || heighttxt.Text == "" || agetxt.Text == "" || weighttxt.Text == "" )
            {
                MessageBox.Show("Please select a gender and Enter a height, weight and age.", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {

                int ActivityLevel = ComboBoxActivity.SelectedIndex;
                double ActivityMultiple = 0;
                double Malecalc = 0;
                double Femalcalc = 0;



                switch (ActivityLevel)
                {
                    case 0:
                        ActivityMultiple = 1.2;
                        break;

                    case 1:
                        ActivityMultiple = 1.375;
                        break;

                    case 2:
                        ActivityMultiple = 1.55;
                        break;

                    case 3:
                        ActivityMultiple = 1.725;
                        break;

                    case 4:
                        ActivityMultiple = 1.9;
                        break;

                    default:
                        break;

                }

                double TDEE;
                double Heightcalc;
                double Weightcalc;
                double Agecalc;

                int Height = int.Parse(heighttxt.Text);
                int Age = int.Parse(agetxt.Text);
                int Weight = int.Parse(weighttxt.Text);

                Heightcalc = (Height * 6.25);
                Weightcalc = (Weight * 9.99);
                Agecalc = (Age * 4.92);

                double BMR = (Heightcalc + Weightcalc - Agecalc + 5);
                TDEE = (BMR * ActivityMultiple);
                // TDEEtxt.Text = TDEE.ToString();

                //Activity Level Factor x((13.75 x WEIGHT(kg)) +(5 x HEIGHT(cm)) – (6.76 x age) +66)



                //txtTest.Text = ActivityMultiple.ToString();

                if (Male.IsChecked == true)
                {
                    double MaleTdee = (ActivityMultiple * ((13.75 * Weight) + (5 * Height) - (6.76 * Age) + 66));
                    TDEEtxt.Text = MaleTdee.ToString();
                }
                else if (Female.IsChecked == true)
                {
                    double Female = ActivityMultiple * ((9.56 * Weight) + (1.85 * Height) - (4.68 * Age) + 655);
                    TDEEtxt.Text = Female.ToString();
                }

            }
        }

        private void Heighttxt_TextChanged(object sender, TextChangedEventArgs e)
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

        private void Agetxt_TextChanged(object sender, TextChangedEventArgs e)
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

        private void Weighttxt_TextChanged(object sender, TextChangedEventArgs e)
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
