using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using MediaToolkit;
using System.Runtime.InteropServices;
using System.Text;
using System.Reflection;
using NReco.VideoInfo;
using FFmpegFluent;
using Microsoft.WindowsAPICodePack.Shell;
using static MediaToolkit.Model.Metadata;


//source: https://stackoverflow.com/questions/10175630/determining-file-size-in-vb-net
//https://stackoverflow.com/questions/41204567/c-sharp-converting-image-audio-and-video-to-and-from-byte-array

namespace Video_Check
{
    public class VidChecker
    {

        public static void Main(string[] args)
        {
            string path = @"Videos/testVid.mp4";
            VidChecker vc = new VidChecker();
            vc.GetFileSize(path);
            /**
            int size = resourcesPath.Length;
            Console.WriteLine("File Size in Bytes: " + size);
            long length = new System.IO.FileInfo(@"Videos/testVid.mp4").Length;
            Console.WriteLine("File size: *** " + length);

            VidChecker vc = new VidChecker();
            */
        }

        public long GetFileSize(string filePath)
        {
            long length;
            //gets the size of the video file in bytes
            length = new System.IO.FileInfo(@"Videos/testVid.mp4").Length;
            Console.WriteLine("File size: *** " + length);
            //checksto make sure video is in the right range of byte size
            //testing different ranges for the ideal byte size range
            if(length<2000000)
            {
                Console.WriteLine("This video file is too small.");
            }
            else if (length>240000000)
            {
                Console.WriteLine("This video file is too large.");
            }
            else
            {
                Console.WriteLine("This video file is in the correct range");
            }
            return length;

        }

        public string getFrameRatePerSecond(string filepath)
        {
            ShellFile shellFile = ShellFile.FromFilePath(filepath);
            return (shellFile.Properties.System.Video.FrameRate.Value / 1000).ToString();
        }

        public byte[] Audio2Bytes(Audio audAudio2Convert)
        {
            var bytes = default(byte[]);

            using (var memstream = new MemoryStream())
            {
                StreamReader reader = new StreamReader(memstream);
                var buffer = new byte[512];
                var bytesRead = default(int);
                while ((bytesRead = reader.BaseStream.Read(buffer, 0, buffer.Length)) > 0)
                    memstream.Write(buffer, 0, bytesRead);
                bytes = memstream.ToArray();
                return bytes;
            }
        }


    }
 }
