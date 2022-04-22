using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneWithButton : MonoBehaviour
{
    MapSelection mapSelection;
    public GameObject Map;

    void Awake()
    {
        mapSelection = Map.GetComponent<MapSelection>();
    }
    
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadSceneMap(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
