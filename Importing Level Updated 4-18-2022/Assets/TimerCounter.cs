using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class TimerCounter : MonoBehaviour
{
    public static TimerCounter instance;
    public Text timeText;
    // Start is called before the first frame update
    float Timercounter = 120;
    bool yoo = false;
    bool run = false;
    private void Awake(){
        instance = this;
    }

    void Start()
    {
        Timercounter = PlayerPrefs.GetFloat("Timercounter", 120);
        timeText.text = "Timer: " + Timercounter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(run == true){
            if(yoo == false){
                if(Timercounter>0f){
                    Timercounter = Timercounter - Time.deltaTime;
                    if(Timercounter<0){
                        Timercounter=0;
                        timeText.text= "Timer: " + Timercounter.ToString();
                        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    }
                    timeText.text = "Timer: " + Timercounter.ToString();
                }
            }
        }
    }

    public void stopTimer()
    {
        yoo = true;
    }
    public void startTimer()
    {
        run = true;
    }
}
