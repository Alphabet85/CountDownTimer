using System;
using System.IO;
using System.Media;
using System.Windows.Input;
using System.Windows.Threading;

using CountDownTimer.Helpers;

namespace CountDownTimer.ViewModels
{
	public class CountDownTimerViewModel : ViewModelBase
    {
        private const int _defaultStartingSecondsAmount = 120;
        private const int _defaultStartingTokenAmount = 5;

        #region " Constructor "

        public CountDownTimerViewModel()
        {
            _timer = new DispatcherTimer();
            PlayPauseText = "Play";
            IsTimerRunning = false;
            CustomTimerAmount = _defaultStartingSecondsAmount.ToString();
            TokenCount = _defaultStartingTokenAmount;
            ResetTimer();
        }

        #endregion

        #region " Properties "

        private DispatcherTimer _timer;
        private int _startingSecondsAmount;

        private string _playPauseText;
        public string PlayPauseText
        {
            get { return _playPauseText; }
            set
            {
                _playPauseText = value;
                OnPropertyChanged("PlayPauseText");
            }
        }

        private string _timeRemaining;
        public string TimeRemaining
        {
            get { return _timeRemaining; }
            set
            {
                _timeRemaining = value;
                OnPropertyChanged("TimeRemaining");
            }
        }

        private bool _isTimerRunning;
        public bool IsTimerRunning
        {
            get { return _isTimerRunning; }
            set
            {
                _isTimerRunning = value;
                Console.WriteLine(IsTimerRunning);
                OnPropertyChanged("IsTimerRunning");
            }
        }

        private string _customTimerAmount;
        public string CustomTimerAmount
        {
            get { return _customTimerAmount; }
            set
            {
                _customTimerAmount = value;
                OnPropertyChanged("CustomTimerAmount");
            }
        }

        private bool _isSoundOn;
        public bool IsSoundOn
        {
            get { return _isSoundOn; }
            set
            {
                _isSoundOn = value;
                OnPropertyChanged("IsSoundOn");
            }
        }

        private int _tokenCount;
        public int TokenCount
        {
            get { return _tokenCount; }
            set
            {
                _tokenCount = value;
                OnPropertyChanged("TokenCount");
            }
        }

        #endregion

        #region " Methods "

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                _startingSecondsAmount--;
                TimeRemaining = _startingSecondsAmount.ToString();

                switch (TimeRemaining)
                {
                    case "30":
                        PlaySound(Properties.Resources.cd30sec);
                        break;
                    case "10":
                        PlaySound(Properties.Resources.cd10);
                        break;
                    case "9":
                        PlaySound(Properties.Resources.cd9);
                        break;
                    case "8":
                        PlaySound(Properties.Resources.cd8);
                        break;
                    case "7":
                        PlaySound(Properties.Resources.cd7);
                        break;
                    case "6":
                        PlaySound(Properties.Resources.cd6);
                        break;
                    case "5":
                        PlaySound(Properties.Resources.cd5);
                        break;
                    case "4":
                        PlaySound(Properties.Resources.cd4);
                        break;
                    case "3":
                        PlaySound(Properties.Resources.cd3);
                        break;
                    case "2":
                        PlaySound(Properties.Resources.cd2);
                        break;
                    case "1":
                        PlaySound(Properties.Resources.cd1);
                        break;
                    default:
                        break;
                }

                if (_startingSecondsAmount == 0)
                {
                    ToggleStartStop();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Timer_Tick() Exception: " + ex);
            }
        }

        private void PlaySound(UnmanagedMemoryStream _sound)
        {
            if (IsSoundOn)
            {
                try
                {
                    SoundPlayer player = new SoundPlayer(_sound);
                    player.Load();
                    player.Play();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("PlaySound() Exception: " + ex);
                }
            }
        }

        #endregion

        #region " Command Methods "

        private void SetTimer()
        {
            Console.WriteLine("SetTimer()...");

            _startingSecondsAmount = int.Parse(CustomTimerAmount);
            TimeRemaining = _startingSecondsAmount.ToString();
        }

        private void ToggleStartStop()
        {
            Console.WriteLine("ToggleStartStop()...");

            IsTimerRunning = !IsTimerRunning;

            if (IsTimerRunning)
            {
                if (TimeRemaining == "0")
                {
                    ResetTimer();
                }

                PlayPauseText = "Pause";
                _timer.Start();
            }
            else
            {
                PlayPauseText = "Play";
                _timer.Stop();
            }
        }

        private void ResetTimer()
        {
            Console.WriteLine("ResetTimer()...");

            if (IsTimerRunning)
            {
                PlayPauseText = "Play";
                IsTimerRunning = !IsTimerRunning;
            }

            if (_defaultStartingSecondsAmount != int.Parse(CustomTimerAmount))
            {
                _startingSecondsAmount = int.Parse(CustomTimerAmount);
                TimeRemaining = _startingSecondsAmount.ToString();
            }
            else
            {
                _startingSecondsAmount = _defaultStartingSecondsAmount;
                TimeRemaining = _startingSecondsAmount.ToString();
            }

            _timer.Stop();
            _timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            _timer.Tick += Timer_Tick;
        }

        private void AddToken()
        {
            Console.WriteLine("AddToken()...");

            TokenCount++;
        }

        private void SubtractToken()
        {
            Console.WriteLine("SubractToken()...");

            if (TokenCount > 0)
            {
                TokenCount--;
            }
        }

        #endregion

        #region " Commands "

        private ICommand _setTimerCommand;
        public ICommand SetTimerCommand
        {
            get
            {
                if (_setTimerCommand == null)
                {
                    _setTimerCommand = new RelayCommand(P => true, p => SetTimer());
                }

                return _setTimerCommand;
            }
        }

        private ICommand _ToggleStartStopCommand;
        public ICommand ToggleStartStopCommand
        {
            get
            {
                if (_ToggleStartStopCommand == null)
                {
                    _ToggleStartStopCommand = new RelayCommand(P => true, p => ToggleStartStop());
                }

                return _ToggleStartStopCommand;
            }
        }

        private ICommand _resetTimerCommand;
        public ICommand ResetTimerCommand
        {
            get
            {
                if (_resetTimerCommand == null)
                {
                    _resetTimerCommand = new RelayCommand(P => true, p => ResetTimer());
                }

                return _resetTimerCommand;
            }
        }

        private ICommand _addTokenCommand;
        public ICommand AddTokenCommand
        {
            get
            {
                if (_addTokenCommand == null)
                {
                    _addTokenCommand = new RelayCommand(P => true, p => AddToken());
                }

                return _addTokenCommand;
            }
        }

        private ICommand _subtractTokenCommand;
        public ICommand SubtractTokenCommand
        {
            get
            {
                if (_subtractTokenCommand == null)
                {
                    _subtractTokenCommand = new RelayCommand(P => true, p => SubtractToken());
                }

                return _subtractTokenCommand;
            }
        }

        #endregion
    }
}
