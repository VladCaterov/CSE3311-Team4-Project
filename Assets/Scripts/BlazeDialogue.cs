using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class BlazeDialogue
{
    /*
    public Text Dorm1Info;
    public Text Dorm2Info;
    public Text Dorm3Info;
    public Text Dorm4Info;
    public Text LibraryInfo;
    public Text PickardHallInfo;
    public Text ChemBuilding;
    public Text PhysBuilding;
    */
    public Animator BlazeTalk;

    public string name;
    [TextArea(3,10)]
    public string[] sentences;
}
