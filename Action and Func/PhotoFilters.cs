﻿namespace Action_and_Func
{
    public class PhotoFilters
    {
        internal void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Applying brightness");
        }

        internal void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Applying contrast");
        }

        internal void Resize(Photo photo)
        {
            Console.WriteLine("Resizing the Photo");
        }
    }
}