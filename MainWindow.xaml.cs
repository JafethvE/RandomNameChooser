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
        private RandomStringChooser randomNameString;

        private InputValidator inputValidator;

        private SolidColorBrush red;
        private SolidColorBrush black;
        public MainWindow()
        {
            InitializeComponent();
            randomNameString = new RandomStringChooser();
            inputValidator = new InputValidator();
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
            String[] names = { };

            switch(inputValidator.Validate(text, ref names))
            {
                case ValidationResult.Valid:
                    ChosenNameTextBlock.Foreground = black;
                    ChosenNameTextBlock.Text = randomNameString.ChooseRandomString(names);
                    break;
                case ValidationResult.NoData:
                    ChosenNameTextBlock.Foreground = red;
                    ChosenNameTextBlock.Text = "Input is empty.";
                    break;
                case ValidationResult.InsufficientData:
                    ChosenNameTextBlock.Foreground = red;
                    ChosenNameTextBlock.Text = "Please fill in at least two names.";
                    break;
                case ValidationResult.EmptyStringDetected:
                    ChosenNameTextBlock.Foreground = red;
                    ChosenNameTextBlock.Text = "At least one name is empty.";
                    break;
                default:
                    ChosenNameTextBlock.Text = "";
                    break;
            }
        }
    }
}
