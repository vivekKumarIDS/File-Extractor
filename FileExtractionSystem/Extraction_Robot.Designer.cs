namespace FileExtractionSystem
{
    partial class Extraction_Robot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Extraction = new System.Windows.Forms.Button();
            this.gb_configDetail = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBarDownload = new System.Windows.Forms.ProgressBar();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelPerc = new System.Windows.Forms.Label();
            this.labelDownloaded = new System.Windows.Forms.Label();
            this.lblInputFile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInputFilePath = new System.Windows.Forms.TextBox();
            this.txtStatusFilePath = new System.Windows.Forms.TextBox();
            this.txtDownDirecPath = new System.Windows.Forms.TextBox();
            this.gb_configDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Extraction
            // 
            this.btn_Extraction.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Extraction.Location = new System.Drawing.Point(0, 229);
            this.btn_Extraction.Name = "btn_Extraction";
            this.btn_Extraction.Size = new System.Drawing.Size(123, 28);
            this.btn_Extraction.TabIndex = 0;
            this.btn_Extraction.Text = "Start Extraction";
            this.btn_Extraction.UseVisualStyleBackColor = true;
            this.btn_Extraction.Click += new System.EventHandler(this.btn_Extraction_Click);
            // 
            // gb_configDetail
            // 
            this.gb_configDetail.Controls.Add(this.txtDownDirecPath);
            this.gb_configDetail.Controls.Add(this.txtStatusFilePath);
            this.gb_configDetail.Controls.Add(this.txtInputFilePath);
            this.gb_configDetail.Controls.Add(this.label2);
            this.gb_configDetail.Controls.Add(this.label1);
            this.gb_configDetail.Controls.Add(this.lblInputFile);
            this.gb_configDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_configDetail.Location = new System.Drawing.Point(0, 0);
            this.gb_configDetail.Name = "gb_configDetail";
            this.gb_configDetail.Size = new System.Drawing.Size(498, 223);
            this.gb_configDetail.TabIndex = 1;
            this.gb_configDetail.TabStop = false;
            this.gb_configDetail.Text = "Configuration Detail";
            // 
            // progressBarDownload
            // 
            this.progressBarDownload.Location = new System.Drawing.Point(3, 295);
            this.progressBarDownload.Name = "progressBarDownload";
            this.progressBarDownload.Size = new System.Drawing.Size(218, 23);
            this.progressBarDownload.TabIndex = 2;
            this.progressBarDownload.Visible = false;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(4, 342);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(0, 13);
            this.labelSpeed.TabIndex = 4;
            // 
            // labelPerc
            // 
            this.labelPerc.AutoSize = true;
            this.labelPerc.Location = new System.Drawing.Point(91, 342);
            this.labelPerc.Name = "labelPerc";
            this.labelPerc.Size = new System.Drawing.Size(0, 13);
            this.labelPerc.TabIndex = 5;
            // 
            // labelDownloaded
            // 
            this.labelDownloaded.AutoSize = true;
            this.labelDownloaded.Location = new System.Drawing.Point(185, 342);
            this.labelDownloaded.Name = "labelDownloaded";
            this.labelDownloaded.Size = new System.Drawing.Size(0, 13);
            this.labelDownloaded.TabIndex = 6;
            // 
            // lblInputFile
            // 
            this.lblInputFile.AutoSize = true;
            this.lblInputFile.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputFile.Location = new System.Drawing.Point(3, 25);
            this.lblInputFile.Name = "lblInputFile";
            this.lblInputFile.Size = new System.Drawing.Size(68, 18);
            this.lblInputFile.TabIndex = 0;
            this.lblInputFile.Text = "Input File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Download Directory";
            // 
            // txtInputFilePath
            // 
            this.txtInputFilePath.Enabled = false;
            this.txtInputFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputFilePath.Location = new System.Drawing.Point(162, 21);
            this.txtInputFilePath.Name = "txtInputFilePath";
            this.txtInputFilePath.Size = new System.Drawing.Size(282, 20);
            this.txtInputFilePath.TabIndex = 3;
            // 
            // txtStatusFilePath
            // 
            this.txtStatusFilePath.Enabled = false;
            this.txtStatusFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusFilePath.Location = new System.Drawing.Point(162, 51);
            this.txtStatusFilePath.Name = "txtStatusFilePath";
            this.txtStatusFilePath.Size = new System.Drawing.Size(282, 20);
            this.txtStatusFilePath.TabIndex = 4;
            // 
            // txtDownDirecPath
            // 
            this.txtDownDirecPath.Enabled = false;
            this.txtDownDirecPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDownDirecPath.Location = new System.Drawing.Point(162, 83);
            this.txtDownDirecPath.Name = "txtDownDirecPath";
            this.txtDownDirecPath.Size = new System.Drawing.Size(282, 20);
            this.txtDownDirecPath.TabIndex = 5;
            // 
            // Extraction_Robot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 360);
            this.Controls.Add(this.labelDownloaded);
            this.Controls.Add(this.labelPerc);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.progressBarDownload);
            this.Controls.Add(this.gb_configDetail);
            this.Controls.Add(this.btn_Extraction);
            this.Name = "Extraction_Robot";
            this.Text = "Extraction Robot";
            this.Load += new System.EventHandler(this.Extraction_Robot_Load);
            this.gb_configDetail.ResumeLayout(false);
            this.gb_configDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Extraction;
        private System.Windows.Forms.GroupBox gb_configDetail;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBarDownload;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelPerc;
        private System.Windows.Forms.Label labelDownloaded;
        private System.Windows.Forms.TextBox txtDownDirecPath;
        private System.Windows.Forms.TextBox txtStatusFilePath;
        private System.Windows.Forms.TextBox txtInputFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInputFile;

    }
}

