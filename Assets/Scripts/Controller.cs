using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stick {
  public class Controller : MonoBehaviour {
    [SerializeField]
    Player player;
    [SerializeField]
    GameObject pointer;

    Vector3 mousePos;

    void Update() {
      if (Input.GetMouseButton(0)) {
        player.UseFuel();
        SetPointer();
      } else {
        player.ChargeFuel();
        ResetPointer();
      }
    }

    void SetPointer() {
      pointer.SetActive(true);
      mousePos = UnityEngine.Camera.main.ScreenToWorldPoint(Input.mousePosition);
      pointer.transform.right = new Vector2(mousePos.x, mousePos.y);
    }

    void ResetPointer() {
      pointer.SetActive(false);
      pointer.transform.up = new Vector3(0, 0, 0);
    }
  }
}