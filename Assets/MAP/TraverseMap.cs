using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TraverseMap : MonoBehaviour
{
    public Transform player;
    public GameObject MapUI;
    public void Bookstore()
    {
        Vector3 newPosition = new Vector3(-148.6f, 91.5f, player.position.z);
        player.position = newPosition;
        MapUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Nedderman()
    {
        Vector3 newPosition = new Vector3(-151.5f, -5.7f, player.position.z);
        player.position = newPosition;
        MapUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Wolf_Hall()
    {
        Vector3 newPosition = new Vector3(-87.5f, -4.7f, player.position.z);
        player.position = newPosition;
        MapUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Physic_Chemistry()
    {
        Vector3 newPosition = new Vector3(-26.5f, -8.8f, player.position.z);
        player.position = newPosition;
        MapUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Library()
    {
        Vector3 newPosition = new Vector3(20.7f, -3.7f, player.position.z);
        player.position = newPosition;
        MapUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Nanno()
    {
        Vector3 newPosition = new Vector3(-140f, -80.1f, player.position.z);
        player.position = newPosition;
        MapUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Gym()
    {
        Vector3 newPosition = new Vector3(-69.5f, -150.7f, player.position.z);
        player.position = newPosition;
        MapUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Art()
    {
        Vector3 newPosition = new Vector3(-68.4f, -66.4f, player.position.z);
        player.position = newPosition;
        MapUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void West_Hall()
    {
        Vector3 newPosition = new Vector3(-162.9f, -204.4f, player.position.z);
        player.position = newPosition;
        MapUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Trees()
    {
        Vector3 newPosition = new Vector3(34.8f, -121.4f, player.position.z);
        player.position = newPosition;
        MapUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void SEIR()
    {
        Vector3 newPosition = new Vector3(71.4f, -2.1f, player.position.z);
        player.position = newPosition;
        MapUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void KC_Hall()
    {
        Vector3 newPosition = new Vector3(79.2f, 90.7f, player.position.z);
        player.position = newPosition;
        MapUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Parking_math()
    {
        Vector3 newPosition = new Vector3(26.9f, 90.3f, player.position.z);
        player.position = newPosition;
        MapUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void University_Center()
    {
        Vector3 newPosition = new Vector3(-87.2f, 47.6f, player.position.z);
        player.position = newPosition;
        MapUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Chemistry_Power()
    {
        Vector3 newPosition = new Vector3(-39.3f, 94.4f, player.position.z);
        player.position = newPosition;
        MapUI.SetActive(false);
        Time.timeScale = 1f;
    }
}
