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
using System.IO;

namespace LetterCount
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> Letters;
        public List<int> zcount;
        public MainWindow()
        {
            InitializeComponent();
            Letters = new List<string>();
            zcount = new List<int>();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            countbks.Text = "";
            Letters.Clear();
            zcount.Clear();
            if (textBks.Text != "")
            {

                foreach (Char c in textBks.Text)
                {
                    
                    
                        if (!Letters.Contains(c.ToString()))
                        {
                           Letters.Add(c.ToString());
                           zcount.Add(1);
                        }
                        else
                        {
                        zcount[Letters.IndexOf(c.ToString())] += 1;
                        }

                    
                }

                foreach (string i in Letters)
                {
                    if(Letters.IndexOf(i) != Letters.Count - 1)
                    {
                        countbks.Text += i + ":" + zcount[Letters.IndexOf(i.ToString())] + " - ";
                    }
                    else
                    {
                        countbks.Text += i + ":" + zcount[Letters.IndexOf(i.ToString())];
                    }
                    
                }
                /*
                if (countbks.Text.EndsWith(" - "))
                {
                    countbks.Text = countbks.Text.Remove(countbks.Text.Length - 1);
                    countbks.Text = countbks.Text.Remove(countbks.Text.Length - 1);
                    countbks.Text = countbks.Text.Remove(countbks.Text.Length - 1);
                }
                */
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(filebks.Text))
            {
                textBks.Text = File.ReadAllText(filebks.Text);
            }

        }
    }
}
