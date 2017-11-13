using System;
using System.Collections.Generic;

namespace ListView
{
	public class ListViewModel : BaseViewModel
	{
		public ListViewModel()
		{
			var list = new List<Event>
			{
				new Event
				{
					BannerImageUri = "https://pesona.indonesia.travel/wp-content/uploads/2017/05/12068747_498561026991738_7547965895091326932_o.jpg",
					name = "Borobudur Marathon",
					datetime = "Today"
				},
				new Event
				{
					BannerImageUri = "https://indorace.com/uihalfmarathon2017/img/uihalfmarathonwebbanner1.jpg",
					name = "UI Marathon",
					datetime = "Tomorrow"
				},
				new Event
				{
					BannerImageUri = "https://event.howei.com/sites/default/files/events/2017/KLIAMarathon/Banner%20Design.jpg",
					name = "KUL Marathon",
					datetime = "Tomorrow"
				}
			};
			Items.AddRange(list);
		}

		ObservableRangeCollection<Event> _Items = new ObservableRangeCollection<Event>();
		public ObservableRangeCollection<Event> Items
		{
			get
			{
				return _Items;
			}
			set
			{
				SetProperty(ref _Items, value);
			}
		}
	}
}
