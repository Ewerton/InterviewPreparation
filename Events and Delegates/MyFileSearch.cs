using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegates
{
    public class MyFileSearch
    {
        // By defining a delegate, you are saying to the user of your class,
        // "Please feel free to assign, any method that matches this signature,
        // it will be called each time my delegate is called"
        public delegate void SearchMethod(string search);
        //public SearchMethod SendData = null; // USando delegates puro, este método fica exposto e pode receber nulo, causando um erro.
        public event SearchMethod Publisher = null;

        public void Search(string dir)
        {
            try
            {
                foreach (var d in Directory.GetDirectories(dir))
                {
                    foreach (var f in Directory.GetFiles(d))
                    {
                        Publisher(f);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
