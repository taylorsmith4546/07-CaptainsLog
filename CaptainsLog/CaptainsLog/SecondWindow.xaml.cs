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
 using System.Windows.Shapes;
using CaptainsLog; 
 using Microsoft.Win32; 
 using System.IO; 
 
 
 namespace CaptainsLog
 { 
     /// <summary> 
     /// Interaction logic for SecondWindow.xaml 
     /// </summary> 
     public partial class SecondWindow : Window 
     { 
         public SecondWindow()
         { 
             InitializeComponent(); 
         } 
         public void ReceiveStringTitle(string input)
         { 
             textBox_Title.Text = input; 
         } 
 
         public void ReceiveStringEntry(string input)
         { 
             textBox_Entry.Text = input; 
         } 
 
         private void button_Copy_Click(object sender, RoutedEventArgs e)
         { 
             SaveFileDialog saveFileDialog = new SaveFileDialog(); 
             saveFileDialog.Filter = "Text files (*.txt)|*.txt"; 
             if (saveFileDialog.ShowDialog() == true) 
                 File.WriteAllText(saveFileDialog.FileName, textBox_Title.Text + textBox_Entry.Text); 
 
         } 
     } 
 } 
