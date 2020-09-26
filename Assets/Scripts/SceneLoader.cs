using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void loadNextScene() {
        int curSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(curSceneIndex + 1);
    }

    public void loadStartScene() {
        SceneManager.LoadScene(0);
    }
}
