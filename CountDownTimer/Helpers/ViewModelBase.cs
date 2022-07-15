using System.ComponentModel;

namespace CountDownTimer.Helpers
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        #region " INotifyPropertyChanged "

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        #endregion

        #region " Properties "

        private string _viewModelTitle;
        public string ViewModelTitle
        {
            get
            {
                return _viewModelTitle;
            }
            set
            {
                _viewModelTitle = value;
                OnPropertyChanged("ViewModelTitle");
            }
        }

        #endregion
    }
}
