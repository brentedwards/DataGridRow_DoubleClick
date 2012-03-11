
namespace DataGridRow_DoubleClick.WPF.ViewModels
{
	public sealed class MainViewModel
	{
		public MainViewModel()
		{
			CodeBehind = new PeopleViewModel();
			AttachedProperty = new PeopleViewModel();
		}

		public PeopleViewModel CodeBehind { get; private set; }
		public PeopleViewModel AttachedProperty { get; private set; }
	}
}
