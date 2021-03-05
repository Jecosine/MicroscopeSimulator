using System;
using MicroscopeNamespace.Events;

namespace MicroscopeNamespace.Interfaces
{
  public interface IViewPort
  {
    void ZoomScope(FloatArg floatArg);
    void DistanceChange(FloatArg floatArg);
    void IndensityChange(FloatArg floatArg);
  }
}