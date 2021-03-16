using UnityEngine;
using System;
using System.Collections.Generic;
using MicroscopeNamespace.Models;

namespace MicroscopeNamespace.Utils
{
  [Serializable]
  public class MenuManager : MonoBehaviour
  {
    public Transform uiParent;
    public Dictionary<string, GameObject> optionTemplateDictionary;
    private string currentMenu = "";
    public void SwitchMenu(string name)
    {
      GameObject tmpObj;
      if (currentMenu == "")
      {
        currentMenu = name;
      }
      else
      {
        // close current
        optionTemplateDictionary.TryGetValue(currentMenu, out tmpObj);
        if (tmpObj != null)
        {
          tmpObj.SetActive(false);
        }
      }
      // show new
      optionTemplateDictionary.TryGetValue(name, out tmpObj);
      if (tmpObj == null)
      {
        Debug.Log("Opening a null menu");
      }
      else
      {
        tmpObj.SetActive(true);
      }
    }
  }
  
}