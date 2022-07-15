using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CountDownTimer.Helpers;
using CountDownTimer.ViewModels;

namespace CountDownTimer
{
	public class MainWindowViewModel : ViewModelBase
	{
		#region " Constructor "

		public MainWindowViewModel()
		{
			RunningViewModel = new CountDownTimerViewModel();
		}

		#endregion

		#region " Fields "



		#endregion

		#region " Properties "

		private object _runningViewModel;
		public object RunningViewModel
		{
			get { return _runningViewModel; }
			set
			{
				_runningViewModel = value;
				OnPropertyChanged("RunningViewModel");
			}
		}

		#endregion

		#region " Methods "



		#endregion

		#region " Command Methods "



		#endregion

		#region " Commands "



		#endregion
	}
}
