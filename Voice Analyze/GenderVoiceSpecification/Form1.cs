using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenderVoiceSpecification
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private NAudio.Wave.WaveFileReader wavReader = null;
        private NAudio.Wave.DirectSoundOut directSoundOut = null;

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnOpenFile.Enabled = false;
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Audio file (*.wav;*.mp3)|*.wav;*.mp3";
            if (openFile.ShowDialog() != DialogResult.OK)
            {
                btnStart.Enabled = true;
                btnOpenFile.Enabled = true;
                return;
            }
            DisposeWave();
            if (openFile.FileName.EndsWith(".mp3"))
            {

            }
            wavReader = new NAudio.Wave.WaveFileReader(openFile.FileName);
            directSoundOut = new NAudio.Wave.DirectSoundOut();
            directSoundOut.Init(new NAudio.Wave.WaveChannel32(wavReader));
            directSoundOut.Play();
            btnPause_Play.Enabled = true;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DisposeWave();
            
            btnStart.Enabled = true;
            btnPause_Play.Enabled = false;
            btnStop.Enabled = false;
        }

        private void btnPause_Play_Click(object sender, EventArgs e)
        {
            if (directSoundOut != null)
            {
                if (directSoundOut.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                    directSoundOut.Pause();
                else if (directSoundOut.PlaybackState == NAudio.Wave.PlaybackState.Paused)
                    directSoundOut.Play();
            }
        }
        
        private void DisposeWave()
        {
            if (directSoundOut != null)
            {
                directSoundOut.Stop();
                directSoundOut.Dispose();
                directSoundOut = null;
            }
            if (wavReader != null)
            {
                wavReader.Dispose();
                wavReader = null;
            }

            btnOpenFile.Enabled = true;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeWave();
        }
    }
}
