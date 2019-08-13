using Syncfusion.ListView.XForms.Control.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExpandableListView
{
    public partial class MainPage : ContentPage
    {
        private Contact tappedItem;
        public MainPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var tappedItemData = (e as TappedEventArgs).Parameter as Contact;
            if (tappedItem != null && tappedItem.IsVisible)
            {
                var previousIndex = this.listView.DataSource.DisplayItems.IndexOf(tappedItem);

                tappedItem.IsVisible = false;

                if (Device.RuntimePlatform != Device.macOS)
                    Device.BeginInvokeOnMainThread(() => { this.listView.RefreshListViewItem(previousIndex, previousIndex, false); });
            }

            if (tappedItem == tappedItemData)
            {
                if (Device.RuntimePlatform == Device.macOS)
                {
                    var previousIndex = this.listView.DataSource.DisplayItems.IndexOf(tappedItem);
                    Device.BeginInvokeOnMainThread(() => { this.listView.RefreshListViewItem(previousIndex, previousIndex, false); });
                }

                tappedItem = null;
                return;
            }

            tappedItem = tappedItemData;
            tappedItem.IsVisible = true;

            if (Device.RuntimePlatform == Device.macOS)
            {
                var visibleLines = this.listView.GetVisualContainer().ScrollRows.GetVisibleLines();
                var firstIndex = visibleLines[visibleLines.FirstBodyVisibleIndex].LineIndex;
                var lastIndex = visibleLines[visibleLines.LastBodyVisibleIndex].LineIndex;
                Device.BeginInvokeOnMainThread(() => { listView.RefreshListViewItem(firstIndex, lastIndex, false); });
            }
            else
            {
                var currentIndex = listView.DataSource.DisplayItems.IndexOf(tappedItemData);
                Device.BeginInvokeOnMainThread(() => { listView.RefreshListViewItem(currentIndex, currentIndex, false); });
            }
        }
    }
}
