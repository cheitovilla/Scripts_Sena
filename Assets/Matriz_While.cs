using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matriz_While : MonoBehaviour {

	// Use this for initialization
	void Start () {

        int[] scores = new int[10];
        int i = 0;
        while (i<10)
        {
            scores[i] = Random.Range(0, 100);

            //obtenemos el valor de la matriz
            int score = scores[i];
            //print(scores[i]);
            print(score);
            i++;
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
