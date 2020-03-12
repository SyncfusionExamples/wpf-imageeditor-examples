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

        private void SfImageEditor_Loaded(object sender, ImageLoadedEventArgs e)
        {           
            comboBox.SelectionChanged += ComboBox_SelectionChanged;
            comboBox.SelectedIndex = 0;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = sender as ComboBox;

            if (combo.SelectedIndex == 0)
            {
                // Square
                editor.ToggleCropping(1, 1);
            }
            else if (combo.SelectedIndex == 1)
            {
                // Original
                editor.ToggleCropping(float.NaN, float.NaN);
            }
            else if (combo.SelectedIndex == 2)
            {
                // 3:2
                editor.ToggleCropping(3, 2);
            }
            else if (combo.SelectedIndex == 3)
            {
                // 4:3
                editor.ToggleCropping(4, 3);
            }
            else if (combo.SelectedIndex == 4)
            {
                // 5:4
                editor.ToggleCropping(5, 4);
            }
            else if (combo.SelectedIndex == 5)
            {
                // 16:9
                editor.ToggleCropping(16, 9);
            }           
        }

        private void Crop_Click(object sender, RoutedEventArgs e)
        {
            editor.Crop(new Rect());
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            editor.ToggleCropping();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            editor.Save();
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            editor.Reset();
        }
    }
}
