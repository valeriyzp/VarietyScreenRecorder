using ScreenRecorderLib;
using System;
using System.Diagnostics;

namespace VarietyScreenRecorder.ExtraClass
{
    public class VideoManager
    {
        private Stopwatch VideoRecordingTime;

        private static RecorderOptions VideoRecorderOptions = new RecorderOptions
        {
            AudioOptions = new AudioOptions
            {
                Bitrate = AudioBitrate.bitrate_128kbps,
                Channels = AudioChannels.Stereo,
                IsAudioEnabled = true
            }
        };

        private Recorder VideoRecorder;

        public VideoManager()
        {
            VideoRecordingTime = new Stopwatch();
            VideoRecorder = Recorder.CreateRecorder(VideoRecorderOptions);
        }

        public void StartRecording(string Path, string FileName)
        {
            VideoRecordingTime.Reset();

            VideoRecorder.Record(Path + "\\" + FileName + ".mp4");

            VideoRecordingTime.Start();
        }

        public void StopRecording()
        {
            VideoRecorder.Stop();

            VideoRecordingTime.Stop();
        }

        public string GetRecordingTime()
        {
            TimeSpan RecordingTime = VideoRecordingTime.Elapsed;
            string Time = String.Format("{0:00}:{1:00}:{2:00}", RecordingTime.Hours, RecordingTime.Minutes, RecordingTime.Seconds);

            return Time;
        }
    }
}
