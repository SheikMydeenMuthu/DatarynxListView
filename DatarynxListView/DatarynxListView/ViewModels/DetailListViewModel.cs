using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace DatarynxListView.ViewModels
{
    public class DetailListViewModel : BaseViewModel
    {
        private ObservableCollection<ListItem> _collectionViewSource;
        public DetailListViewModel()
        {
            BindCollectionData();
        }
        
        public ObservableCollection<ListItem> CollectionViewSource
        {
            get { return _collectionViewSource; }
            set
            {
                _collectionViewSource = value;
                OnPropertyChanged();
            }
        }
        private void BindCollectionData()
        {
            string JsonObject = "[{\"WeekNo\":\"w35\", \"WeekDate\" : \"08 - 9\", \"StoreName\" : \"Apple Store North Division\", \"StoreAddress\":\"North\", \"CodingType\" : \"Item Coding\", \"TaskState\" : \"Not Sorted\"},{\"WeekNo\":\"w36\", \"WeekDate\" : \"08 - 9\", \"StoreName\" : \"Lenovo Store North Division\", \"StoreAddress\":\"North\", \"CodingType\" : \"Item Coding\", \"TaskState\" : \"In Progress\"},{\"WeekNo\":\"w37\", \"WeekDate\" : \"08 - 9\", \"StoreName\" : \"Dell Store South Division\", \"StoreAddress\":\"North\", \"CodingType\" : \"Item Coding\", \"TaskState\" : \"Not Sorted\"},{\"WeekNo\":\"w38\", \"WeekDate\" : \"08 - 9\", \"StoreName\" : \"Acer Store North Division\", \"StoreAddress\":\"North\", \"CodingType\" : \"Item Coding\", \"TaskState\" : \"Not Sorted\"},{\"WeekNo\":\"w39\", \"WeekDate\" : \"08 - 9\", \"StoreName\" : \"Windows Store North Division\", \"StoreAddress\":\"North\", \"CodingType\" : \"Item Coding\", \"TaskState\" : \"Not Sorted\"}]";

            var collection = JsonConvert.DeserializeObject<List<ListItem>>(JsonObject);
            CollectionViewSource = new ObservableCollection<ListItem>(collection);
           
        }
    }
}
