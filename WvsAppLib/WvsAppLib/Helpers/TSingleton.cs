using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WvsAppLib.Helpers
{
    public abstract class TSingleton<T>
    {
        private static volatile T instance;
        private static object syncRoot = new Object();

        private T() { }

        /// <summary>
        /// Gets an instance of the Login Server.
        /// </summary>
        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new T();
                    }
                }

                return instance;
            }
        }
    }
}
