using NAudio.Wave;
using System;
using System.IO;
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
        //private WaveFileReader _wave;

        // For Mp3 input
        private BlockAlignReductionStream _stream;

        private DirectSoundOut _output;

        private void ButtonOpenAudioFile_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog { Filter = "MP3 File (*.mp3;*.wav)|*.mp3;*.wav" };
            if (open.ShowDialog() != DialogResult.OK)
                return;

            DisposeAudio();

            if (open.FileName.EndsWith(".mp3"))
            {
                // Input logic for mp3
                var pcm = WaveFormatConversionStream.CreatePcmStream(new Mp3FileReader(open.FileName));
                _stream = new BlockAlignReductionStream(pcm);
            }

            else if (open.FileName.EndsWith(".wav"))
            {
                var pcm = new WaveChannel32(new WaveFileReader(open.FileName));
                _stream = new BlockAlignReductionStream(pcm);
            }

            else
                throw new InvalidOperationException("Not a correct audio file type.");

            // Output logic
            _output = new DirectSoundOut();
            _output.Init(_stream);
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

        private void DisposeAudio()
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
            //DisposeWave();
            DisposeAudio();
        }

        private void ButtonConvertMp3ToWav_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog { Filter = "MP3 File (*.mp3)|*.mp3" };
            if (open.ShowDialog() != DialogResult.OK)
                return;

            var fileName = Path.GetFileNameWithoutExtension(open.SafeFileName);

            var save = new SaveFileDialog { Filter = "WAV File (*.wav)|*.wav", FileName = fileName };
            if (save.ShowDialog() != DialogResult.OK)
                return;

            using (var mp3 = new Mp3FileReader(open.FileName))
            {
                using (var pcm = WaveFormatConversionStream.CreatePcmStream(mp3))
                {
                    WaveFileWriter.CreateWaveFile(save.FileName, pcm);
                }
            }
        }
    }
}
