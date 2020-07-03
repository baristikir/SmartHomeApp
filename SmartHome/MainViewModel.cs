using System;
using System.Collections.ObjectModel;

namespace SmartHome
{
    public class MainViewModel
    {
        public ObservableCollection<DummyItem> Items { get; set; }

        public MainViewModel()
        {
            Items = new ObservableCollection<DummyItem>()
            {
                new DummyItem { Title = "Living Room", Description = "4 devices to manage", Temperature = "21°C" },
                new DummyItem { Title = "Dinning Room", Description = "4 devices to manage", Temperature = "21°C" },
                new DummyItem { Title = "Kitchen", Description = "4 devices to manage", Temperature = "21°C" },
            };
        }
    }

    public class DummyItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Temperature { get; set; }
    }
}
