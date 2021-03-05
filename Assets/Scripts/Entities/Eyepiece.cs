using UnityEngine;
using MicroscopeNamespace.Model;
using System.Collections.Generic;
using System.Collections;

namespace MicroscopeNamespace.Entities
{
  public class Eyepiece : PartialObject
  {
    public string name = "eyepiece";
    public bool onSelect = false;
    public List<ParamType> Params = new ArrayList<ParamType>();
    void InitComponent()
    {
      // todo switch 3 scales
      
    }
  }
}