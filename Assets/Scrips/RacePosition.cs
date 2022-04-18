using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RacePosition : MonoBehaviour
{

    public GameObject positionDisplay;
    private const string first = "1";
    private const string second = "2";

    void OnTriggerExit(Collider collider){

        if(collider.tag == "CarPosition"){
            string previousPlace = positionDisplay.GetComponent<Text>().text;
            switch(previousPlace){
                case "1": 
                    positionDisplay.GetComponent<Text>().text = "2";
                    break;
                case "2":
                    positionDisplay.GetComponent<Text>().text = "1";
                    break;
            }
        }
    }
}
