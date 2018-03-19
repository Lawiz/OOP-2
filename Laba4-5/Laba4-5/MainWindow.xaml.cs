using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace Laba4_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

          
        }
        void SaveRTBContent(Object sender, RoutedEventArgs args)
        {

            // Send an arbitrary URL and file name string specifying
            // the location to save the XAML in.
            SaveXamlPackage(@"C:\Users\petrs.PETR\Documents\text.xml");
        }

        // Handle "Load RichTextBox Content" button click.
        void LoadRTBContent(Object sender, RoutedEventArgs args)
        {
            // Send URL string specifying what file to retrieve XAML
            // from to load into the RichTextBox.
            LoadXamlPackage(@"C:\Users\petrs.PETR\Documents\text.xml");
        }

        // Handle "Print RichTextBox Content" button click.
        void PrintRTBContent(Object sender, RoutedEventArgs args)
        {
            PrintCommand();
        }

        // Save XAML in RichTextBox to a file specified by _fileName
        void SaveXamlPackage(string _fileName)
        {
            TextRange range;
            FileStream fStream;
            range = new TextRange(richTB.Document.ContentStart, richTB.Document.ContentEnd);
            fStream = new FileStream(_fileName, FileMode.Create);
            range.Save(fStream, DataFormats.XamlPackage);
            fStream.Close();
        }

        // Load XAML into RichTextBox from a file specified by _fileName
        void LoadXamlPackage(string _fileName)
        {
            TextRange range;
            FileStream fStream;
            if (File.Exists(_fileName))
            {
                range = new TextRange(richTB.Document.ContentStart, richTB.Document.ContentEnd);
                fStream = new FileStream(_fileName, FileMode.OpenOrCreate);
                range.Load(fStream, DataFormats.XamlPackage);
                fStream.Close();
            }
        }

        // Print RichTextBox content
        void PrintCommand()
        {
            PrintDialog pd = new PrintDialog();
            if ((pd.ShowDialog() == true))
            {
                //use either one of the below      
                pd.PrintVisual(richTB as Visual, "printing as visual");
                pd.PrintDocument((((IDocumentPaginatorSource)richTB.Document).DocumentPaginator), "printing as paginator");
            }

        }
        private void text_PreviewDragEnter(object sender, DragEventArgs e)
        {
            bool isCorrect = true;

            if (e.Data.GetDataPresent(DataFormats.FileDrop, true) == true)
            {
                string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop, true);
                foreach (string filename in filenames)
                {
                    if (File.Exists(filename) == false)
                    {
                        isCorrect = false;
                        break;
                    }
                    FileInfo info = new FileInfo(filename);
                    if (info.Extension != ".txt")
                    {
                        isCorrect = false;
                        break;
                    }
                }
            }
            if (isCorrect == true)
                e.Effects = DragDropEffects.All;
            else
                e.Effects = DragDropEffects.None;
            e.Handled = true;
        }

        private void text_PreviewDrop(object sender, DragEventArgs e)
        {
            string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop, true);
            foreach (string filename in filenames)
                richTB.AppendText(File.ReadAllText(filename));
            e.Handled = true;
        }
    }
 }

