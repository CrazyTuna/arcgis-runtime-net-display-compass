using Esri.ArcGISRuntime.Mapping;
using Xamarin.Forms;

namespace ArcGIS.XamarinForms.Compass
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
            };
        }
    }
}
