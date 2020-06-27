﻿using System;
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
            String[] names = stringSplitter.SplitStringOnSplitter(text, "\n");

            switch(InputValidator.Validate(text, names))
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
                case ValidationResult.NewLineAtEndOfInput:
                    ChosenNameTextBlock.Foreground = red;
                    ChosenNameTextBlock.Text = "Remove newline at end of input.";
                    break;
                default:
                    ChosenNameTextBlock.Text = "";
                    break;
            }
        }
    }
}
