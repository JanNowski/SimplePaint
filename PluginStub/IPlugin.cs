using System.Drawing;

namespace PluginStub
{
    public interface IPlugin
    {
        string Name { get; }
        Bitmap Do(Bitmap bmp);
    }
}
