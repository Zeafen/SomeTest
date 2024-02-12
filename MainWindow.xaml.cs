using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading;
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
namespace Project_Ver3._0_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int amount_of_texts;
        public MainWindow()
        {
            InitializeComponent();
            this.Closed += MainWindow_Closed;
            Introduction.Text = "   Welcome ladies and gentelmen to my English Test. Test includes three texts about three kinds of tea. In each text there are fifteen tasks. You can chose how many texts you will do." + Environment.NewLine + "Now introduction." + Environment.NewLine + "   Firstly, about the tasks in general. Well, there are some kinds of tasks. In some of them you need to translate from russian into english, other ones are word formation, where you should change the word to get the appropriate form. There will be task, where you should just choose right variant. That's all." + Environment.NewLine + "   Now choose amount of texts you want to see:";
        }

        private void MainWindow_Closed(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void RadioButton3_Checked(object sender, RoutedEventArgs e)
        {
            amount_of_texts = 3;
            MoveButtton.IsEnabled = true;
        }

        private void RadioButton2_Checked(object sender, RoutedEventArgs e)
        {
            amount_of_texts = 2;
            MoveButtton.IsEnabled = true;
        }

        private void RadioButton1_Checked(object sender, RoutedEventArgs e)
        {
            amount_of_texts = 1;
            MoveButtton.IsEnabled = true;
        }


        private void MoveButtton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            this.IsEnabled = false;
            TestWidow testWidow = new TestWidow(amount_of_texts);
            testWidow.Show();
        }
    }

}
