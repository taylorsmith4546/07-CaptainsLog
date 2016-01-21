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
using CaptainsLog.Core;
using System.IO;
using System.Collections.ObjectModel;


namespace CaptainsLog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Log currentLog;
        private LogEntry SelectedLogEntry;

        public MainWindow()
        {
            InitializeComponent();

            currentLog = new Log("My Log");

            gridLogEntries.ItemsSource = currentLog.Entries;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //collect input from the user
            //validate the input (did the user enter enough text, etc)
            //add to the grid

            string title = textBox_Title.Text;
            string entry = textBox_Entry.Text;
            DateTime currentDate = DateTime.Now;

            LogEntry newLog = new LogEntry();
            newLog.Id = currentLog.Entries.Count + 1;
            newLog.Title = title;
            newLog.Text = entry;
            newLog.EntryDate = currentDate;

            currentLog.Entries.Add(newLog);
            currentLog.Entries.Remove(SelectedLogEntry);

        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            textBox_Entry.Text = string.Empty;
            textBox_Title.Text = String.Empty;

        }


        private void button_Delete_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedLogEntry != null)
            { 
               currentLog.Entries.Remove(SelectedLogEntry);

            SelectedLogEntry = null;

        }
    }

    private void gridLogEntries_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
       SelectedLogEntry = (LogEntry)gridLogEntries.SelectedItem;
    }

        private void idSelect_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}


   

       
    
        
   

