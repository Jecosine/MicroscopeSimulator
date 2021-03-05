namespace MicroscopeNamespace.Models
{
  public class ParamType
  {
    public string paramName;
  }
  public class IntParam : ParamType
  {
    public int value;
    public int minValue;
    public int maxValue;
    public int step;
  }
  public class FloatParam : ParamType
  {
    public float value;
    public float minValue;
    public float maxValue;
    public float step;
  }
  public class stringParam : ParamType
  {
    public string value;
    public string minValue;
    public string maxValue;
    public string step;
  }
}