using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stick {
  public class Player : MonoBehaviour {
    [SerializeField]
    float maxFuel = 15;
    float currentFuel;

    bool canUseFuel = true;
    public bool CanUseFuel {
      get { return canUseFuel; }
    } 

    void Awake() {
      currentFuel = maxFuel;
    }

    public void UseFuel() {
      if (currentFuel > 0.25f && canUseFuel) {
        currentFuel -= UnityEngine.Time.unscaledDeltaTime;
        Time.SlowTime();
      } else {
        canUseFuel = false;
        ChargeFuel();
      }
    }

    public void ChargeFuel() {
      if (currentFuel < maxFuel) {
        currentFuel = currentFuel + UnityEngine.Time.unscaledDeltaTime;
        Time.ResetTime();
        if (currentFuel > maxFuel / 3) {
          canUseFuel = true;
        }
      } else {
        currentFuel = maxFuel;
      }
    }
  }
}