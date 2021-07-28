using System;
using System.Collections;
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

namespace ArrayList_Peeradon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList varList;
        public MainWindow()
        {
            InitializeComponent();
            varList = new ArrayList();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void add_func(object sender, RoutedEventArgs e)
        {
            varList.Add(textinput.Text);
            MessageBox.Show(textinput.Text);
        }

        private void remove_func(object sender, RoutedEventArgs e)
        {
            varList.Remove(textinput.Text);
            MessageBox.Show(textinput.Text);
        }

        private void show(object sender, RoutedEventArgs e)
        {
            foreach(string i in varList)
            {
                MessageBox.Show(i);
            }
        }
    }
}
