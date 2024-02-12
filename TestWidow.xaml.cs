using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Project_Ver3._0_.Models;

namespace Project_Ver3._0_
{
    public partial class TestWidow : Window
    {

        public TestModel testModel { get; set; }
        public TestWidow(int amount_of_texts)
        {
            testModel = new TestModel(amount_of_texts);
            InitializeComponent();
            this.Closed += TestWidow_Closed;
        }
        private void TestWidow_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            testModel.ChangeText();
            if (testModel.CurrentTextNumber == testModel.amount_of_text+1)
            {
                this.Hide();
                this.IsEnabled = false;
                ResultWindow resWidnow = new ResultWindow(testModel);
                resWidnow.Show();
                return;
            }
        }
    }
}
