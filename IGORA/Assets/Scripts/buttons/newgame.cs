using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newgame : MonoBehaviour {

	void OnMouseOver()
    {
	
		if (Input.GetMouseButtonDown (0))
        {
			Application.LoadLevel("1level");
		}
	
	}
}
