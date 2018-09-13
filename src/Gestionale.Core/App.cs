using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionale.Core
{

    public class App
    {
        private static object _sync = new object();

        private static App _app;

        private App()
        {

        }

        public static App GetInstance()
        {
            if (_app == null)
            {
                lock (_sync)
                {
                    if (_app == null)
                    {
                        _app = new App();
                    }
                }
            }

            return _app;
        }
    }
}
