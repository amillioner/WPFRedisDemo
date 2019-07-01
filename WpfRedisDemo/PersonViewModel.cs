using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WpfRedisDemo
{
    public class PersonViewModel : INotifyPropertyChanged
    {

        PersonDataModel _objDataSource = new PersonDataModel();

        public ObservableCollection<Person> PeopleList
        {
            get { return new ObservableCollection<Person>(_objDataSource.GetStudentRecords()); }

        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
