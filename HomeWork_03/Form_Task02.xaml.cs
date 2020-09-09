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

namespace HomeWork_03
{
    /// <summary>
    /// Логика взаимодействия для Form_Task02.xaml
    /// </summary>
    public partial class Form_Task02 : Window
    {
        public Form_Task02()
        {
            InitializeComponent();
        }

        private void btn_Task02_buildNewGrid_Click(object sender, RoutedEventArgs e)
        {
            // очистка всех дочерних элементов
            userGrid.Children.Clear();

            // очистка столбцов и строк
            userGrid.ColumnDefinitions.Clear();
            userGrid.RowDefinitions.Clear();

            // Паказать сетку
            userGrid.ShowGridLines = true;
            
            ColumnDefinition colDef1 = new ColumnDefinition();

            int columnCount = 0;
            int rowsCount = 0;

            if(Convert.ToInt32(textBox_Task02_columnCount.Text) != 0)
            {
                columnCount = Convert.ToInt32(textBox_Task02_columnCount.Text);

                for(int i=0; i<columnCount; i++)
                {                    
                    ColumnDefinition column = new ColumnDefinition();
                    userGrid.ColumnDefinitions.Add(column);
                }
            }

            if (Convert.ToInt32(textBox_Task02_rowsCount.Text) != 0)
            {
                rowsCount = Convert.ToInt32(textBox_Task02_rowsCount.Text);

                for (int i = 0; i < rowsCount; i++)
                {
                    RowDefinition rows = new RowDefinition();
                    userGrid.RowDefinitions.Add(rows);
                }
            }

            userGrid.ShowGridLines = true;
        }
    }
}
