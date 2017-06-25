using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Svg2Xaml
{
  static class StrokeExtensions
  {
    internal static PenLineJoin ToPenLineJoin(this SvgStrokeLinejoin svgStroke)
    {
      switch (svgStroke)
      {
        case SvgStrokeLinejoin.Miter:
          return PenLineJoin.Miter;
        case SvgStrokeLinejoin.Round:
          return PenLineJoin.Round;
        case SvgStrokeLinejoin.Bevel:
          return PenLineJoin.Bevel;
      }

      return PenLineJoin.Miter;
    }

    internal static PenLineCap ToPenLineCap(this SvgStrokeLinecap svgCap)
    {
      switch (svgCap)
      {
        case SvgStrokeLinecap.Butt:
          return PenLineCap.Flat;
        case SvgStrokeLinecap.Round:
          return PenLineCap.Round;
        case SvgStrokeLinecap.Square:
          return PenLineCap.Square;
      }

      return PenLineCap.Flat;
    }
  }
}
