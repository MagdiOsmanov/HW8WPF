using Microsoft.Win32;
using System;
using System.Collections.Generic;
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

namespace HW8WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = (sender as ComboBox).SelectedItem as string;
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            double fontSize = Convert.ToDouble((sender as ComboBox).SelectedItem as string);
            if (textBox != null)
            {
                textBox.FontSize = fontSize;
            }
        }

        private void ExitExcecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OpenExcecuted(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы формата (*.txt)|*.txt| Все файлы(*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void SaveExcecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы формата(*.txt) | *.txt | Все файлы(*.*) | *.* ";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
            }
        }

        private void RedExcecuted(object sender, ExecutedRoutedEventArgs e)
        {

            if (Button1.IsChecked == true)
            {
                textBox.Foreground = Brushes.Black;
            }
            else
            {
                textBox.Foreground = Brushes.Red;
            }

        }

        private void BoldStyleExcecuted(object sender, ExecutedRoutedEventArgs e)
        {

            textBox.FontWeight = FontWeights.Bold;

        }

        private void ItalicStyleExcecuted(object sender, ExecutedRoutedEventArgs e)
        {
            textBox.FontStyle = FontStyles.Italic;
        }

        private void BaseLineExcecuted(object sender, ExecutedRoutedEventArgs e)
        {
            textBox.TextDecorations = TextDecorations.Underline;
        }
    }
}
