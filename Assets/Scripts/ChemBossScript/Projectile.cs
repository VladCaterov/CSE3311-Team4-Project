using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterProjectile : MonoBehaviour
{
    //make object for water and salt 
    public GameObject Waterprefab;
    public GameObject Saltprefab;
    public Transform firePoint;//the place where the water and salt will shoot out 

    private int questions = 10; //number of questions 
    private bool Question_button = false; //check if question button is pressed 

    void Update()
    {
        //if space or question button is pressed 
        if (Input.GetKeyDown(KeyCode.Space) || Question_button)
        {
            //call the shoot function and decrease the number of question by one 
            shoot();
            questions = questions - 1;
            if (questions == 0)
            {
                /*when question reaches 0, get rid of the script so that the objects are not created again*/
                GetComponent<WaterProjectile>().enabled = false;
            }
            Question_button = false; // chage it back to false for the next question
        }
    }
    void shoot()
    {
        //get a random number and create the water and salt prefabs 
        int number = Mathf.RoundToInt(Random.Range(0f, 1f));
        if (number == 0)
        {
            Instantiate(Waterprefab, firePoint.position, firePoint.rotation);
        }
        else
        {
            Instantiate(Saltprefab, firePoint.position, firePoint.rotation);
        }
    }
    public void questionButton()
    {
        //if the question button is pressed. change it to true 
        Question_button = true;
    }
}