using UnityEngine;
using System.Collections;

public class spin : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
	transform.Rotate(new Vector3(1,1,0) * Time.deltaTime);
	}
}
