using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyClass : MonoBehaviour {
    public GameObject[] myGameObjects;
    // Use this for initialization
    void Start () {
        Debug.Log(myGameObjects.Length);
        for (int i = 0; i < myGameObjects.Length; i++)
        {
          //  Debug.Log(myGameObjects.Length);
            myGameObjects[i].name = i.ToString();
        }
        foreach (GameObject go in myGameObjects)
        {
            Debug.Log(go.name);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
