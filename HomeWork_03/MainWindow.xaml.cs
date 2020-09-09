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

namespace HomeWork_03
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_task01_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;

            Form_Task01 form_Task01 = new Form_Task01();
            form_Task01.ShowDialog();

            this.Visibility = Visibility.Visible;
        }

        private void btn_task02_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;

            Form_Task02 form_Task02 = new Form_Task02();
            form_Task02.ShowDialog();

            this.Visibility = Visibility.Visible;
        }
    }
}
