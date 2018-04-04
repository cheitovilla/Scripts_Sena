using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pruebas : MonoBehaviour {

	// Use this for initialization

        int MyFuntion()
    {
        return 7;
    }

        int MyAdd(int a, int b){
        return a + b;    
        }

	void Start () {
        int a = MyFuntion();
        int b = MyAdd(6,7);
        print(a);
        print(b);
        print(MyAdd(6, 7));
	}
	

}
