using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOD_V2.API
{
    public static class ServiceLocator
    {
        public static MemeService memeService = new MemeService();
    }
}