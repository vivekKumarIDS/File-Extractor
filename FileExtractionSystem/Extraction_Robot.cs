using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileExtractionSystem.Extraction_Logic_Layer;
using System.Configuration;

namespace FileExtractionSystem
{
    public partial class Extraction_Robot : Form
    {
        Extraction_Operation extOp;
        public Extraction_Robot()
        {
            extOp = new Extraction_Operation();
            InitializeComponent();
            extOp.extopStatusEvent += new Extraction_Operation_downloader(extOp_extopStatusEvent);
        }
        void extOp_extopStatusEvent(int progress,string speed,string percentage,string download)
        {
            progressBarDownload.Value = progress;        // Setting ProgreeBar Value
            labelSpeed.Text = speed;                     // Displaying Speed
            labelPerc.Text = percentage;                 // Displaying Percentage
            labelDownloaded.Text = download;             // Displaying Percentage

            // To refresh the GUI simultaneously as the background process progresses
            Application.DoEvents();
        }

        private void Extraction_Robot_Load(object sender, EventArgs e)
        {
            //Get Configuration Detail to display
            GetConfigurationDetail();

        }


        void GetConfigurationDetail()
        {
          txtDownDirecPath.Text = System.Configuration.ConfigurationManager.AppSettings["DownloadDirectory"];
          txtInputFilePath.Text= System.Configuration.ConfigurationManager.AppSettings["InputFile"];
          txtStatusFilePath.Text = System.Configuration.ConfigurationManager.AppSettings["StatusFile"];
        }

        private async  void btn_Extraction_Click(object sender, EventArgs e)
        {
            string fileToBeSavedPath=    System.Configuration.ConfigurationManager.AppSettings["DownloadDirectory"];
            string inputFileUrl = System.Configuration.ConfigurationManager.AppSettings["InputFile"];
            progressBarDownload.Visible = true;
           // Calling Extraction and Dowload method.Sending 2 arguments input file url and the pathof the download directory
            await extOp.GetResponseAsync(inputFileUrl, fileToBeSavedPath);

            if (labelPerc.Text == "100%")
           {
               MessageBox.Show("Extraction Complete");
               progressBarDownload.Value = 0;                       // Setting ProgreeBar Value
               labelSpeed.Text = string.Empty;                     // Empty label
               labelPerc.Text = string.Empty;                      //  Empty label
               labelDownloaded.Text = string.Empty;                 //  Empty label
               progressBarDownload.Visible = false;                 // Hide progress bar
           }
            
        }

       

      
    }
}
