namespace GenderVoiceSpecification
{
    partial class frmMain
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnPause_Play = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(107, 341);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Record";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(373, 341);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(94, 23);
            this.btnResult.TabIndex = 0;
            this.btnResult.Text = "Analyze Result";
            this.btnResult.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(483, 343);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 1;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(26, 341);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open file";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnPause_Play
            // 
            this.btnPause_Play.Enabled = false;
            this.btnPause_Play.Image = global::GenderVoiceSpecification.Properties.Resources.designbtn1;
            this.btnPause_Play.Location = new System.Drawing.Point(251, 323);
            this.btnPause_Play.Name = "btnPause_Play";
            this.btnPause_Play.Size = new System.Drawing.Size(40, 40);
            this.btnPause_Play.TabIndex = 2;
            this.btnPause_Play.UseVisualStyleBackColor = true;
            this.btnPause_Play.Click += new System.EventHandler(this.btnPause_Play_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Image = global::GenderVoiceSpecification.Properties.Resources.stopbtn;
            this.btnStop.Location = new System.Drawing.Point(297, 323);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(40, 40);
            this.btnStop.TabIndex = 0;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 381);
            this.Controls.Add(this.btnPause_Play);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gender Voice Specification";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnPause_Play;
    }
}

