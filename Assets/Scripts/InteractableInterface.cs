using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class InteractableInterface : MonoBehaviour
{
    public Input player;
    public bool isInRange;
    public UnityEvent interactAction;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    /*
    public void interact(InputAction.CallbackContext context)
    {
        if(isInRange && context.performed)
        {
            interactAction.Invoke();
            Debug.Log("Action invoked");
        }
    }
    */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("Player is in Range");
            if (isInRange) //remove this if later for proper invoking 
            {
                interactAction.Invoke();
                Debug.Log("Action invoked");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            Debug.Log("Player is out of range");
            
        }
    }

}
