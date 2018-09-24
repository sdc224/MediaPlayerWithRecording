using NAudio.Wave;
using System;
using System.Windows.Forms;

namespace MediaPlayerWithRecording
{
    public partial class FirstWindow : Form
    {
        public FirstWindow()
        {
            InitializeComponent();
        }

        // For Wave File input
        private WaveFileReader _wave;

        // For Mp3 input
        private BlockAlignReductionStream _stream;

        private DirectSoundOut _output;

        private void ButtonOpenWavFile_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog { Filter = "Wave File (*.wav)|*.wav" };
            if (open.ShowDialog() != DialogResult.OK)
                return;
            DisposeWave();

            // Input logic for WAV
            _wave = new WaveFileReader(open.FileName);

            // Output logic
            _output = new DirectSoundOut();
            _output.Init(new WaveChannel32(_wave));
            _output.Play();

            ButtonPlayOrPause.Enabled = true;
        }

        private void ButtonPlayOrPause_Click(object sender, EventArgs e)
        {
            if (_output == null) return;
            switch (_output.PlaybackState)
            {
                case PlaybackState.Playing:
                    _output.Pause();
                    break;

                case PlaybackState.Paused:
                    _output.Play();
                    break;

                case PlaybackState.Stopped:
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void ButtonOpenMp3File_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog { Filter = "MP3 File (*.mp3)|*.mp3" };
            if (open.ShowDialog() != DialogResult.OK)
                return;
            DisposeMp3();

            // Input logic for mp3
            var pcm = WaveFormatConversionStream.CreatePcmStream(new Mp3FileReader(open.FileName));
            _stream = new BlockAlignReductionStream(pcm);

            // Output logic
            _output = new DirectSoundOut();
            _output.Init(new WaveChannel32(_stream));
            _output.Play();

            ButtonPlayOrPauseMp3.Enabled = true;
        }

        private void DisposeWave()
        {
            if (_output == null) return;

            if (_output.PlaybackState == PlaybackState.Playing)
                _output.Stop();

            _output.Dispose();
            _output = null;

            if (_wave == null) return;

            _wave.Dispose();
            _wave = null;
        }

        private void DisposeMp3()
        {
            if (_output == null) return;

            if (_output.PlaybackState == PlaybackState.Playing)
                _output.Stop();

            _output.Dispose();
            _output = null;

            if (_stream == null) return;

            _stream.Dispose();
            _stream = null;
        }

        private void FirstWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeWave();
            DisposeMp3();
        }
    }
}
