using System;
using System.Collections;
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

namespace HashtableApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Add(Keytxt.Text,Valuetxt.Text);
            MessageBox.Show("Success! Key: " + Keytxt.Text + " Value: " + Valuetxt.Text);
            Keytxt.Text = "";
            Valuetxt.Text = "";
        }

        private void Removebtn_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Remove(Keytxt.Text);
            Keytxt.Text = "";
        }

        private void Showallbtn_Click(object sender, RoutedEventArgs e)
        {
            ICollection icollection = hashtable.Keys;
            foreach(string key in icollection)
            {
                MessageBox.Show(hashtable[key].ToString());
            }
        }
    }
}
