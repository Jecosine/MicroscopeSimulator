using System;
using System.Collections;
using System.Text;
// using MicroscopeNamespace.Enums;

namespace MicroscopeNamespace.Interfaces
{
  public interface IMicroscope
  {
    
    // methods
    void CalculateZoom();
    void CalculateDistance();

    void SwitchSlide();
    void IndensityUp(float delta);    
    void VerticalMove(float delta);
    // switch glass
    void SwitchObjectGlass(MicroscopeNamespace.Enums.ObjectGlassEnumeration objectGlass);
    void SwitchEyepieceGlass(MicroscopeNamespace.Enums.EyepieceEnumeration eyepieceGlass);
    
  }
}