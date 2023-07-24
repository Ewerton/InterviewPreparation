using System;
using System.Collections.Generic;
using System.Linq;

namespace Events_and_Delegates_2
{
    /// <summary>
    /// Imagine an application to apply filter in photos
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", filterHandler);

            Console.ReadLine();
        }


        // A new filter, not release in the PhotoFilters class but, it can be passed to the PhotoProcessor to be executed by it.
        // It provides extensibility... I mean i can provide new filters without changing the PhotoProcessor or PhotoFilters classes
        public static void RemoveRedEyeFilter(Photo p)
        {
            Console.WriteLine("Removing red eyes...");
        }
    }
}