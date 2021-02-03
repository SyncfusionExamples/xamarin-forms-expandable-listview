using Syncfusion.ListView.XForms;
using Syncfusion.ListView.XForms.Control.Helpers;
using Syncfusion.ListView.XForms.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace ExpandableListView
{
    public class AccordionViewModel : INotifyPropertyChanged
    {
        #region Fields

        int counter = 11;

        #endregion

        #region Properties

        public ObservableCollection<Contact> ContactsInfo { get; set; }
        private Contact TappedItem;
        internal SfListView listView;
        public Command<object> TapGestureCommand { get; set; }

        #endregion

        #region Constructor

        public AccordionViewModel()
        {
            ContactsInfo = new ObservableCollection<Contact>();
            Assembly assembly = typeof(ExpandableListView.MainPage).GetTypeInfo().Assembly;
            int i = 0;
            foreach (var cusName in CustomerNames)
            {
                if (counter == 13)
                    counter = 1;
                var contact = new Contact(cusName);
                contact.CallTime = CallTime[i];
                contact.PhoneImage = ImageSource.FromResource("ExpandableListView.Images.PhoneImage.png", assembly);
                contact.ContactImage = ImageSource.FromResource("ExpandableListView.Images.Image" + counter + ".png", assembly);
                contact.AddContact = ImageSource.FromResource("ExpandableListView.Images.AddContact.png", assembly);
                contact.NewContact = ImageSource.FromResource("ExpandableListView.Images.NewContact.png", assembly);
                contact.SendMessage = ImageSource.FromResource("ExpandableListView.Images.SendMessage.png", assembly);
                contact.BlockSpan = ImageSource.FromResource("ExpandableListView.Images.BlockSpan.png", assembly);
                contact.CallDetails = ImageSource.FromResource("ExpandableListView.Images.CallDetails.png", assembly);
                i++;
                ContactsInfo.Add(contact);
                counter++;

            }
            TapGestureCommand = new Command<object>(TappedGestureCommandMethod);
        }

        private void TappedGestureCommandMethod(object obj)
        {
            var tappedItemData = obj as Contact;
            if (TappedItem != null && TappedItem.IsVisible)
            {
                TappedItem.IsVisible = false;
            }

            if (TappedItem == tappedItemData)
            {
                TappedItem = null;
                return;
            }

            TappedItem = tappedItemData;
            TappedItem.IsVisible = true;
        }
        #endregion

        #region Fields

        string[] CustomerNames = new string[] {
            "Kyle",
            "Gina",
            "Irene",
            "Katie",
            "Oscar",
            "Ralph",
            "Torrey",
            "William",
            "Bill",
            "Daniel",
            "Frank",
            "Brenda",
            "Danielle",
            "Fiona",
            "Howard",
            "Jack",
            "Larry",
            "Holly",
            "Liz",
            "Pete",
            "Steve",
            "Vince",
            "Katherin",
            "Aliza",
            "Masona" ,
            "Lia" ,
            "Jacob  " ,
            "Jayden " ,
            "Ethani  " ,
            "Noah   " ,
            "Lucas  " ,
            "Logan  " ,
            "John  " ,
        };

        string[] CallTime = new string[]
        {
            "India, 1 days ago",
            "India, 1 days ago",
            "India, 1 days ago",
            "India, 1 days ago",
            "India, 1 days ago",
            "India, 2 days ago",
            "India, 2 days ago",
            "India, 2 days ago",
            "India, 2 days ago",
            "India, 2 days ago",
            "India, 3 days ago",
            "India, 3 days ago",
            "India, 3 days ago",
            "India, 3 days ago",
            "India, 3 days ago",
            "India, 4 days ago",
            "India, 4 days ago",
            "India, 4 days ago",
            "India, 4 days ago",
            "India, 4 days ago",
            "India, 5 days ago",
            "India, 5 days ago",
            "India, 5 days ago",
            "India, 5 days ago",
            "India, 5 days ago",
            "India, 6 days ago",
            "India, 6 days ago",
            "India, 6 days ago",
            "India, 6 days ago",
            "India, 6 days ago",
            "India, 1 week ago",
            "India, 1 week ago",
            "India, 1 week ago"
        };

        #endregion

        #region Interface Member

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
