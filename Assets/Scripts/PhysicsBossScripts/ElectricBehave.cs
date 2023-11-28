using UnityEngine;

public class ElectricBehave : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D rb;
    public LayerMask PlayerLayer; //select the target layer
    private Transform Player;
    private PlayerMovement Josh;
    public int PointsOff;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Player = GameObject.FindWithTag("Player").transform;
        Vector3 direction = (Player.position - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.SetRotation(angle);
        rb.velocity = direction * speed;
    }

    private void OnTriggerEnter2D(Collider2D hit)
    {
       // Debug.Log(hit.name); //shows what's been hit by this object in console
        Josh = hit.GetComponent<PlayerMovement>(); //detects the collision to Josh
        if (Josh != null)
        {
            Josh.markPoints(PointsOff); //Marks points off Josh's "score"
        }
        Destroy(gameObject); //Get rid of projectile on collision
    }
}


