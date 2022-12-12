using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tryUIcanvasManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static int numberOfSymbolClickedInForceEquation;
    public static int numberOfSymbolClickedInGravityEquation;
    public static List<GameObject> selectedAssets = new List<GameObject>();

    public GameObject deactivateforceScene;
    public GameObject deactivateGravityScene;
    public GameObject loadFinalScene;
    public string resulttext;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(numberOfSymbolClickedInForceEquation == 5 || numberOfSymbolClickedInGravityEquation == 6) {
            if(numberOfSymbolClickedInForceEquation == 5)
            {
                deactivateforceScene.SetActive( false );
            }
            if (numberOfSymbolClickedInGravityEquation == 6)
            {
                deactivateGravityScene.SetActive( false );
            }

            loadFinalScene.SetActive(true);
            numberOfSymbolClickedInForceEquation = 0;
            foreach( var assets in selectedAssets) {
                //Debug.Log(assets.ToString().Split(" ")[0]);
                resulttext = resulttext + " " + assets.ToString().Split(" ")[0];
            }
            //Debug.Log(resulttext);
            tryFinalCanvas.finalText = resulttext;
        }
    }
}
