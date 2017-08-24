
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OperationForms.ViewModels.Base
{
    /// <summary>
    /// Clase base para las vistas
    /// </summary>
    class BaseVM : INotifyPropertyChanged
    {
        bool isBusy = false;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }
    }
}
