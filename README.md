# arcgis-runtime-xamarin-toolkit
Display a compass and a scale line using the ArcGIS Runtime SDK (Xamarin.Forms) for iOS, Android and UWP app

My solution:
- Find a compass icon that can rotate (see this [article](https://developer.xamarin.com/guides/xamarin-forms/working-with/images/) to add image resource to Xamarin.Form)
- Add the image on top of the map:

    `<Image x:Name="NorthArrow" />`
- Rotate the image when the view point changed:

    `MapView.ViewpointChanged += (sender, args) =>
    `{
    `    NorthArrow.Rotation = -MapView.MapRotation;
    `};
    
Have fun ;-)

![ArcGIS Runtime .Net SDK Xamarin.Forms Display North Compass + Scale Line](/ScreenShot1.PNG?raw=true)
![ArcGIS Runtime .Net SDK Xamarin.Forms Display North Compass + Scale Line](/ScreenShot11.PNG?raw=true)

