using OperationForms.Models;
using System;
using Xamarin.Forms;

namespace OperationForms.ViewModels
{
    class OperationVM : Base.BaseVM
    {
        Numbers numbers;
        MathOperations math;
        string numberA, numberB;
        string result;
        string messageZeroDivide;
        
        public Command CommandDivide { get; set; }

        public OperationVM()
        {
            numbers = new Numbers();
            math = new MathOperations();
            math.MessageHandler = ShowMesageZeroDivide;
            CommandDivide = new Command(() => ShowResult());
        }

        public String NumberA
        {
            get { return numberA; }
            set
            {
                numberA = value;
                OnPropertyChanged();
            }
        }

        public String NumberB
        {
            get { return numberB; }
            set
            {
                numberB = value;
                OnPropertyChanged();                
            }
        }

        public string Result
        {
            get { return result; }
        }

        public string MessageZeroDivide
        {
            get { return messageZeroDivide; }
        }

        public void ShowResult()
        {
            numbers.A = Convert.ToInt16(numberA);
            numbers.B = Convert.ToInt16(numberB);
            result = $"{math.Divide(numbers.A, numbers.B)}";
            OnPropertyChanged(nameof(Result));
        }

        public void ShowMesageZeroDivide(int A, int B)
        {
            messageZeroDivide = $"Division por cero, {A}, {B}";
            OnPropertyChanged(nameof(MessageZeroDivide));
        }

    }
}
