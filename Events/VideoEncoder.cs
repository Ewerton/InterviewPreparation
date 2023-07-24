namespace Events
{

    public class VideoEncoder
    {
        // Steps to create an Event that will be fired from VideoEncode when the encoding process finishes.
        // Step 1- Define a delegate
        // Step 2 - Define an Event
        // Step 3 - Raise the event


        // Step 1 - Declaring a delegate that holds a pointer to a function with the below signature (the name of the method pointed doesnt matter)
        public delegate void VideoEncodedEventHandler(object source, VideoEncodedEventArgs args);

        // Step 2 - Declaring an Event, this is the Event where subscriber will subscribe to. 
        public event VideoEncodedEventHandler VideoEncoded;


        // EXTRA: There is a shortcut to create Events... You dont net to create your own delegate,
        // you can use the EventHandler class from the .Net framework, like this
        public event EventHandler<VideoEncodedEventArgs> VideoEncoding;

        public void Encode(Video video)
        {
            // Event using the EventHandler<>() shortcut class.
            OnVideoEncoding(video);
           
            Thread.Sleep(3000);

            // Event using the manually created delegate.
            // Calling a method which tells that de encoding is finished, I mean, a method responsible to notify the subscribers
            OnVideoEncoded(video);
        }

        public virtual void OnVideoEncoded(Video video)
        {
            Console.WriteLine("Encoding finished!");
            if (VideoEncoded != null) // If there is someone subscribed to this event...
                VideoEncoded(this, new VideoEncodedEventArgs() { Video = video }); // Raises the event!

        }

        public virtual void OnVideoEncoding(Video video)
        {
            Console.WriteLine("Encoding video...");

            if (VideoEncoding != null)
                VideoEncoding(this, new VideoEncodedEventArgs { Video = video });
        }
    }
}