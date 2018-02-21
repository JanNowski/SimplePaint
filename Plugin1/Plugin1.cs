using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginStub;
using System.Drawing;

namespace Plugin1
{
    public class Plugin1 : IPlugin
    {
        #region IPlugin Members

        public string Name
        {
            get
            {
                return "Black&White";
            }
        }

        public Bitmap Do(Bitmap bmp)
        {
            int rgb;
            Color c;

            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                {
                    c = bmp.GetPixel(x, y);
                    rgb = (int)((c.R + c.G + c.B) / 3);
                    bmp.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                }
            return bmp;
        }

        #endregion
    }
}
