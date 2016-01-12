using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

    public Transform target;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        NavMeshPath path = new NavMeshPath();
        agent.CalculatePath(target.position, path);
        if (path.status == NavMeshPathStatus.PathPartial)
        {
        }
    }

}
