using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace PotatoMenuApp
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
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainContentGrid.Children.Clear();
            TextBlock text = new TextBlock
            {
                Text = "Welcome to the Home Page!",
                FontSize = 20,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };
            MainContentGrid.Children.Add(text);
        }
        private void Potato_Click(object sender, RoutedEventArgs e)
        {
            MainContentGrid.Children.Clear();
            TextBlock text = new TextBlock
            {
                Text = "Potato Recipes Coming Soon!",
                FontSize = 20,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };
            MainContentGrid.Children.Add(text);
        }

        private void Tomato_Click(object sender, RoutedEventArgs e)
        {
            MainContentGrid.Children.Clear();
            TextBlock text = new TextBlock
            {
                Text = "Tomato Recipes Coming Soon!",
                FontSize = 20,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };
            MainContentGrid.Children.Add(text);
        }
        private void Lemon_Click(object sender, RoutedEventArgs e)
        {
            MainContentGrid.Children.Clear();
            TextBlock text = new TextBlock
            {
                Text = "Lemon Recipes Coming Soon!",
                FontSize = 20,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };
            MainContentGrid.Children.Add(text);
        }
        private void About_Click(object sender, RoutedEventArgs e)
        {
            MainContentGrid.Children.Clear();
            TextBlock text = new TextBlock
            {
                Text = "About: This is a recipe manager application.",
                FontSize = 20,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };
            MainContentGrid.Children.Add(text);
        }
        private void Support_Click(object sender, RoutedEventArgs e)
        {
            MainContentGrid.Children.Clear();
            TextBlock text = new TextBlock
            {
                Text = "Support: Contact us at support@potatowpf.com",
                FontSize = 20,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };
            MainContentGrid.Children.Add(text);
        }
    }
}

