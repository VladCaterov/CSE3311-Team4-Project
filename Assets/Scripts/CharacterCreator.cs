using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Linq;
public class CharacterCreator : MonoBehaviour
{

    public Toggle starter1;
    public Toggle starter2;
    public Toggle starter3;
    private List<Toggle> availableClasses = new();
    private List<Toggle> schedule = new();

    public Toggle class1;
    public Toggle class2;
    public Toggle class3;
    public Toggle class4;
    public Toggle class5;
    public Toggle class6;

    public Button startGame;

    // Use this for initialization
    
    
    void Start()
    {
        starter1.onValueChanged.AddListener(delegate
        {
            DisableUnselect(starter1);
        });
        starter2.onValueChanged.AddListener(delegate
        {
            DisableUnselect(starter2);
        });
        starter3.onValueChanged.AddListener(delegate
        {
            DisableUnselect(starter3);
        });

        availableClasses.Add(class1);
        availableClasses.Add(class2);
        availableClasses.Add(class3);
        availableClasses.Add(class4);
        availableClasses.Add(class5);
        availableClasses.Add(class6);


        class1.onValueChanged.AddListener(delegate
        {
            ModifySchedule(class1);
        });
        class2.onValueChanged.AddListener(delegate
        {
            ModifySchedule(class2);
        });
        class3.onValueChanged.AddListener(delegate
        {
            ModifySchedule(class3);
        });
        class4.onValueChanged.AddListener(delegate
        {
            ModifySchedule(class4);
        });
        class5.onValueChanged.AddListener(delegate
        {
            ModifySchedule(class5);
        });
        class6.onValueChanged.AddListener(delegate
        {
            ModifySchedule(class6);
        });
    startGame.onClick.AddListener(delegate
        {
            BeginAdventure();
        });
    }
    // Update is called once per frame
    void Update()
    {
    }

    void DisableUnselect(Toggle starter)
    {
        if (starter.isOn)
        {
            starter.interactable = false;
        }
        else
        {
            starter.interactable = true;
        }
    }

    void ModifySchedule(Toggle newClass)
    {
        if (newClass.isOn)
        {
            if (schedule.Count < 5)
            {
                schedule.Add(newClass);
            }
            else if (schedule.Count == 5)
            {
                schedule.Add(newClass);
                List<Toggle> inactiveToggles = availableClasses.Except(schedule).ToList();
                foreach (Toggle t in inactiveToggles)
                {
                    print(t);
                    t.interactable = false;
                }
            }
        }
        else
        {
            schedule.Remove(newClass);
            List<Toggle> inactiveToggles = availableClasses.Except(schedule).ToList();
            foreach (Toggle t in inactiveToggles)
            {
                t.interactable = true;
            }     
        }
        foreach (Toggle t in schedule)
        {
            print(t.name);
        }
    }
    public void BeginAdventure()
    {
        print("Hello");

        float randLocationSceneID = Random.Range(5, 7);
        //SceneManager.LoadScene((int)randLocationSceneID);
        SceneManager.LoadScene("Fight Scene 1");
    }

}
