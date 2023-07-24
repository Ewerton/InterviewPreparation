using System;
using System.Collections.Generic;
using System.Linq;

namespace Events
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var video = new Video() { Title = "Video1" };
            var videoEncoder = new VideoEncoder();

            // Same this, but this time the event on the VideoEncoder class is fired using the EventHandler<> and not a custom event handler created by hand.
            videoEncoder.VideoEncoding += VideoEncoder_VideoEncoding;

            // Lets say we need to notify someone by email when a encoding process finishes...
            // We can "subscribe" to the VideoEncoded event to be notified when the encoding process finishes.
            videoEncoder.VideoEncoded += VideoEncodedHandler;

            videoEncoder.Encode(video);

            Console.WriteLine("");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void VideoEncoder_VideoEncoding(object? sender, VideoEncodedEventArgs e)
        {
            // Some useful thing to do when a video is being encoded...
        }

        private static void VideoEncodedHandler(object source, VideoEncodedEventArgs args)
        {
            MailService m = new MailService();
            m.SendEmail("The video with the title:" + args.Video.Title + " was encoded!");

            // Later it also needed to notify both by email and by Sms... 
            // As we develop using Events, we dont need to change the videoEncoder.Encode(video); method to fire this notification
            // It now can be Done by the client, I mean, the subscriber of the VideoEncoded event!

            SmsService sms = new SmsService();
            sms.SendSms("The video with the title:" + args.Video.Title + " was encoded!");
        }
      
    }
}