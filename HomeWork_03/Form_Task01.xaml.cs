using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HomeWork_03
{
    /// <summary>
    /// Логика взаимодействия для Form_Task01.xaml
    /// </summary>
    public partial class Form_Task01 : Window
    {
        public Form_Task01()
        {
            InitializeComponent();           
            
        }

        private void listBox_Task01_filesDragNDrop_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop) &&
                (e.AllowedEffects & DragDropEffects.Copy) != 0 &&
                !e.Data.GetDataPresent("MyDropFile"))
            {
                e.Effects = DragDropEffects.Copy;
                Lable_Task01_lable.Content = "";
            }
        }

        private void listBox_Task01_filesDragNDrop_Drop(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop) &&
                (e.AllowedEffects & DragDropEffects.Copy) != 0 &&
                !e.Data.GetDataPresent("MyDropFile"))
            {
                string[] filesDrop = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach(var file in filesDrop)
                {
                    listBox_Task01_filesDragNDrop.Items.Add(file);
                }
            }
        }

        private void listBox_Task01_filesDragNDrop_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            // Получить коорднаты мыши
            System.Windows.Point positionMouse = e.GetPosition(this);

            // Выяснить над каким контролом находится мышь
            HitTestResult hitTestResult = System.Windows.Media.VisualTreeHelper.HitTest(this, positionMouse);

            // получить TextBlock, соответствующий пункту, над которым находится курсор мыши
            TextBlock tb = (TextBlock)hitTestResult.VisualHit;

            // получить надпись из пункта listBox
            string imageName = (string)(tb).DataContext;

            // выяснить номер пункта listBox, над которым находится курсор мыши
            int itemIndex = listBox_Task01_filesDragNDrop.Items.IndexOf(imageName);
            if (itemIndex >= 0)
            {
                // программно выделить найденным пункт
                listBox_Task01_filesDragNDrop.SelectedIndex = itemIndex;
            }

            // Создать контейнер для хранения данных
            DataObject dataObj = new DataObject();

            // Положить содержимое выделенной в списке строки
            StringCollection strCollection = new StringCollection();
            strCollection.Add(imageName);
            dataObj.SetFileDropList(strCollection);

            // Если выделено имя файла картинки - положить картинку в контейнер
            string ext = System.IO.Path.GetExtension(imageName);
            if (ext == ".bmp" || ext == ".jpg" || ext == ".gif" || ext == ".png")
            {
                BitmapSource bitmatSource = new BitmapImage(new Uri(imageName));
                dataObj.SetImage(bitmatSource);
            }

            // Добавить признак пользовательского формата в контейнер
            dataObj.SetData("MyDropFile", 0);

            // НАЧАТЬ перетаскивание программно
            DragDropEffects dde = DragDrop.DoDragDrop(this, dataObj, DragDropEffects.Copy);

        }

        private void Image_Task01_image_DragEnter(object sender, DragEventArgs e)
        {
            if((e.AllowedEffects & DragDropEffects.Copy) != 0)
            {
                e.Effects = DragDropEffects.Copy;
            }
        }

        private void Image_Task01_image_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                BitmapSource bitmapSource = (BitmapSource)e.Data.GetData(DataFormats.Bitmap);
                Image_Task01_image.Source = bitmapSource;
            }
        }

    }
}
