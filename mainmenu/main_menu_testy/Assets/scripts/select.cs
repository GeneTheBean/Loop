 using UnityEngine;
 using System.Collections;
 
 public class example : MonoBehaviour {
     void Update() {
         if (Input.anyKeyDown)
             Debug.Log("A key or mouse click has been detected");
         
     }
 }