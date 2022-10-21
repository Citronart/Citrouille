using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lauchGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void LaunchGame(string Scene1)
    {
        SceneManager.LoadScene(Scene1);
        Time.timeScale=1;
    }

}

