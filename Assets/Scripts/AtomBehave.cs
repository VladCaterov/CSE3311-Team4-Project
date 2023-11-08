using UnityEngine;

public class AtomBehave : MonoBehaviour
{
    public float speed = 5f;
    public float rotateSpeed = 200f;
    public Rigidbody2D rb;
    public LayerMask PlayerLayer;
    private Transform Player;
    public int PointsOff;
    private PlayerMovement Josh; //Allows access to Health System

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Player = GameObject.FindWithTag("Player").transform;
    }

    private void Update()
    {
        if (Player != null) //Stop sending object on player fail
        {
            Vector2 direction = (Player.position - transform.position).normalized;
            //angles the atom to the player
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.SetRotation(angle);
            //projectile speed forward
            rb.velocity = direction * speed;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D hit)
    {
        //Debug.Log(hit.name); //shows what's been hit by this object in console
        Josh = hit.GetComponent<PlayerMovement>(); //detects the collision to Josh
        if (Josh != null)
        {
            Josh.markPoints(PointsOff); //Marks points off Josh's "score"
        }
        Destroy(gameObject); //Get rid of projectile on collision
    }
}
