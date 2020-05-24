using ExtendedWindow.Effects;
using System.Windows;
using System.Windows.Media;

namespace demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            _ = new WindowAccentCompositor(this)
            {
                Color = Color.FromArgb(0x3F, 0xFF, 0xFF, 0xFF),
                IsEnabled = true
            };
        }

        private void ShowExWindow_Click(object sender, RoutedEventArgs e)
        {
            ExWindow window = new ExWindow();
            window.Show();
        }
    }
}
