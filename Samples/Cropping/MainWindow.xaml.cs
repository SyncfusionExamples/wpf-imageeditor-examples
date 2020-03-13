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

        /// <summary>
        /// Invoked when image in <see cref="SfImageEditor"/> is loaded.
        /// </summary>
        /// <param name="sender">Image editor</param>
        /// <param name="e">event arguments</param>
        private void SfImageEditor_Loaded(object sender, ImageLoadedEventArgs e)
        {           
            comboBox.SelectionChanged += ComboBox_SelectionChanged;
            comboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Invoked when selection of the combo box gets changed.
        /// </summary>
        /// <param name="sender">Combo box</param>
        /// <param name="e">event arguments</param>
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
                // Custom
                editor.ToggleCropping(new Rect());
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

        /// <summary>
        /// Invoked when crop butoom is clicked.
        /// </summary>
        /// <param name="sender">Crop button</param>
        /// <param name="e">event arguments</param>
        private void Crop_Click(object sender, RoutedEventArgs e)
        {
            editor.Crop(new Rect());
        }

        /// <summary>
        /// Invoked when cancel button is clicked.
        /// </summary>
        /// <param name="sender">Cancel button</param>
        /// <param name="e">event arguments</param>
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            editor.ToggleCropping();
        }

        /// <summary>
        /// Invoked when save button is clicked.
        /// </summary>
        /// <param name="sender">Save button</param>
        /// <param name="e">event arguments</param>
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            editor.Save();
        }

        /// <summary>
        /// Invoked when reset button is clicked.
        /// </summary>
        /// <param name="sender">Reset button</param>
        /// <param name="e">event arguments.</param>
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            editor.Reset();
        }
    }
}
