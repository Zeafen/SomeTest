using GalaSoft.MvvmLight.CommandWpf;
using Project_Ver3._0_.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Project_Ver3._0_.Models
{
    public class TestModel : INotifyPropertyChanged
    {
        public int amount_of_text;
        public static int balls = 0;
        public Dictionary<int, IList<IncomingAnswer>> WrongAnswers { get; set; } = new Dictionary<int, IList<IncomingAnswer>>();
        public UserAnswers Answers { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public TestModel(int _amount_of_texts)
        {
            CurrentText = Storage.GetTextByNum(0);
            CurrentTextNumber = 1;
            amount_of_text = _amount_of_texts;
            for (int i = 1; i <= amount_of_text; i++)
            {
                WrongAnswers.Add(i, new ObservableCollection<IncomingAnswer>());
            }
            Answers = new UserAnswers();
            Answers.GenerateAnswers(CurrentTextNumber, 15);
        }
        private int _CurrentTextNumber;
        private string _CurrentText;
        public int CurrentTextNumber
        {
            get => _CurrentTextNumber;
            set
            {
                if (value == _CurrentTextNumber) return;
                _CurrentTextNumber = value;
                OnPropertyChanged(nameof(CurrentTextNumber));
            }
        }
        public string CurrentText
        {
            get => _CurrentText;
            set
            {
                if (_CurrentText == value) return;
                _CurrentText = value;
                OnPropertyChanged(nameof(CurrentText));
            }
        }


        private void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void ChangeText()
        {
            CheckBalls();
            if (CurrentTextNumber != amount_of_text)
                CurrentText = Storage.GetTextByNum(CurrentTextNumber);
            CurrentTextNumber++;

        }

        private void CheckBalls()
        {
            foreach (IncomingAnswer item in Answers)
            {
                if (item.IsCorrect)
                    balls++;
                else
                    WrongAnswers[CurrentTextNumber].Add(item);
            }
            Answers.Clear();
            Answers.GenerateAnswers(CurrentTextNumber, 15);
        }

        /*private string[] RandomiseTexts(int amount_of_texts)
        {
            string[] Swapper;

            int r1 = new Random().Next(3);
            int r2 = new Random().Next(3);
            int r3 = new Random().Next(3);
            while (r1 == r2 || r1 == r3 || r2 == r3)
            {
                r2 = new Random().Next(3);
                r3 = new Random().Next(3);
            }
            switch (amount_of_texts)
            {
                case 1:
                    Swapper = new string[1];
                    Swapper[0] = Storage.GetTextByNum(r1);
                    return Swapper;
                case 2:

                    Swapper = new string[2];
                    Swapper[0] = Storage.GetTextByNum(r1);
                    Swapper[1] = Storage.GetTextByNum(r2);
                    return Swapper;
                case 3:
                    Swapper = new string[3];
                    Swapper[0] = Storage.GetTextByNum(r1);
                    Swapper[1] = Storage.GetTextByNum(r2);
                    Swapper[2] = Storage.GetTextByNum(r3);
                    return Swapper;
            }
            return null;
        }*/
    }
}
