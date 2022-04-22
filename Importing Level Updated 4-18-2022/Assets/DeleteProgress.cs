using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteProgress : MonoBehaviour
{
    public Button clear;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = clear.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        PlayerPrefs.DeleteAll();
    }
}
