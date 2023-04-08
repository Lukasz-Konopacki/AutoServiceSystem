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

namespace AutoServiceSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> people { get; set; } = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();

            people.Add(new Person() { FirstName = "Tim", SecondName = "Cory" });
            people.Add(new Person() { FirstName = "Joe", SecondName = "Smith" });
            people.Add(new Person() { FirstName = "Sue", SecondName = "Storm" });

            myComboBox.ItemsSource = people;
        }

        private void runBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {firstNameField.Text}");
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public string FullName => FirstName + " " + SecondName; 
    }
}