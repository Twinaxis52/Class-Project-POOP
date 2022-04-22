using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
   public static ScoreManager instance;

   public Text scoreText;
   public Text highscoreText;
    // Start is called before the first frame update
   float score = 120f;
   float highscore = 0f;
   float temp = 0;
   float scoreSeconds = 1; 
   bool yo = false;
   bool run = false;

   public bool TakingAway = false;

   private void Awake() {
    instance = this;
   }

   void Start()
   {

       highscore = PlayerPrefs.GetFloat("highscore", 0);
       scoreText.text = score.ToString() + " POINTS";
       highscoreText.text = "HIGHSCORE: " + highscore.ToString();
   }


   void Update()
   {
       if(run == true){
           if(yo == false){
               score = score - Time.deltaTime;
               if(score<0)
                  score = 0;
                  scoreText.text = score.ToString() + " POINTS";
                  

           }
       }
   }

    // Update is called once per frame
   public void AddPoint() 
   {
    score += 10f;
    scoreText.text = score.ToString() + " POINTS";
    if (highscore<score)
        PlayerPrefs.SetFloat("highscore", score);
   }

   public void stopPoints()
   {
       yo = true;
       if(highscore<score)
       {
           PlayerPrefs.SetFloat("highscore", score);
           highscoreText.text = "HIGHSCORE: " + highscore.ToString();
       }
   }
   public void startPoints()
   {
       run = true;
   }

}
