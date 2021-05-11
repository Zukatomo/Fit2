using AForge.Video.DirectShow;
using Fit2.Database;
using Fit2.Helpers;
using Fit2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fit2.Views
{
    public partial class NewClient : UserControl
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        Bitmap pic;
        bool update = false;
        Client upClient = null;
        Font ff;
        public NewClient()
        {
            InitializeComponent();
            errors.Text = "";
            pic = null;
            retakePic.Hide();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if(filterInfoCollection.Count > 0)
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();
            }
            InitCustomFont("");
            historyButton.Hide();
        }

        public NewClient(Client client)
        {
            InitializeComponent();
            errors.Text = "";
            pic = PictureManipulation.ResizeImage(PictureManipulation.ByteToImage(client.image), 400, 300);
            clientPicture.Image = pic;
            takePic.Hide();
            retakePic.Show();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (filterInfoCollection.Count > 0)
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            }
            clientName.Text = client.name;
            clientPhone.Text = client.phone;
            clientEmail.Text = client.email;
            clientCnp.Text = client.cnp;
            clientAddress.Text = client.address;
            clientNotes.Text = client.notes;
            update = true;
            upClient = client;
            InitCustomFont(client.barcode.ToString());
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            clientPicture.Image = PictureManipulation.ResizeImage((Bitmap)eventArgs.Frame.Clone(), 400, 300);
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            if (videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
            }
        }

        private void takePic_Click(object sender, EventArgs e)
        {
            pic = (Bitmap)clientPicture.Image;
            videoCaptureDevice.Stop();
            takePic.Hide();
            retakePic.Show();
        }

        private void retakePic_Click(object sender, EventArgs e)
        {
            videoCaptureDevice.Start();
            takePic.Show();
            retakePic.Hide();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string err = "";
            string name = clientName.Text.Trim().ToUpper();
            string phone = clientPhone.Text.Trim();
            string email = clientEmail.Text.Trim();
            string cnp = clientCnp.Text.Trim();
            string address = clientAddress.Text.Trim().ToUpper();
            string notes = clientNotes.Text.Trim();
            if (name.Length < 1)
            {
                err += "Please enter a client name!\n";
            }
            if (!Regex.Match(phone, @"^([0-9]{10})$").Success)
            {
                err += "Please enter a valid phone number!\n";
            }
            try
            {
                MailAddress mail = new MailAddress(email);
            }
            catch (Exception ex)
            {
                err += "Please enter a valid email!\n";
            }
            if (address.Length < 2)
            {
                err += "Please enter a valid address!\n";
            }
            if (!Regex.Match(cnp, @"^([0-9]+)$").Success)
            {
                err += "Please enter a valid CNP!\n";
            }
            if (pic == null)
            {
                err += "Please take a picture before saving!\n";
            }
            if (DBQ.Instance.ClientAlreadyExists(cnp))
            {
                err += "This CNP is already in use!\n";
            }
            errors.Text = err;
            if(err.Length == 0)
            {
                Client client = new Client(name, phone, email, cnp, address, notes, PictureManipulation.ImageToByte(pic));
                if (update)
                {
                    client.Id = upClient.Id;
                    DBQ.Instance.Update<Client>(client, upClient.Id);
                }
                else
                {
                    client = DBQ.Instance.Insert<Client>(client);
                }
                InitCustomFont(client.barcode.ToString());
                historyButton.Show();
                AwesomeFormControllMagicWizzard.AwesomeNextPageMagicFunction("ClientTickets", client);

            }
        }

        private void InitCustomFont(string text)
        {
            QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
            QRCoder.QRCodeData data= qr.CreateQrCode(text, QRCoder.QRCodeGenerator.ECCLevel.Q);
            QRCoder.QRCode code = new QRCoder.QRCode(data);
            qrBox.Image = code.GetGraphic(10);
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            AwesomeFormControllMagicWizzard.AwesomeNextPageMagicFunction("ClientHistory", upClient);
        }
    }
}
