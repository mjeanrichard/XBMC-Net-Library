using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Details
{
    public partial class Media
    {
        public string Artists
        {
            get { return string.Join(", ", Artist); }
        }
    }
}
