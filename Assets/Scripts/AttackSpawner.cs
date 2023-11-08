using UnityEngine;

public class AttackSpawner : MonoBehaviour
{
    public Transform AttackSpawn;
    public GameObject Attack1;
    public GameObject Attack2;
    private float TimeSinceAttack1 = 0f;
    private float TimeSinceAttack2 = 0f;
    public float Attack1Interval = 5f;
    public float Attack2Interval = 10f;

    private void Update()
    {
        // if(Boss.BossStatus == Boss.Status.DamagedMode)
        //{
        //Add to the timers
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
        //}
    }

    void SendIt(GameObject attack)
    {
        Instantiate(attack, AttackSpawn.position, AttackSpawn.rotation);
    }
}
