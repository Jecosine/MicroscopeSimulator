using System.Collections;
using MicroscopeNamespace.Models;

namespace MicroscopeNamespace.Interfaces
{
  public interface IConfigurable
  {
    void Init();
    void OnParameterChange(ParamType param);
  }
}