using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class load : SingletonMonoBehaviour<load>{
	Animation anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public float Gate_in()
	{
		string animName = "gate_in";
		anim.Play(animName);
		return anim[animName].length;
	}
	
	public float Gate_out()
	{
		string animName = "gate_out";
		anim.Play(animName);
		return anim[animName].length;
	}
	
	protected void OnEnable()
	{
		Debug.LogWarning("load->OnEnable");
	}
	
	protected void OnDisable()
	{
		Debug.LogWarning("load->OnDisable");
	}
}
