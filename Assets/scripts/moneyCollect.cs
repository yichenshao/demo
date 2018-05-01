using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneyCollect : MonoBehaviour {
	public static int score = 100;
	void onMouseDown(){
		score += 20;
	
		Destroy (gameObject);
	}
}
	// Use this for initialization
	//void Start () {
		
	//}
	
	// Update is called once per frame
	//void Update () {
		
	//}

