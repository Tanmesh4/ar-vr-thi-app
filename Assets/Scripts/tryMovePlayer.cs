using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tryMovePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    private CharacterController cc;
    private Animator ani;

    private float inX;
    private float inZ;
    private Vector3 movev3;
    private Vector3 velV3;
     private float movespeed;
    //private float grav;

    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("player");
        cc = player.GetComponent<CharacterController>();
        ani = player.transform.GetChild(0).GetComponent<Animator>();

        movespeed = 4f;
        //grav = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        inX = Input.GetAxis("Horizontal");
        inZ = Input.GetAxis("Vertical");
    }

    private void FixedUpdate() {
        movev3 = cc.transform.forward * inZ;
        cc.transform.Rotate(Vector3.up * inX * (100f * Time.deltaTime));

        cc.Move(movev3 * movespeed * Time.deltaTime);
    }
    
}
