using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tryUIcanvasManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static int numberOfSymbolClickedInequation;
    public GameObject deactivateScene;
    public GameObject loadFinalScene;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(numberOfSymbolClickedInequation == 5) {
            deactivateScene.SetActive(false);
            loadFinalScene.SetActive(true);
            numberOfSymbolClickedInequation = 0;
        }
    }
}
