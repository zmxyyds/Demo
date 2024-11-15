using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public void StartGame(string scene)
    {
        SceneManager.LoadScene(scene);
    }

}
