using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondBackScript : MonoBehaviour
{

    private NewSceneSwitcher scene1;

    void Start()
    {
        Invoke("sceneGrabber2", 4f);
    }

    void sceneGrabber2()
    {
        scene1 = GameObject.Find("GameManager").GetComponent<NewSceneSwitcher>();
        scene1.tenSecondBack();
    }
}
