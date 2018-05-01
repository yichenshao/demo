using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour {
	[SerializeField]
	int cur = 5;
	public void doDamage(int n){
		cur -= n;
		if (cur <= 0)
			Destroy (gameObject);
	// Use this for initialization
	//void Start () {
		
	}
	
	// Update is called once per frame
	//void Update () {
		
	}

