using Project_Ver3._0_.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ver3._0_.Model
{
    public class UserAnswers : ObservableCollection<IncomingAnswer>
    {
        public UserAnswers()
        {
        }
        public void GenerateAnswers(int TextNumber, int amount_of_Tasks)
        {
            for (int i = 0; i < amount_of_Tasks; i++)
            {
                Add(new IncomingAnswer { TaskNumber = i + 1, TextNumber = TextNumber, IsCorrect = false, Text = "" });
            }
        }
    }
}
