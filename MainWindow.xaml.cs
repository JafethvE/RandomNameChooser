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

namespace RandomNameChooser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StringSplitter stringSplitter;

        private RandomStringChooser randomNameString;
        public MainWindow()
        {
            InitializeComponent();
            stringSplitter = new StringSplitter();
            randomNameString = new RandomStringChooser();
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
                    ChosenNameTextBlock.Text = randomNameString.ChooseRandomString(names);
                }
                else
                {
                    ChosenNameTextBlock.Text = "Please fill in at least two names.";
                }
            }
            else
            {
                ChosenNameTextBlock.Text = "Input is empty.";
            }
        }
    }
}
