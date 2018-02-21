
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint
{

  public enum BrushToolType
  {
    Eraser,
    FreeBrush
  }

  public enum DrawMode
  {
    Outline,
    Filled,
    Mixed,
    MixedWithSolidOutline
  }

  public enum BrushType
  {
    SolidBrush,
    TextureBrush,
    GradiantBrush,
    HatchBrush
  }
}