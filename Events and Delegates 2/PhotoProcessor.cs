using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegates_2
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);
        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);

            // This code is hard to change... What if the consumer wanted to create a new filter?
            // Should we implement it here, recompile and redistribute the program?
            // A best approach is to receive a delegate by parameter and execute the delegate instead
            //var filters = new PhotoFilters();
            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);
            //filters.Resize(photo);

            // This way, this code dos not know which filter will be applied, this becomes reponsibility of the client code.
            // This way a user can choose to apply just one, two or 10 filters
            filterHandler(photo);

            photo.Save();
        }

        public void Save()
        {

        }
    }
}
