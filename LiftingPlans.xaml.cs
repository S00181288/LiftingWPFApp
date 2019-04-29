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
    /// Interaction logic for LiftingPlans.xaml
    /// </summary>
    public partial class LiftingPlans : MetroWindow
    {

        public List<string> TexasMethodPlan = new List<string>();
        public enum PlanList { SelectPlan, TexasMethod, Hobby, Exercise, Work, Family }
;

        public LiftingPlans()
        {
            InitializeComponent();

           

        }

        private void ShowPlans_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //var query = from a in db.TexasMethods
            //select a;

            //ShowPlans.ItemsSource = query.ToList();

            PlanComboBox.ItemsSource = Enum.GetValues(typeof(PlanList)).Cast<PlanList>();
            PlanComboBox.SelectedItem = PlanList.SelectPlan;

            //List<string> TexasMethodPlan = new List<string>();

            TexasMethodPlan.Add("TexasMethod.");
            TexasMethodPlan.Add("Monday: Volume Day");
            TexasMethodPlan.Add("Squats 5x5 @90% of 5RM");
            TexasMethodPlan.Add("Bench 5x5 90% 5RM");
            TexasMethodPlan.Add("Deadlift 1x5 @90% 5RM");

            TexasMethodPlan.Add("Wedensday: Recovery Day.");
            TexasMethodPlan.Add("Squat 2x5 Mondays working weight");
            TexasMethodPlan.Add("Overhead Press (If you bench pressed Monday3 x 5 or Bench Press(if OHP on Monday) 3 x 5 @ 90 % previous 5 x 5 weight )");
            TexasMethodPlan.Add("Chin-up 3 x Bodyweight");
            TexasMethodPlan.Add("Back Extension or Glute-Ham Raise 5 x 10");

            TexasMethodPlan.Add("Friday: Intensity Day.");
            TexasMethodPlan.Add("Squat: warm-up, then work up to one single, new 5RM");
            TexasMethodPlan.Add("Bench Press, (if you bench pressed Monday) or Overhead Press(if OHP on Monday): work up to one single, new 5RM");
            TexasMethodPlan.Add("Power Clean or Power Snatch: 5 x 3 / 6 x 2");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*LabelTest.Text = Query.ToString();

            var query = from a in db.TexasMethods
                        select a;

            var query1 = from a in db.st

            ShowPlans.ItemsSource = query.ToList();*/


            //ShowPlans.ItemsSource = TexasMethodPlan.ToList();
        }

        private void PlanComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string ChoosePlan = PlanComboBox.SelectedValue.ToString() as string;

            switch (ChoosePlan)
            {
                case "TexasMethod":
                    ShowPlans.ItemsSource = TexasMethodPlan;
                    ShowPlans.Items.Refresh();
                    break;
               /* case "Select Plan":
                    ShowPlans.ItemsSource = 
                    break;
                case "Hobby":
                     DisplayTasksLstBox.ItemsSource = TaskList.Where(a => a.Category == "Hobby");
                     break;
                case "Exercise":
                      DisplayTasksLstBox.ItemsSource = TaskList.Where(a => a.Category == "Exercise");
                      break;
                case "Work":
                      DisplayTasksLstBox.ItemsSource = TaskList.Where(a => a.Category == "Work");
                      break;
                case "Family":
                      DisplayTasksLstBox.ItemsSource = TaskList.Where(a => a.Category == "Family");
                      break; 
                      */




            }


        }
    }
}
