using AForge.Video.DirectShow;
using Fit2.Database;
using Fit2.Helpers;
using Fit2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using ZXing;

namespace Fit2.Views
{
    public partial class ReadBarcode : UserControl
    {

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        Bitmap map;

        Timer timer;
        public ReadBarcode()
        {
            InitializeComponent();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (filterInfoCollection.Count > 0)
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();
            }
            timer = new Timer();
            timer.Start();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(map);
            if (result != null)
            {
                Client client = DBQ.Instance.ClientBarcode(result.ToString());
                //AwesomeFormControllMagicWizzard.AwesomeNextPageMagicFunction("ClientTickets", client);
                //videoCaptureDevice.Stop();
                videoCaptureDevice.NewFrame += null;
                flowLayoutPanel1.Invoke(new MethodInvoker(delegate ()
                {
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.Controls.Add(new LittleUser(client));
                }));
            }
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            map = PictureManipulation.ResizeImage((Bitmap)eventArgs.Frame.Clone(), 300, 150);
            
            pictureBox1.Image = map;
        }
    }
}
