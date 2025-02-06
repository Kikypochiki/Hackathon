using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hackathon
{
    public partial class foodHub : UserControl
    {
        public foodHub()
        {
            InitializeComponent();
            showMap();
        }

        private void showMap()
        {
            string html = @"
    <!DOCTYPE html>
    <html>
    <head>
      <title>Map</title>
      <style>
        #map { height: 100%; width: 100%; } /* Important: Set height and width */
      </style>
      <script src='https://maps.googleapis.com/maps/api/js?key=YOUR_API_KEY&callback=initMap' async defer></script>
      <script>
        let map;
        function initMap() {
          map = new google.maps.Map(document.getElementById('map'), {
            center: { lat: 10.7476, lng: 124.8596 }, // Your center coordinates
            zoom: 12
          });

           //Add a marker (example)
           new google.maps.Marker({
             position: {lat: 10.7476, lng: 124.8596},
             map: map,
             title: 'Your Location'
           });
        }
      </script>
    </head>
    <body>
      <div id='map'></div>
    </body>
    </html>";

            this.webBrowser1.DocumentText = html; // Assuming webBrowser1 is your WebBrowser control
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
