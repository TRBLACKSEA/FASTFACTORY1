using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cores.Tools
{
    public static class MyImageConverter
    {
        public static byte[] ConvertToByte(Image ımage)
        {
            using (var ms = new MemoryStream())
            {
                ımage.Save(ms, ımage.RawFormat);
                return ms.ToArray();
            }
        }

    }
}
