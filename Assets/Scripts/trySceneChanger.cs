using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trySceneChanger : MonoBehaviour
{
   // Start is called before the first frame update
    public GameObject nextScene;
    public GameObject currentScene;
    public GameObject loadRequiredAsset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeScene() {
        if(nextScene) {
            nextScene.SetActive(true);
        }
        if(currentScene) {
        currentScene.SetActive(false);
        }
    }

    public void loadRequestedAsset() {
        loadRequiredAsset.SetActive(true);
    }
}
