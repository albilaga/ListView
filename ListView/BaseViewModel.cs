﻿namespace ListView
{
	public class BaseViewModel : ObservableObject
	{


		bool isBusy;

		/// <summary>
		/// Gets or sets a value indicating whether this instance is busy.
		/// </summary>
		/// <value><c>true</c> if this instance is busy; otherwise, <c>false</c>.</value>
		public bool IsBusy
		{
			get
			{
				return isBusy;
			}
			set
			{
				if (SetProperty(ref isBusy, value))
					IsNotBusy = !isBusy;
			}
		}

		bool isNotBusy = true;

		/// <summary>
		/// Gets or sets a value indicating whether this instance is not busy.
		/// </summary>
		/// <value><c>true</c> if this instance is not busy; otherwise, <c>false</c>.</value>
		public bool IsNotBusy
		{
			get
			{
				return isNotBusy;
			}
			set
			{
				if (SetProperty(ref isNotBusy, value))
					IsBusy = !isNotBusy;
			}
		}

	}
}
