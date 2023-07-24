namespace Events
{
    /// <summary>
    /// A class to represent the parameters when a Video was Encoded
    /// </summary>
    public class VideoEncodedEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}