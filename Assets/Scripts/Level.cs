using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    SceneLoader sceneLoader;
    [SerializeField] int numOfBlocks;
    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void countBlocks() {
        ++numOfBlocks;
    }

    public void blockDestroyed() {
        --numOfBlocks;
        if (numOfBlocks <= 5) {
            sceneLoader.loadNextScene();
        }
    }
}
