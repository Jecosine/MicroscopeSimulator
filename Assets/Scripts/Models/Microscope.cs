using System;
using System.Collections;
using System.Security;
using MicroscopeNamespace.Enums;

namespace MicroscopeNamespace.Models
{
  public class Microscope : MicroscopeNamespace.Interfaces.IMicroscope
  {
    // fields
    public Slide currentSlide;
    public float indensity;
    public float offsetX;
    public float offsetY;
    public MicroscopeNamespace.Enums.ObjectGlassEnumeration objectGlassType;
    public MicroscopeNamespace.Enums.EyepieceEnumeration eyepieceType;
    public float zoomScope;

    public float distance;

    // define step of coarse and fine adjustment
    float coarse;
    float fine;
    public void CalculateZoom()
    {
      zoomScope = (int)objectGlassType * (int)eyepieceType;
      // todo emit zoom change event
    }
    public void CalculateDistance()
    {
      distance = coarse + fine;
      // todo emit distance change event
    }
    
    public void SwitchSlide()
    {
      // todo emit switch slide event
    }
    public void IndensityUp(float delta) {
      // todo emit indensity change event
    }
    public void VerticalMove(float delta) {
      // todo move
    }
    public void SwitchObjectGlass(MicroscopeNamespace.Enums.ObjectGlassEnumeration objectGlass)
    {

    }
    public void SwitchEyepieceGlass(MicroscopeNamespace.Enums.EyepieceEnumeration eyepieceGlass)
    {

    }
  }
}