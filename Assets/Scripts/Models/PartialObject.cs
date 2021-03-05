using UnityEngine;
using System;
using System.Collections;
using MicroscopeNamespace.Interfaces;
using System.Collections.Generic;
using MicroscopeNamespace.Models;

namespace MicroscopeNamespace.Model
{
  public class PartialObject: IConfigurable
  {
    public bool onSelect;
    public string name;
    public List<ParamType> Params;
    
    public void OnParameterChange(ParamType param)
    {
      // todo change state of partial object
    }
  }
}