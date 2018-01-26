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
            PersonList aList = new PersonList()
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
            aList.Heading = "A";

            PersonList bList = new PersonList()
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
            bList.Heading = "B";

            PersonList dList = new PersonList()
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

            dList.Heading = "D";

            PersonList jList = new PersonList()
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
            jList.Heading = "J";

            PersonList gList = new PersonList()
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

            gList.Heading = "G";

            PersonList mList = new PersonList()
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

            mList.Heading = "M";

            PersonList nList = new PersonList()
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

            nList.Heading = "N";

            PersonList sList = new PersonList()
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

            sList.Heading = "S";

            PersonList uList = new PersonList()
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

            uList.Heading = "U";

            List<PersonList> list = new List<PersonList>()
            {
                aList,
                bList,
                dList,
                jList,
                gList,
                mList,
                nList,
                sList,
                uList,
            };

            _observableList = new ObservableCollection<PersonList>(list);

            MyListView.ItemsSource = list;

            base.OnAppearing();
        }
    }
}