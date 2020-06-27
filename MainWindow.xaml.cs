using System;
using System.Windows;
using System.Windows.Media;

namespace RandomNameChooser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StringSplitter stringSplitter;

        private RandomStringChooser randomNameString;

        private SolidColorBrush red;
        private SolidColorBrush black;
        public MainWindow()
        {
            InitializeComponent();
            stringSplitter = new StringSplitter();
            randomNameString = new RandomStringChooser();
            red = new SolidColorBrush(Colors.Red);
            black = new SolidColorBrush(Colors.Black);
        }

        private void ChooseNameButton_Click(object sender, RoutedEventArgs e)
        {
            ChooseRandomString();
        }

        private void ChooseRandomString()
        {
            String text = NamesTextBox.Text;
            if (text.Length > 0)
            {
                String[] names = stringSplitter.SplitStringOnSplitter(text, "\n");
                if (names.Length > 1)
                {
                    ChosenNameTextBlock.Foreground = black;
                    ChosenNameTextBlock.Text = randomNameString.ChooseRandomString(names);
                }
                else
                {
                    ChosenNameTextBlock.Foreground = red;
                    ChosenNameTextBlock.Text = "Please fill in at least two names.";
                }
            }
            else
            {
                ChosenNameTextBlock.Foreground = red;
                ChosenNameTextBlock.Text = "Input is empty.";
            }
        }
    }
}
