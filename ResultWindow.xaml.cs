using Project_Ver3._0_.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace Project_Ver3._0_
{
    /// <summary>
    /// Interaction logic for ResultWindow.xaml
    /// </summary>
    public partial class ResultWindow : Window
    {
        public TestModel testModel { get; set; }
        public ResultWindow(TestModel _testModel)
        {
            testModel = _testModel;
            InitializeComponent();
            ListBox lstWrAns1=null;
            ListBox lstWrAns2=null;
            ListBox lstWrAns3=null;
            DataTemplate template = (DataTemplate)Application.Current.Resources["TaskSelection"];
            switch (testModel.amount_of_text)
            {
                case 1:
                    lstWrAns1 = new ListBox {
                        ItemTemplate = template,
                        ItemsSource = testModel.WrongAnswers[1],
                        Height = 200 };
                    ResWin.Children.Add(lstWrAns1);
                    Grid.SetRow(lstWrAns1, 1);
                    Grid.SetColumn(lstWrAns1, 1);
                    break;
                case 2:
                     lstWrAns1 = new ListBox
                    {
                        ItemTemplate = template,
                        ItemsSource = testModel.WrongAnswers[1],
                        Height = 200 };
                    ResWin.Children.Add(lstWrAns1);
                    Grid.SetRow(lstWrAns1, 1);
                    Grid.SetColumn(lstWrAns1, 0);

                    lstWrAns2 = new ListBox
                    {
                        ItemTemplate = template,
                        ItemsSource = testModel.WrongAnswers[2],
                        Height = 200
                    };
                    ResWin.Children.Add(lstWrAns2);
                    Grid.SetRow(lstWrAns2, 1);
                    Grid.SetColumn(lstWrAns2, 2);
                    break;
                case 3:
                    lstWrAns1 = new ListBox
                    {
                        ItemTemplate = template,
                        ItemsSource = testModel.WrongAnswers[1],
                        Height = 200 };
                    ResWin.Children.Add(lstWrAns1);
                    Grid.SetRow(lstWrAns1, 1);
                    Grid.SetColumn(lstWrAns1, 0);

                    lstWrAns2 = new ListBox
                    {
                        ItemTemplate = template,
                        ItemsSource = testModel.WrongAnswers[2],
                        Height = 200
                    };
                    ResWin.Children.Add(lstWrAns2);
                    Grid.SetRow(lstWrAns2, 1);
                    Grid.SetColumn(lstWrAns2, 1);

                    lstWrAns3 = new ListBox
                    {
                        ItemTemplate = template,
                        ItemsSource = testModel.WrongAnswers[3],
                        Height = 200 };

                    ResWin.Children.Add(lstWrAns3);
                    Grid.SetRow(lstWrAns3, 1);
                    Grid.SetColumn(lstWrAns3, 2);

                    break;
            }
            SummingUp();
            this.Closed += ResultWidow_Closed;
        }

        private void ResultWidow_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void SummingUp()
        {
            switch (testModel.amount_of_text)
            {
                case 1:
                    if (TestModel.balls > 0 && TestModel.balls <= 5) Conclusion.Text = "You got " + TestModel.balls.ToString() + " balls" + Environment.NewLine + "Realy bad. Please, pay more attention to learning English.";
                    else if (TestModel.balls > 5 && TestModel.balls <= 10) Conclusion.Text = "You got " + TestModel.balls.ToString() + " balls" + Environment.NewLine + "Not as bad as it could be, but it\'s still not good.Next time try harder";
                    else if (TestModel.balls == 15) Conclusion.Text = "Congratulations, you don\'t have any mistake. " + Environment.NewLine + "Unfortunately, you have completed only one text, instead of three. I wonder how lasy you are!";
                    else Conclusion.Text = "You got " + TestModel.balls.ToString() + " balls" + Environment.NewLine + "You don't know even basics. Why did you even open this test?";
                    break;
                case 2:
                    if (TestModel.balls > 0 && TestModel.balls <= 10) Conclusion.Text = "To sum up you got " + TestModel.balls.ToString() + " balls." + Environment.NewLine + "Bad. Please, start learning english harder.";
                    else if (TestModel.balls > 10 && TestModel.balls <= 20) Conclusion.Text = "To sum up you got " + TestModel.balls.ToString() + " balls" + Environment.NewLine + "ot very good, but enough for not to be called beginner.";
                    else if (TestModel.balls > 20 && TestModel.balls < 30) Conclusion.Text = "To sum up you got " + TestModel.balls.ToString() + " balls" + Environment.NewLine + "Nice work. You did it very well. Please continue learning this language";
                    else if (TestModel.balls == 30) Conclusion.Text = "Congratulations.You haven\'t done any mistake.\nAlso you completed two of three texts. That\'s respectable. However, i believe that you can do much more.";
                    else Conclusion.Text = "I wonder how you don\'t answer any question correctly. Very bad.";
                    break;
                case 3:
                    if (TestModel.balls > 0 && TestModel.balls <= 10) Conclusion.Text = "To sum up you got " + TestModel.balls.ToString() + " balls" + Environment.NewLine + "Awful. Why did you open this test if you don\'t know much in english?";
                    else if (TestModel.balls > 10 && TestModel.balls <= 20) Conclusion.Text = "To sum up you got " + TestModel.balls.ToString() + " balls" + Environment.NewLine + "Not as bad as it could be.";
                    else if (TestModel.balls > 20 && TestModel.balls < 30) Conclusion.Text = "To sum up you got " + TestModel.balls.ToString() + " balls" + Environment.NewLine + "Realy good result.  The only one thing i want you to do is not to forget about learning English language.";
                    else if (TestModel.balls == 30) Conclusion.Text = "Wow. I just don\'t have anything to say. It just incredible that you\'re so good at it.";
                    else Conclusion.Text = "How unintelegent you are!!!  You\'ve completed three texst and you didn\'t get ANY right answer.  Couldn\'t you just randomly write somethimg or use the translator at least. To summarise, just close this test and don\'t open it again.";
                    break;
            }
        }

    }
}
