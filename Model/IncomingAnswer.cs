using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ver3._0_.Models
{
    public class IncomingAnswer : INotifyPropertyChanged
    {
        private string _Text;
        private int _TextNumber;
        private int _TaskNumber;
        private bool _IsCorrect;

        public string Text
        {
            get => _Text;
            set
            {
                if (value == _Text) return;
                _Text = value;
                OnPropertyChanged(nameof(Text));
            }
        }
        public int TextNumber
        {
            get => _TextNumber;
            set
            {
                if (value == _TextNumber) return;
                _TextNumber = value;
                OnPropertyChanged(nameof(TextNumber));
            }
        }
        public int TaskNumber
        {
            get => _TaskNumber;
            set
            {
                if (value == _TaskNumber) return;
                _TaskNumber = value;
                OnPropertyChanged(nameof(TaskNumber));
            }
        }
        public bool IsCorrect
        {
            get => _IsCorrect;
            set
            {
                if (value == _IsCorrect) return;
                _IsCorrect = value;
                OnPropertyChanged(nameof(IsCorrect));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (propertyName == nameof(Text))
            {
                var right_answers = Storage.GetAsnwersByTxtNum(TextNumber - 1);
                if (Text.Equals(right_answers[TaskNumber - 1]))
                    IsCorrect = true;
                else
                    IsCorrect = false;

            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
