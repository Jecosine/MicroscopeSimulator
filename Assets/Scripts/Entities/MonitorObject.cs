using System.Reflection;
using System.Security.AccessControl;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;
namespace MicroscopeNamespace.Entities
{
  public class MonitorObject : MonoBehavior
  {
    public Image instance;
    public GlobalEventManager globalEventManager;
    public float indensity;
    public float offsetX;
    public float offsetY;
    public float zoomLevel;
    public void BrightnessAdjustment(float delta)
    {
      // TODO adjust brightness
      indensity += delta; // TODO check boundary
    }
    public void ZoomImage(float delta)
    {
      // TODO zoom image in specified zoom level
      zoomLevel += delta;
    }
    public void BlurAdjustment()
    {
      // TODO get current percise range
      // upper bound / lower bound / current height
      float currentHeight, upperBound, lowerBound, factor = 0.0f;
      float currentLevel = (currentHeight > upperBound) ? (currentHeight - upperBound) * factor : (currentHeight < lowerBound) ? (lowerBound - currentHeight) * factor : 0;

    }
    void Start()
    {

    }
    void Update()
    {

    }
  }
}