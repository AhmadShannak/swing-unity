using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stick {
  public class Web : MonoBehaviour {
    public WebProperties webProperties;
    LineRenderer lineRenderer;


    public void SetWeb(WebProperties webProperties) {
      this.webProperties = webProperties;
      lineRenderer = this.GetComponent<LineRenderer>();
      lineRenderer.material = webProperties.webMaterial;
    }

    public void ShootWeb(Vector3 startPos,  Vector3 endPos) {
      if (webProperties != null) {
        Vector3[] vector3 = {startPos, endPos}; 
        lineRenderer.SetPositions(vector3);
      }
    }
  }
}
