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

namespace EventsApp
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragDrop.DoDragDrop(textBox1, textBox1.Text, DragDropEffects.Copy);
        }

        private void Button1_Drop(object sender, DragEventArgs e)
        {
            button1.Content = e.Data.GetData(DataFormats.Text);
        }
    }
}
