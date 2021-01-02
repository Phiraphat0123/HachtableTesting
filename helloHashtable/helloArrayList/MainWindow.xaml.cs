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

namespace helloArrayList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable H;
        public MainWindow()
        {
            InitializeComponent();
            H = new Hashtable();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (key.Text == ""||value.Text =="")
            {
                MessageBox.Show("ไม่มีข้อมูล");
            }
            else
            {
                H.Add(key.Text,value.Text);
                key.Text = "";
                value.Text = "";
            }
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            if (H.Count == 0)
            {
                MessageBox.Show("ไม่สามารถลบได้เนื่องจาก Hashtable ไม่มีข้อมูล");
            }
            else {
                H.Remove(key.Text);
             key.Text = "";
                value.Text = "";
            }
            
        }

        private void show_Click(object sender, RoutedEventArgs e)
        {
            ICollection iCollection = H.Keys;
            if (H.Count == 0)
            {
                MessageBox.Show("ไม่มีข้อมูล");
            }
            else
            {
                foreach (string key in iCollection) {
                    MessageBox.Show(H[key].ToString());
                }
            }

            
            
            
        }

        
    }
}
