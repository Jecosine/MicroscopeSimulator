using UnityEngine;
using MicroscopeNamespace.Models;
using MicroscopeNamespace.Interfaces;
using System.Collections.Generic;
using System.Collections;


namespace MicroscopeNamespace.Models
{
  public class Eyepiece : PartialObject, IGlass, IConfigurable
  {
    // public string name = "eyepiece";
    // public bool onSelect = false;
    // public List<ParamType> Params = new ArrayList<ParamType>();
    public override void Init()
    {
      // init params
      name = "eyepiece";
      onSelect = false;
      // todo switch 3 scales
      string[] names = {"10x"};
      int[] scales = {10};
      Params = new ListParam<Glass>();
      Params.valueList = new List<Glass>();
      GenerateGlassList(names, scales);
    }

    public void GenerateGlassList(string[] names, int[] scales)
    {
      if (names.Length != scales.Length)
      {
        return;
      }
      for (int i = 0; i < names.Length; i++)
      {
        Params.valueList.Add(new Glass(names[i], scales[i]));
      }
    }
    public override void OnParameterChange(ParamType param)
    {
      throw new System.NotImplementedException();
      
    }
  }
}