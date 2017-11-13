using Xamarin.Forms;

namespace ListView
{
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage()
		{
			InitializeComponent();
			var vm = new ListViewModel();
			this.BindingContext = vm;
		}
	}
}
