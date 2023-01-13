using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trySceneChanger : MonoBehaviour
{
   // Start is called before the first frame update
    public GameObject nextScene;
    public GameObject currentScene;
    public GameObject loadRequiredAsset;
    public Button disableLoadedButton;

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
        if(currentScene.ToString().Split(" ")[0] == "InstructionCanvas") {
            tryUIcanvasManager.numberOfSymbolClickedInForceEquation += 1;
        }
            if (currentScene.ToString().Split(" ")[0] == "InstructionGravityCanvas")
            {
                tryUIcanvasManager.numberOfSymbolClickedInGravityEquation += 1;
            }
        }
    }

    public void loadRequestedAsset() {
        loadRequiredAsset.SetActive(true);
        tryUIcanvasManager.selectedAssets.Add(loadRequiredAsset);
    }

    public void disableButton() {
        Debug.Log("disabling button" + disableLoadedButton.ToString());
        disableLoadedButton.interactable = false;
    }
    
}
