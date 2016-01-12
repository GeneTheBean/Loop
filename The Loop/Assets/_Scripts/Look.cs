using UnityEngine;
using System.Collections;

public class Look : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    public Transform target;
    public float damping = 10.0F;

    void Update()
    {
        if(Vector3.Distance(transform.position, target.position) < 10){
            var lookPos = target.position - transform.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
        }
        }
}

