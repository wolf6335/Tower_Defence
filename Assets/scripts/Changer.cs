using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;
  
public class Changer: MonoBehaviour 
{  
    public void video() {
        Debug.Log("clic");
        SceneManager.LoadScene("video");  
    }

    public void level()
    {
        Debug.Log("clic");
        SceneManager.LoadScene("level01");
    }

} 
