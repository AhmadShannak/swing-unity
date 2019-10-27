using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stick {
  public class WebProperties  {
#region Properties
    public int webLength;
    public string materialPath;
#endregion

    /// <summary>Use this constructor to create a new type of webs.</summary>
    public WebProperties(string path, int length) {
      this.materialPath = $"WebMaterials/{path}";
      webLength = length;
    }
  }
}
