using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimer : MonoBehaviour
{

    private int minutesCounter;
    private int secondsCounter;
    private float milisecondsCounter;
    private string milisecondsDisplay;

    public GameObject minutesBox;
    public GameObject secondsBox;
    public GameObject milisecondsBox;
    
    void Update()
    {

        calculateMiliseconds();
        calculateSeconds();
        calculateMinutes();       
    }

    private void calculateMiliseconds(){

        milisecondsCounter += Time.deltaTime * 10;
        milisecondsDisplay = milisecondsCounter.ToString("F0");
        milisecondsBox.GetComponent<Text>().text = milisecondsDisplay; 
    }

    private void calculateSeconds(){

        if(milisecondsCounter >= 10){
            milisecondsCounter = 0;
            secondsCounter += 1;
        }

        if(secondsCounter <= 9){
            secondsBox.GetComponent<Text>().text ="0" + secondsCounter + ":";
            return;
        }
        secondsBox.GetComponent<Text>().text = secondsCounter + ":";
    }

    private void calculateMinutes(){
    
        if(secondsCounter > 59){
            secondsCounter = 0;
            minutesCounter += 1;
        }

        if(minutesCounter <= 9){
            minutesBox.GetComponent<Text>().text ="0" + minutesCounter + ":";
            return;
        }

        minutesBox.GetComponent<Text>().text = minutesCounter + ":";
    }
}
