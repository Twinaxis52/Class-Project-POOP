using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MoveToNextLevel : MonoBehaviour
{
    public Button next;
    public Button replay;
    public int nextSceneLoad;
    // Start is called before the first frame update
    void Start()
    {
        Button btn2 = replay.GetComponent<Button>();
        Button btn = next.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        btn2.onClick.AddListener(TaskOnClick2);
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    void TaskOnClick()
    {
            SceneManager.LoadScene(nextSceneLoad);

            if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", nextSceneLoad);
            }
        
    }

        void TaskOnClick2()
    {
            if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", nextSceneLoad + 1);
            }
        
    }

}