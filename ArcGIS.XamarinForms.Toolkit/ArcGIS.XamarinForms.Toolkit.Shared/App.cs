using Esri.ArcGISRuntime;

namespace ArcGIS.XamarinForms.Toolkit
{
	public class App : Xamarin.Forms.Application
	{
		public App ()
		{
            // Deployed applications must be licensed at the Lite level or greater. 
            // See https://developers.arcgis.com/licensing for further details.

            // Initialize the ArcGIS Runtime before any components are created.
            ArcGISRuntimeEnvironment.Initialize();

            // The root page of your application
            MainPage = new MapPage();
		}
	}
}
