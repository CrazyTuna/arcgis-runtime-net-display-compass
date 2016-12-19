using System;
using Esri.ArcGISRuntime.Mapping;
using Xamarin.Forms;

namespace ArcGIS.XamarinForms.Toolkit
{
	public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();
            MapView.Map = new Map(Basemap.CreateStreets());
            MapView.ViewpointChanged += (sender, args) =>
            {
                NorthArrow.Rotation = -MapView.MapRotation;
                ScaleVal.Text = $"{Math.Round(Legend.Width * MapView.UnitsPerPixel, 0)}m";
            };
        }
    }
}
