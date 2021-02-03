using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ExpandableListView
{
    public class Behavior : Behavior<ContentPage>
    {
        private SfListView listView;
        private AccordionViewModel viewModel;

        public Behavior()
        {
            viewModel = new AccordionViewModel();
        }

        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            listView = bindable.FindByName<SfListView>("listView");
            viewModel.listView = listView;
            listView.BindingContext = viewModel;
            listView.ItemsSource = viewModel.ContactsInfo;
        }
    }
}
