using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;

namespace MicroscopeNamespace.Events
{
  public class IntArg : EventArgs
  {
    public int value;
    public IntArg(int value)
    {
      this.value = value;
    }

  }
  public class FloatArg : EventArgs
  {
    public float value;
    public FloatArg(float value)
    {
      this.value = value;
    }
  }
  public class StringArg : EventArgs
  {
    public string value;
    public StringArg(string value)
    {
      this.value = value;
    }
  }
  public class CustomArg<T> : EventArgs
  {
    public T value;
    public CustomArg(T value)
    {
      this.value = value;
    }
  }
}