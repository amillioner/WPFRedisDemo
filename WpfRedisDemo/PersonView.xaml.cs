using System.Windows;

namespace WpfRedisDemo
{
    /// <summary>
    /// Interaction logic for PersonView.xaml
    /// </summary>
    public partial class PersonView : Window
    {
        public PersonView()
        {
            InitializeComponent();
            DataContext = new PersonViewModel();
        }
    }
}
