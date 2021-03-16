using UnityEngine;
using System;
using System.Collections;
using MicroscopeNamespace.Interfaces;
using System.Collections.Generic;
using MicroscopeNamespace.Models;

namespace MicroscopeNamespace.Models
{
  public abstract class PartialObject
  {
    public bool onSelect;
    public string name;
    public ListParam<Glass> Params;
    public abstract void Init();
    public abstract void OnParameterChange(ParamType param);
  }
}