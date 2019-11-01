using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stick {
  public class Player : MonoBehaviour {
    [SerializeField]
    float maxFuel = 15;
    [SerializeField]
    Web web;

    float currentFuel;

 
    bool canUseFuel = true;
    public bool CanUseFuel {
      get { return canUseFuel; }
    } 

    void Awake() {
      currentFuel = maxFuel;
      web.SetWeb(WebHelper.NORMAL_WEB);
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

    public void ShootWeb(Vector2 endPos) {
      web.ShootWeb(this.transform.position, CalculateWebDirection(endPos));
    }

    private Vector2 CalculateWebDirection(Vector2 endPos) {
      float x = endPos.x >= 0 ? web.webProperties.webLength : -web.webProperties.webLength;
      float y = endPos.y >= 0 ? web.webProperties.webLength : -web.webProperties.webLength;
      return new Vector2(this.transform.position.x + x, this.transform.position.y + y);
    }
  }
}