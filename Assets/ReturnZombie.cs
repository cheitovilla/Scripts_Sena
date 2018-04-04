using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnZombie : MonoBehaviour {


    Zombie GetZombie() {
        return (Zombie)GameObject.FindObjectOfType(typeof(Zombie));
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       // Debug.DrawLine(transform.position, GetZombie().transform.position, Color.yellow);
        Zombie target = GetZombie();
        if (target != null)
        {
            Debug.DrawLine(transform.position, target.transform.position, Color.red);
        }
	}
}
