using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//test.Instance.log();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	protected void OnEnable()
	{
		Debug.LogWarning("Scene1->OnEnable");
	}
	
	// This function is called when the behaviour becomes disabled () or inactive.
	protected void OnDisable()
	{
		Debug.LogWarning("Scene1->OnDisable");
	}
}
