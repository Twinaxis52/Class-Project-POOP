using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Experimental.Rendering.Universal;
public class brightnessControl : MonoBehaviour
{
    public Slider brightnessSlidertemp;
    static Slider brightnessSlider;
    public Light2D sceneLight;
    // Start is called before the first frame update
     void Awake()
     {
         brightnessSlider = brightnessSlidertemp;
     }

    void Start()
    {
        if(!PlayerPrefs.HasKey("brightness"))
        {
            PlayerPrefs.SetFloat("brightness", 1);
            Load();
        }

        else
        {
            Load();
        }
    }

    public void ChangeBrightness()
    {
        sceneLight.intensity = brightnessSlider.value;
        Save();
    }


    public void Load()
    {
        brightnessSlider.value = PlayerPrefs.GetFloat("brightness");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("brightness", brightnessSlider.value);
    }
}