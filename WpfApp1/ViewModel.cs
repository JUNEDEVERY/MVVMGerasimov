using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Navigation;
using System.Windows.Input;
using System.Collections;
using System;

namespace WpfApp1
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged; // реализовываем событие


        public string tbSign { get => Model.tbSign.ToString(); }
        public List<string> cmbItems { get; } = Model.cmbOperation;
        //public List<string> tbSign { get; } = Model.tbSign;


        int SelectionIndex = 0;
        public int cbSelectedIndex
        {
            get
            {
                return SelectionIndex;
            }
            set
            {
                SelectionIndex = value;
                PropertyChanged(this, new PropertyChangedEventArgs("cbSelectedIndex2"));
            }
        }
        public string cbSelectedIndex2
        {
            get
            {
                if (SelectionIndex == -1)
                {
                    return "No selected items";
                }
                else
                {
                    return Model.tbSign[SelectionIndex];

                }
            }


        }
        public string Result
        {
            get
            {
                return Model.tbResult.ToString();
            }
        }

        public string tbFirst
        {
            set
            {
                Model.tbFirst = value;
            }
            get
            {
                return Model.tbFirst;
            }
        }
        public string tbSecond
        {
            set
            {
                Model.tbSecond = value;
            }
            get
            {
                return Model.tbSecond;
            }
        }
        public RoutedCommand Command { get; set; } = new RoutedCommand();
        public void Command_Execude(object sender, ExecutedRoutedEventArgs e)
        {
            double firstVariable = Convert.ToDouble(Model.tbFirst);
            double secondVariable = Convert.ToDouble(Model.tbSecond);


            switch (SelectionIndex)
            {
                case 0: // кейсы - айдишники выбранного  элементы комбобокса
                    Model.tbResult = Convert.ToString(firstVariable + secondVariable);

                    break;
                case 1:
                    Model.tbResult = Convert.ToString(firstVariable * secondVariable);

                    break;
                case 2:
                    if (secondVariable == 0)
                    {
                        Model.tbResult = "Вы что? Делить на 0 нельзя";

                    }
                    else
                    {
                        Model.tbResult = Convert.ToString(firstVariable / secondVariable);
                    }
                    break;
                case 3:
                    Model.tbResult = Convert.ToString(firstVariable - secondVariable);
                    break;



            }
            PropertyChanged(this, new PropertyChangedEventArgs("Result"));
        }
        public CommandBinding binding;
        public ViewModel()
        {

            binding = new CommandBinding(Command);
            binding.Executed += Command_Execude;
        }


        // public List<string> tbSign { get; } = Model.tbSign;
    }
}
