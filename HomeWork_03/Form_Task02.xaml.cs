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
    /// Логика взаимодействия для Form_Task02.xaml
    /// </summary>
    public partial class Form_Task02 : Window
    {
        double columnX = -1;
        double rowY = -1;

        int columnCount = -1;
        int rowsCount = -1;

        List<BitmapSource> bitmaps = null;

        public Form_Task02()
        {
            InitializeComponent();
            bitmaps = new List<BitmapSource>();
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

            columnCount = 0;
            rowsCount = 0;

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

            for (int i=0; i<columnCount; i++)
            {
                for(int j=0; j<rowsCount; j++)
                { 
                    Image image = new Image();
                    //image.Source = new BitmapImage();           // Очень долго загружает сетку         
                    image.Source = new BitmapImage(new Uri(@"E:\temp\Image01.bmp"));
                    image.Stretch = Stretch.Fill;

                    Grid.SetColumn((UIElement)image, i);
                    Grid.SetRow((UIElement)image, j);

                    userGrid.Children.Add(image);
                    Panel.SetZIndex(image, 3);
                }
            }

            userGrid.ShowGridLines = true;
        }

        private void userGrid_DragEnter(object sender, DragEventArgs e)
        {
            if((e.AllowedEffects & DragDropEffects.Copy) != 0)
            {
                e.Effects = DragDropEffects.Copy;                
            }
        }

        private void userGrid_Drop(object sender, DragEventArgs e)
        {
            double columnCell = 0;
            double rowCell = 0;

            // Получить координаты мыши в координатах, где начался userGrid_Drop;
            Point position = e.GetPosition(userGrid);
            columnX = position.X;
            l1.Content = columnX.ToString();
            rowY = position.Y;
            l2.Content = position.Y;

            // Вычислить ячейки колонки где начался userGrid_Drop;
            for (int i = 0; i < userGrid.ColumnDefinitions.Count; i++)
            {
                columnCell += userGrid.ColumnDefinitions[i].ActualWidth; 
                if (columnCell > columnX)
                {
                    columnCell = i;
                    break;
                }
            }

            // Вычислить ячейки строки где начался userGrid_Drop;
            for (int i = 0; i < userGrid.RowDefinitions.Count; i++)
            {
                rowCell += userGrid.RowDefinitions[i].ActualHeight;
                if (rowCell > rowY)
                {
                    rowCell = i;
                    break;
                }
            }

            // Получить список перемещаемых файлов
            string[] str = (string[])e.Data.GetData(DataFormats.FileDrop);
            string imageName = str[0];
            //string imageName = @"E:\temp\Image01.bmp";

            // Если выделено имя файла картинки - положить картинку в контейнер
            string ext = System.IO.Path.GetExtension(imageName);
            if (ext == ".bmp" || ext == ".jpg" || ext == ".gif" || ext == ".png")
            {
                BitmapSource Source = new BitmapImage(new Uri(imageName));

                bitmaps.Add(Source);

                Image image = new Image();
                image.Source = Source;
                image.Stretch = Stretch.Fill;

                Grid.SetColumn((UIElement)image, (int)columnCell);
                Grid.SetRow((UIElement)image, (int)rowCell);

                userGrid.Children.Add(image);
                Panel.SetZIndex(image, 5);
            }
            //MessageBox.Show($"Количество: {bitmaps.Count}");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Очистить список сетки
            if (columnCount >= 0 && rowsCount >= 0)
            {
                for (int i = 0; i < columnCount; i++)
                {
                    for (int j = 0; j < rowsCount; j++)
                    {
                        userGrid.Children.Clear();                       
                    }
                }
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            // Очистить список сетки
            if (columnCount >= 0 && rowsCount >= 0)
            {
                for (int i = 0; i < columnCount; i++)
                {
                    for (int j = 0; j < rowsCount; j++)
                    {
                        userGrid.Children.Clear();
                    }
                }
            }

            Random random = new Random();
            int countImages = 0;

            if (columnCount >= 0 && rowsCount >= 0)
            {
                for (int i = 0; i < columnCount; i++)
                {
                    for (int j = 0; j < rowsCount; j++)
                    {
                        if (countImages < bitmaps.Count)
                        {
                            Image image = new Image();
                            image.Source = bitmaps[countImages];
                            image.Stretch = Stretch.Fill;

                            Grid.SetColumn((UIElement)image, random.Next(0, columnCount));
                            Grid.SetRow((UIElement)image, random.Next(0, rowsCount));

                            if (!userGrid.Children.Contains(image))
                            {
                                userGrid.Children.Add(image);
                                Panel.SetZIndex(image, 5);
                                countImages++;
                            }

                            //countImages++;
                        }
                    }
                }
            }











        }
    }
}
