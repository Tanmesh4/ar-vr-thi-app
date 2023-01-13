using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class tryToolTipManager : MonoBehaviour
{

    public static tryToolTipManager _instance;
    public TextMeshProUGUI textComp;

    void awake() {
        if(_instance != null && _instance != this) {
            Destroy(this.gameObject);
        }
        else {
            _instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Input.mousePosition;
    }

    public void setandShoeToolTip(string message) {
        gameObject.SetActive(true);
        textComp.text = message;
    }

    public void HideToolTip() {
        gameObject.SetActive(false);
        textComp.text = string.Empty;
    }
}
