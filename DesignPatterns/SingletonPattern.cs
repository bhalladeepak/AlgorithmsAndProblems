using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public sealed class SingletonPattern
    {

        /*
        Explanation of the following code:
        1.	This implementation is thread-safe.
        2.	In the following code, the thread is locked on a shared object and checks whether an instance has been created or not.
        3.	This takes care of the memory barrier issue and ensures that only one thread will create an instance.
        4.	For example: Since only one thread can be in that part of the code at a time, by the time the second thread enters it, 
            the first thread will have created the instance, so the expression will evaluate to false.
        5.	The biggest problem with this is performance; performance suffers since a lock is required every time an instance is requested.
        6.	In the following code, the thread is locked on a shared object and checks whether an instance has been created or not with double checking.
*/

        SingletonPattern()
        {

        }

        private static  readonly object padLock = new object();
        private static SingletonPattern instance = null;

        public static SingletonPattern Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padLock)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonPattern();
                        }
                    }
                }

                return instance;
            }
        }
    }
}
