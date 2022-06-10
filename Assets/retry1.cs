using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retry1 : MonoBehaviour
{
    public void Scene1()

    {
        Debug.Log("clic");
        SceneManager.LoadScene("MainMenu");
    }
}
