using Avalonia.Controls;
using Avalonia.Controls.Models.TreeDataGrid;
using AvaloniaTreeDataGrid.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace AvaloniaTreeDataGrid.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<CityModel> Cities { get; set; }
        public FlatTreeDataGridSource<CityModel> Source { get; }

        public MainWindowViewModel()
        {
            var json = File.ReadAllText("world-cities_json.json");
            Cities = new ObservableCollection<CityModel>(JsonConvert.DeserializeObject<List<CityModel>>(json));

            Source = new FlatTreeDataGridSource<CityModel>(Cities)
            {
                Columns =
                {
                    new TextColumn<CityModel, int?>("GeoNameId", x => x.geonameid),
                    new TextColumn<CityModel, string>("Name", x => x.name),
                    new TextColumn<CityModel, string>("Country", x => x.country),
                    new TextColumn<CityModel, string>("Subcountry", x => x.subcountry)
                },
            };
        }    
    }
}
