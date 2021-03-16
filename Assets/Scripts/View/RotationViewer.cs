using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using MicroscopeNamespace.Events;

namespace MicroscopeNamespace.View
{
  public class RotationViewer : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
  {
    GlobalEventManager globalEventManager;
    public Transform rotator;
    public GameObject target;
    float factor = 0.1f;
    void Start()
    {
      globalEventManager = GlobalEventManager.GetInstance();
      Debug.Log("Start");
    }
    public void OnBeginDrag(PointerEventData e)
    {
      Debug.Log("Start Dragging");
      // test event
      // globalEventManager.TriggerEvent("test", new StringArg("arg!!!"));
    }
    public void OnDrag(PointerEventData e)
    {
      // Debug.Log(e);
      rotator.Rotate(new Vector3(0, e.delta.x * factor, 0));
    }
    public void OnEndDrag(PointerEventData e)
    {
      Debug.Log("End Dragging");
    }
  }
}