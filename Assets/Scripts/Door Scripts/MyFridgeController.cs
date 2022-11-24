using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MyFridgeController : MonoBehaviour
{
	public Animator fridgeAnim;

	private bool doorOpen = false;

	private void Awake()
	{
		fridgeAnim = gameObject.GetComponent<Animator>();
	}

	public void PlayAnimation()
	{
		if (!doorOpen)
		{
			Debug.Log("FridgeOpen");
			fridgeAnim.Play("fridgeOpen", 0, 0.0f);
			doorOpen = true;
		} else {
			Debug.Log("FridgeClosed");
			fridgeAnim.Play("fridgeClose", 0, 0.0f);
			doorOpen = false;
		}
	}
}
