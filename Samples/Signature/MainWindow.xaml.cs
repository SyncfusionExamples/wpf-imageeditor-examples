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
using Syncfusion.UI.Xaml.ImageEditor;
using Syncfusion.UI.Xaml.ImageEditor.Enums;

namespace ImageEditorSample
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

        private void SfImageEditor_Loaded(object sender, RoutedEventArgs e)
        {
            editor.AddShape(ShapeType.Path, new PenSettings());
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            editor.Reset();
            editor.AddShape(ShapeType.Path, new PenSettings());
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            editor.Save();
        }
    }
}
