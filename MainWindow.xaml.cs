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

namespace Qand_a
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Win win = new Win();
            win.Show();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox Checkbox = (CheckBox)sender;
            int oldvaue = Convert.ToInt32(lbl1 .Content);

            if (Checkbox.Tag.ToString() == "1")
            {
                oldvaue = oldvaue + 10;
            }
            else
            {
                oldvaue = oldvaue + 10;
            }
            lbl1.Content = oldvaue.ToString();
            Checkbox.IsEnabled = false;

        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            CheckBox Checkbox = (CheckBox)sender;
            int oldvaue = Convert.ToInt32(Lbl2 .Content);

            if (Checkbox.Tag.ToString() == "1")
            {
                oldvaue = oldvaue + 10;
            }
            else
            {
                oldvaue = oldvaue + 10;
            }
            Lbl2 .Content = oldvaue.ToString();
            Checkbox.IsEnabled = false;

        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            CheckBox Checkbox = (CheckBox)sender;
            int oldvaue = Convert.ToInt32(lbl3 .Content);

            if (Checkbox.Tag.ToString() == "1")
            {
                oldvaue = oldvaue + 10;
            }
            else
            {
                oldvaue = oldvaue +  10;
            }
            lbl3 .Content = oldvaue.ToString();
            Checkbox.IsEnabled = false;

        }

        private void CheckBox_Checked_3(object sender, RoutedEventArgs e)
        {
            CheckBox Checkbox = (CheckBox)sender;
            int oldvaue = Convert.ToInt32(lbl4 .Content);

            if (Checkbox.Tag.ToString() == "1")
            {
                oldvaue = oldvaue + 10;
            }
            else
            {
                oldvaue = oldvaue + 10;
            }
            lbl4 .Content = oldvaue.ToString();
            Checkbox.IsEnabled = false;

        }

        private void CheckBox_Checked_4(object sender, RoutedEventArgs e)
        {
            CheckBox Checkbox = (CheckBox)sender;
            int oldvaue = Convert.ToInt32(lbl5 .Content);

            if (Checkbox.Tag.ToString() == "1")
            {
                oldvaue = oldvaue + 10;
            }
            else
            {
                oldvaue = oldvaue - 10;
            }
            lbl5 .Content = oldvaue.ToString();
            Checkbox.IsEnabled = false;

        }
    }
}
