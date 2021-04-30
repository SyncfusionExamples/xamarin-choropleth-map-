using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Choropleth_Map
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ImageryLayer_RequestTileUri(object sender, Syncfusion.SfMaps.XForms.TileUriArgs e)
        {
            var link = "http://mt1.google.com/vt/lyrs=y&x=" + e.X.ToString() + "&y=" + e.Y.ToString() + "&z=" + e.ZoomLevel.ToString();
            e.Uri = link;
        }
    }
}
