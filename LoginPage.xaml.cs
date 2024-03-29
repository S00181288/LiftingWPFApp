﻿using System;
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
using System.Data.Entity;
using System.Data.Sql;

namespace Lifting_App
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        //LiftingDataBaseEntities db = new LiftingDataBaseEntities();
        LiftingDataBaseEntities1 db = new LiftingDataBaseEntities1();
        
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            string Pass = PasswordEntry.Password.ToString();
            string login = UserLogin.Text.ToString();

            try
            {
                var queryFinal = (from p in db.Passwords
                                  where p.UserName.Equals(login)
                                  select p.Password1.Trim()).First();

                if (queryFinal == Pass)
                {

                    MainWindow mainwindow = new MainWindow();
                    mainwindow.Owner = this;
                    mainwindow.ShowDialog();
                    //MessageBox.Show("Correct");

                }
                else
                {
                    MessageBox.Show("Incorrect password, Please Enter a valid combination.");
                }
                
            }
            catch
            {
                MessageBox.Show("Incorrect Username and password, Please Enter a valid combination.");
            }
        

            /*    var query = from a in db.Passwords
                            where a.Password1.Contains(login)
                            select a;


            var query2 = from b in db.Passwords
                         where b.UserName.ToString() == login
                         select b;

            var query3 = from d in db.Passwords
                         select d;
                         */

            //var query3 = from a in db.Passwords
              //           select a.UserName;

            //showdata.ItemsSource = query.ToList();


            //showdata.ItemsSource = query3.ToList();

            //query2.ToString() == UserLogin.ToString() &&

            //if (query.ToString() == nut || query2.ToString() == login)
              
             /* if(query.ToString() == Pass)
              {
                  MainWindow mainwindow = new MainWindow();
                  mainwindow.Owner = this;
                  mainwindow.ShowDialog();

              }
              else
              {
                  MessageBox.Show("Enter a valid UserName and Password.", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
              } */
              

           /* try
            {
                var user = from a in db.Passwords
                           where a.Password1 == Password.Text && a.UserName == UserLogin.Text
                           select a;

               // var singleString = string.Join(",", user.ToArray());
                if (user != null)
                {
                   //var singleString = string.Join(",", user.ToArray());
                    MainWindow mainwindow = new MainWindow();
                    mainwindow.Owner = this;
                    mainwindow.ShowDialog();

                    foreach (var i in user)
                    {
                        showdata.Items.Add(i.ToString());
                    }

                    //showdata.ItemsSource = user.ToList();
                }
            }
            catch
            {
                MessageBox.Show("Login Failed");
            }

                //Login.Text = query.ToString();

            
               //attempting another medthod.
               */

           
        }

        //Login Button adding login details
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Password details = new Password()
            {
                Id = 227,
                Password1 = PasswordEntry.Password ,
                UserName = UserLogin.Text.ToString()
            };

            // Add the new object to the Orders collection.
            db.Passwords.Add(details);

            db.SaveChanges();

        }
    }
}
