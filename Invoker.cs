using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Invoker : MonoBehaviour
{
  private NewSceneSwitcher scene1;
  
  void Start()
  {
    Invoke("sceneGrabber", 5.5f)
  }
   
  void sceneGrabber()
  {
    scene1 = GameObject.Find("GameManager").GetComponent<NewSceneSwitcher>();
    scene1.invokeSwitcher();
   }
 }
 
