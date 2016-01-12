using UnityEngine;
using System.Collections;

public class CharNavScript : MonoBehaviour {
    //link to Animator component
    public Animator animController;
    //used to set anim controller parameters
    public enum MoveState { Idle, Walking }
    public MoveState moveState;
    //link to NavMeshAgent component
    public NavMeshAgent navAgent;
    // Use this for initialization
    Vector3 target;
   //Target points of the sidewalk
    Vector3[] points = new Vector3[2];
        
    void Start()
    {
        initPoints();
        target = points[Random.Range(0, points.Length)];
        navAgent.SetDestination(target);

    }

    // Update is called once per frame
    void Update () {
        //character walks if there is a navigation path set, idle all other times
        if (navAgent.hasPath){
            moveState = MoveState.Walking;
            animController.CrossFade("Walking", 0f);
        }

        else {
            moveState = MoveState.Idle;
            animController.CrossFade("Idle", 0f);
        }
        
        //send move state info to animator controller
        animController.SetInteger("MoveState", (int)moveState);

        //If the target is within a short distance, a new target point is assigned
        if (Vector3.Distance(transform.position, target) < 2){
            initPoints();
            target = points[Random.Range(0, points.Length)];
            navAgent.SetDestination(target);
        }
    }

    //Reinitializes the points to random locations
    void initPoints(){
        //East
        points[0] = new Vector3(Random.Range(2.53F, 2.53F), 0.80F, Random.Range(-40.0F, 5.0F));
        points[1] = new Vector3(Random.Range(-44.3F, -44.3F), 0.80F, Random.Range(-40.0F, 5.0F));
    }
}
