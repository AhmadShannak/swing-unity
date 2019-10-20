using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stick {
  public class Controller : MonoBehaviour {
    [SerializeField]
    Player player;

    void Update() {
      if (Input.GetMouseButton(0)) {
        player.UseFuel();
      } else {
        player.ChargeFuel();
      }
    }
  }
}