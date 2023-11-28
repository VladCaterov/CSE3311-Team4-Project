using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBoss : MonoBehaviour
{
    /*public Transform AttackSpawn;
    public GameObject Attack1;
    public GameObject Attack2;
    private float TimeSinceAttack1 = 0f;
    private float TimeSinceAttack2 = 0f;
    public float Attack1Interval = 5f;
    public float Attack2Interval = 10f;
    public float flight speed = 2f;
    public List<Transform> waypoints;

    Transform nextWaypoint;
    int waypointNum = 0;

    public float waypointReachedDistance = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        nextWaypoint = waypoints[waypointNum];
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeSinceAttack1 += Time.deltaTime;
        TimeSinceAttack2 += Time.deltaTime;

        if (TimeSinceAttack1 >= Attack1Interval)
        {
            SendIt(Attack1);
            TimeSinceAttack1 = 0f; //Reset Timer
        }
        if (TimeSinceAttack2 >= Attack2Interval)
        {
            SendIt(Attack2);
            TimeSinceAttack2 = 0f;
        }
    }
    void SendIt(GameObject attack)
    {
        Instantiate(attack, AttackSpawn.position, AttackSpawn.rotation);
    }


    private void Flight()
    {
        //fly to next waypoint
        Vector2 directionToWaypoint = (nextWaypoint.position - transform.position).normalized;

        //check distance to wayppoint
        float distance = Vector2.Distance(directionToWaypoint, transform.position);

        //see if we need to switch waypoints
        if(distance <= waypointReachedDistance)
        {
            waypointNum++;

            if(waypointNum >= waypoint.Count)
            {
                //loop back to original waypoint
                waypointNum = 0;
            }

            nextWaypoint = waypoints[waypointNum];
        }
    }*/
}
