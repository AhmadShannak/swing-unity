using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Stick {
  public class Camera : MonoBehaviour {
    [SerializeField]
    Transform target;
    [SerializeField]
    float smoothSpeed = 0.125f;
    [SerializeField]
    Vector3 offset;

    Vector3 desiredPos, smoothedPos;

    void FixedUpdate() {
      desiredPos = target.position + offset;
      smoothedPos = Vector3.Lerp(this.transform.position, desiredPos, smoothSpeed * Time.timeScale);
      this.transform.position = smoothedPos;
    }
  }
}
