using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stick {
  public class WebProperties  {
#region Properties
    public int webLength;
    public Material webMaterial;
#endregion

    /// <summary>Use this constructor to create a new type of webs.</summary>
    public WebProperties(string materialPath, int length) {
      webMaterial = Resources.Load<Material>($"WebMaterials/{materialPath}");
      webLength = length;
    }
  }
}
