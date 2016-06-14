using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Net.Mime;



namespace FileExtractionSystem.Extraction_Logic_Layer
{
    public delegate void Extraction_Operation_downloader(int progress, string speed, string percentage, string download);
    class Extraction_Operation
    {

        public event Extraction_Operation_downloader extopStatusEvent;
        Extraction_Robot eRForm;
        const Int32 bufferSize = 128;
        Stopwatch sw = new Stopwatch();
        public async Task GetResponseAsync(string inputFileUrl, string fileToBeSavedPath)
        {
            String line;
            string fileID = string.Empty;
            string requestedUrl = string.Empty;
            try
            {

                //Reading the input file using fileStream and streamReader
                using (var fileStream = File.OpenRead(inputFileUrl))
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, bufferSize))
                {

                    while ((line = streamReader.ReadLine()) != null)
                    {
                        int index = line.IndexOf(',');
                        if (index > 0)
                        {
                            fileID = line.Substring(0, index);
                            requestedUrl = line.Substring(index + 1);
                        }
                        using (WebClient Client = new WebClient())
                        {
                            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                            //Checking whether requested url has pdf file or not

                            Client.OpenRead(new Uri(requestedUrl));
                            string header_contentType = Client.ResponseHeaders["content-Type"];
                            if (header_contentType == "application/pdf")
                            {

                                // The variable that will be holding the url address (making sure it starts with http://)
                                Uri URL = requestedUrl.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ? new Uri(requestedUrl) : new Uri("http://" + requestedUrl);

                                // Start the stopwatch which we will be using to calculate the download speed
                                sw.Start();

                                await Client.DownloadFileTaskAsync(new Uri(requestedUrl), fileToBeSavedPath + "\\" + fileID + ".pdf");
                                while (Client.IsBusy)
                                {
                                    // run some stuff like checking download progress etc
                                }
                            }

                        }

                    }
                    // Process line

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to download File: " + fileID + ".pdf");
            }




        }


        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Calculate download speed and output it to labelSpeed.
            string speed = string.Format("{0} kb/s", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00"));

            // Update the progressbar percentage only when the value is not the same.


            // Show the percentage on our label.
            string percentage = e.ProgressPercentage.ToString() + "%";

            // Update the label with how much data have been downloaded so far and the total size of the file we are currently downloading
            string download = string.Format("{0} MB's / {1} MB's",
               (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
                (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));
            extopStatusEvent(e.ProgressPercentage, speed, percentage, download);

            
        }

        // The event that will trigger when the WebClient is completed
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            // Reset the stopwatch.
            sw.Reset();

            if (e.Cancelled == true)
            {
                //  MessageBox.Show("Download has been canceled.");
            }
            else
            {
                // MessageBox.Show("Download completed!");
            }

        }
    }
}
