using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSelection : MonoBehaviour
{

    public bool IsUnlocked = false;
    public GameObject LockedMap;
    public GameObject UnlockedMap;

    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        LevelStatus();
    }
    private void LevelStatus()
    {
        if(IsUnlocked)
        {
            UnlockedMap.gameObject.SetActive(true);
            LockedMap.gameObject.SetActive(false); 
        } else
        {
            UnlockedMap.gameObject.SetActive(false);
            LockedMap.gameObject.SetActive(true);
        }
    }
    
}
