using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapCounter : MonoBehaviour
{

    public GameObject lapDisplay;
}
//     private int lapCounter = 1;

//     IEnumerator OnTriggerExit(Collider collider){

//         if(collider.gameObject.tag == "CarPosition"){
//             lapCounter++;
//             Debug.Log("xd");

//             if(lapCounter > 2){
//                 lapDisplay.GetComponent<Text>().text = "0";
//                 return;
//             }

//             lapDisplay.GetComponent<Text>().text = lapCounter.ToString();
//         }
//         return null;
//     }
// }
