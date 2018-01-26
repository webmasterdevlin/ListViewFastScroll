using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ListViewFastScroll
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<PersonList> _observableList;

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            PersonList aGroup = new PersonList()
            {
                new Person {FirstName = "Michael", LastName = "Arenas"},
                new Person {FirstName = "Michael", LastName = "Arenas"},
                new Person {FirstName = "Michael", LastName = "Arenas"},
                new Person {FirstName = "Michael", LastName = "Arenas"},
                new Person {FirstName = "Michael", LastName = "Arenas"},
                new Person {FirstName = "Michael", LastName = "Arenas"},
                new Person {FirstName = "Michael", LastName = "Arenas"},
                new Person {FirstName = "Michael", LastName = "Arenas"},
                new Person {FirstName = "Michael", LastName = "Arenas"},
                new Person {FirstName = "Michael", LastName = "Arenas"},
            };
            aGroup.Heading = "A";

            PersonList bGroup = new PersonList()
            {
                new Person {FirstName = "Johny", LastName = "Ben"},
                new Person {FirstName = "Johny", LastName = "Ben"},
                new Person {FirstName = "Johny", LastName = "Ben"},
                new Person {FirstName = "Johny", LastName = "Ben"},
                new Person {FirstName = "Johny", LastName = "Ben"},
                new Person {FirstName = "Johny", LastName = "Ben"},
                new Person {FirstName = "Johny", LastName = "Ben"},
                new Person {FirstName = "Johny", LastName = "Ben"},
                new Person {FirstName = "Johny", LastName = "Ben"},
                new Person {FirstName = "Johny", LastName = "Ben"},
                new Person {FirstName = "Johny", LastName = "Ben"},
            };
            bGroup.Heading = "B";

            PersonList dGroup = new PersonList()
            {
                new Person { FirstName = "Dave", LastName = "Devlin" },
                new Person { FirstName = "Dave", LastName = "Devlin" },
                new Person { FirstName = "Dave", LastName = "Devlin" },
                new Person { FirstName = "Dave", LastName = "Devlin" },
                new Person { FirstName = "Dave", LastName = "Devlin" },
                new Person { FirstName = "Dave", LastName = "Devlin" },
                new Person { FirstName = "Dave", LastName = "Devlin" },
                new Person { FirstName = "Dave", LastName = "Devlin" },
                new Person { FirstName = "Dave", LastName = "Devlin" },
                new Person { FirstName = "Dave", LastName = "Devlin" },
                new Person { FirstName = "Dave", LastName = "Devlin" },
            };

            dGroup.Heading = "D";

            PersonList jGroup = new PersonList()
            {
                new Person { FirstName = "Ruby", LastName = "Jane" },
                new Person { FirstName = "Ruby", LastName = "Jane" },
                new Person { FirstName = "Ruby", LastName = "Jane" },
                new Person { FirstName = "Ruby", LastName = "Jane" },
                new Person { FirstName = "Ruby", LastName = "Jane" },
                new Person { FirstName = "Ruby", LastName = "Jane" },
                new Person { FirstName = "Ruby", LastName = "Jane" },
                new Person { FirstName = "Ruby", LastName = "Jane" },
                new Person { FirstName = "Ruby", LastName = "Jane" },
                new Person { FirstName = "Ruby", LastName = "Jane" },
                new Person { FirstName = "Ruby", LastName = "Jane" },
            };
            jGroup.Heading = "J";

            PersonList gGroup = new PersonList()
            {
                new Person { FirstName = "Bruno", LastName = "Mars" },
                new Person { FirstName = "Bruno", LastName = "Mars" },
                new Person { FirstName = "Bruno", LastName = "Mars" },
                new Person { FirstName = "Bruno", LastName = "Mars" },
                new Person { FirstName = "Bruno", LastName = "Mars" },
                new Person { FirstName = "Bruno", LastName = "Mars" },
                new Person { FirstName = "Bruno", LastName = "Mars" },
                new Person { FirstName = "Bruno", LastName = "Mars" },
                new Person { FirstName = "Bruno", LastName = "Mars" },
                new Person { FirstName = "Bruno", LastName = "Mars" },
            };

            gGroup.Heading = "G";

            PersonList mGroup = new PersonList()
            {
                new Person { FirstName = "Bruno", LastName = "Mars" },
                new Person { FirstName = "Bruno", LastName = "Mars" },
                new Person { FirstName = "Bruno", LastName = "Mars" },
                new Person { FirstName = "Bruno", LastName = "Mars" },
                new Person { FirstName = "Bruno", LastName = "Mars" },
                new Person { FirstName = "Bruno", LastName = "Mars" },
                new Person { FirstName = "Bruno", LastName = "Mars" },
                new Person { FirstName = "Bruno", LastName = "Mars" },
                new Person { FirstName = "Bruno", LastName = "Mars" },
                new Person { FirstName = "Bruno", LastName = "Mars" },
            };

            mGroup.Heading = "M";

            PersonList nGroup = new PersonList()
            {
                new Person { FirstName = "Shikamaru", LastName = "Nara" },
                new Person { FirstName = "Shikamaru", LastName = "Nara" },
                new Person { FirstName = "Shikamaru", LastName = "Nara" },
                new Person { FirstName = "Shikamaru", LastName = "Nara" },
                new Person { FirstName = "Shikamaru", LastName = "Nara" },
                new Person { FirstName = "Shikamaru", LastName = "Nara" },
                new Person { FirstName = "Shikamaru", LastName = "Nara" },
                new Person { FirstName = "Shikamaru", LastName = "Nara" },
                new Person { FirstName = "Shikamaru", LastName = "Nara" },
                new Person { FirstName = "Shikamaru", LastName = "Nara" },
                new Person { FirstName = "Shikamaru", LastName = "Nara" },
            };

            nGroup.Heading = "N";

            PersonList sGroup = new PersonList()
            {
                new Person { FirstName = "Sasha", LastName = "Swift" },
                new Person { FirstName = "Sasha", LastName = "Swift" },
                new Person { FirstName = "Sasha", LastName = "Swift" },
                new Person { FirstName = "Sasha", LastName = "Swift" },
                new Person { FirstName = "Sasha", LastName = "Swift" },
                new Person { FirstName = "Sasha", LastName = "Swift" },
                new Person { FirstName = "Sasha", LastName = "Swift" },
                new Person { FirstName = "Sasha", LastName = "Swift" },
                new Person { FirstName = "Sasha", LastName = "Swift" },
                new Person { FirstName = "Sasha", LastName = "Swift" },
            };

            sGroup.Heading = "S";

            PersonList uGroup = new PersonList()
            {
                new Person { FirstName = "Naruto", LastName = "Uzumaki" },
                new Person { FirstName = "Naruto", LastName = "Uzumaki" },
                new Person { FirstName = "Naruto", LastName = "Uzumaki" },
                new Person { FirstName = "Naruto", LastName = "Uzumaki" },
                new Person { FirstName = "Naruto", LastName = "Uzumaki" },
                new Person { FirstName = "Naruto", LastName = "Uzumaki" },
                new Person { FirstName = "Naruto", LastName = "Uzumaki" },
                new Person { FirstName = "Naruto", LastName = "Uzumaki" },
                new Person { FirstName = "Naruto", LastName = "Uzumaki" },
                new Person { FirstName = "Naruto", LastName = "Uzumaki" },
                new Person { FirstName = "Naruto", LastName = "Uzumaki" },
            };

            uGroup.Heading = "U";

            List<PersonList> list = new List<PersonList>()
            {
                aGroup,
                bGroup,
                dGroup,
                jGroup,
                gGroup,
                mGroup,
                nGroup,
                sGroup,
                uGroup,
            };

            _observableList = new ObservableCollection<PersonList>(list);

            MyListView.ItemsSource = list;

            base.OnAppearing();
        }
    }
}