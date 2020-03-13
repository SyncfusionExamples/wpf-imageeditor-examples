using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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
        /// Invoked before image getting saved.
        /// </summary>
        /// <param name="sender">Image editor</param>
        /// <param name="e">event arguments</param>
        private void Editor_ImageSaving(object sender, ImageSavingEventArgs e)
        {
            e.Cancel = true;
            e.Stream.Seek(0, 0);
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.StreamSource = e.Stream;
            bitmapImage.EndInit();
            image.Source = bitmapImage;
        }

        /// <summary>
        /// Invoked when toolbar item is clicked.
        /// </summary>
        /// <param name="sender">Toolbar item</param>
        /// <param name="e">event arguments</param>
        private void ToolbarSettings_ToolbarItemSelected(object sender, ToolbarItemSelectedEventArgs e)
        {
            /// Cancel the default functionality only for save icon.
            if (e.ToolbarItem.Name == "Save")
            {
                e.Cancel = true;
                editor.Save();
            }
        }
    }
}
