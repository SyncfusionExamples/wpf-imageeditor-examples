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
        /// Invoked when the image in the <see cref="SfImageEditor"/> is loaded.
        /// </summary>
        /// <param name="sender">Image editor</param>
        /// <param name="e">event arguments</param>
        private void SfImageEditor_Loaded(object sender, ImageLoadedEventArgs e)
        {
            editor.AddShape(ShapeType.Circle, new PenSettings()
            {
                Bounds = new Rect(10, 15, 20, 20),
                Stroke = new SolidColorBrush(Colors.BlueViolet)
            });

            editor.AddText("Good Morning", new TextSettings()
            {
                FontFamily = new FontFamily("Consolas"),
                TextEffects = TextEffects.Italic,
                Bounds = new Rect(45, 30, 25, 25),
            });
        }
    }
}
