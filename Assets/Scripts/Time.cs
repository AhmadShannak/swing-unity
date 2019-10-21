using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stick {
  public class Time : MonoBehaviour {
    ///<summary> This value is used to slow time for anything that uses transform.</summary>
    public static float timeScale = 1;
    
    public static void SlowTime() {
      timeScale = 0.05f;
      UnityEngine.Time.timeScale = 0.05f;
      UnityEngine.Time.fixedDeltaTime = UnityEngine.Time.timeScale * 0.02f;      
    }

    public static void ResetTime() {
      timeScale = 1f;
      UnityEngine.Time.timeScale = 1;   
    }
  } 
}
