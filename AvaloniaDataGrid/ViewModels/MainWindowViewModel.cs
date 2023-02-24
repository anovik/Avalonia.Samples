using AvaloniaDataGrid.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace AvaloniaDataGrid.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<CityModel> Cities { get; set; }
        
        public MainWindowViewModel() 
        {
            var json = File.ReadAllText("world-cities_json.json");
            Cities  = new ObservableCollection<CityModel>(JsonConvert.DeserializeObject<List<CityModel>>(json));            
        }
    }
}
