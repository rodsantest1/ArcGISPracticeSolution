﻿using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Mapping;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DisplayMap
{
    class MapViewModel : INotifyPropertyChanged
    {

        public MapViewModel()
        {
            SetupMap();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Map _map;
        public Map Map
        {
            get { return _map; }
            set
            {
                _map = value;
                OnPropertyChanged();
            }
        }

        private void SetupMap()
        {

            // Create a new map with a 'topographic vector' basemap.
            Map = new Map(BasemapStyle.ArcGISTopographic);

        }
    }
}
