using System.Collections.ObjectModel;
using System.Windows;
using DataGridRow_DoubleClick.WPF.Models;

namespace DataGridRow_DoubleClick.WPF.ViewModels
{
	public sealed class PeopleViewModel
	{
		public PeopleViewModel()
		{
			People = new ObservableCollection<Person>();

			CreatePeople();
		}

		public void Edit()
		{
			if (SelectedPerson != null)
			{
				// TODO: Do your edit logic here. Please don't actually show a MessageBox
				//		 straight from your view model :)
				var message = string.Format("{0} {1} was selected.", SelectedPerson.FirstName, SelectedPerson.LastName);
				MessageBox.Show(message);
			}
		}

		private void CreatePeople()
		{
			People.Add(new Person { FirstName = "Brent", LastName = "Edwards" });
			People.Add(new Person { FirstName = "Bob", LastName = "Lablaw" });
		}

		public ObservableCollection<Person> People { get; set; }
		public Person SelectedPerson { get; set; }
	}
}
