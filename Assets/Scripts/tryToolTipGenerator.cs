using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tryToolTipGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string message;
    
    private void OnMouseEnter() {
        tryToolTipManager._instance.setandShoeToolTip(message);
    }

    private void OnMouseExit() {
        tryToolTipManager._instance.HideToolTip();
    }
}
