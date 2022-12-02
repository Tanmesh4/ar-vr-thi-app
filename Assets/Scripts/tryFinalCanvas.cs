using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tryFinalCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    public Text resultText;
    public static string finalText;

    void Start()
    {
        resultText.text = finalText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
