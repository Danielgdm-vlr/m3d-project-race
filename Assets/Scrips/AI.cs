using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public GameObject waypoint;
    public Transform waypointSystem;

    private int waypointCounter = 0;

    void Update () {
        
        int waypoints = waypointSystem.childCount;
        for(int i = 0; i < waypoints; i++){
            if(waypointCounter == i){
                waypoint.transform.position = waypointSystem.GetChild(i).GetComponent<Transform>().position;
            }
        }
    }

    IEnumerator OnTriggerEnter(Collider collision) {

		if (collision.gameObject.tag == "AICar") {
			this.GetComponent<BoxCollider> ().enabled = false;
			waypointCounter ++;
			// if (waypointCounter == 7) {
			// 	waypointCounter = 0;
			// }
			yield return new WaitForSeconds (1/2);
			this.GetComponent<BoxCollider> ().enabled = true;
		}
	}

    // IEnumerator OnTriggerEnter(Collider collider){


    //     if(collider.gameObject.tag == "AICar"){

    //         Debug.Log("xd");

    //         this.GetComponent<BoxCollider> ().enabled = false;
    //         int waypoints = waypointSystem.childCount;

    //         for (int i = 0; i < waypoints; i++){

    //             if(waypoint.transform.position == 
    //                 waypointSystem.GetChild(i).GetComponent<Transform>().position){
    //                     if(i == waypoints - 1){
    //                         waypoint.transform.position = 
    //                             waypointSystem.GetChild(0).GetComponent<Transform>().position;
    //                     }
    //                     else{
    //                         waypoint.transform.position = 
    //                             waypointSystem.GetChild(i + 1).GetComponent<Transform>().position;
    //                     }
    //                 }
    //         }

    //         yield return new WaitForSeconds (1);
    //         this.GetComponent<BoxCollider> ().enabled = true;
    //     }
    // }
}
