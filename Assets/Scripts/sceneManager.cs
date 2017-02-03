using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : SingletonMonoBehaviour<sceneManager> {
	// Use this for initialization
	void Start () {
		
		SceneManager.LoadScene("Scene1",LoadSceneMode.Additive );
	}
	
	// Update is called once per frame
	void Update () {
		//if( SceneManager.GetSceneByName("Scene1").isLoaded == )
		//{
			
		//}
	}
	
	void OnGUI()
	{
		if (GUI.Button (new Rect (0,0,Screen.width / 6,Screen.height /6), "Scene1->Scene2")) {
			
			StartCoroutine(SceneMove());
		}
	}
	
	IEnumerator SceneMove()
	{
		//loadシーンアクティブ
		SceneManager.LoadScene("load",LoadSceneMode.Additive );
		
		//１フレーム待つ カメラがない時間があるため
		yield return new WaitForSeconds(Time.deltaTime);
		
		//アニメーション長さ分待つ&アニメーション再生
		yield return new WaitForSeconds(load.Instance.Gate_in());
		
		//次のシーンアクティブ
		SceneManager.LoadScene("Scene2",LoadSceneMode.Additive );
		
		//一応保険として１フレーム待つ
		yield return new WaitForSeconds(Time.deltaTime);
		
		//前のシーン非アクティブ
		SceneManager.UnloadScene ("Scene1");
		
		//ロード時間とりあえず今回は時間で判定
		yield return new WaitForSeconds(3);
		
		//アニメーション長さ分待つ&アニメーション再生
		yield return new WaitForSeconds(load.Instance.Gate_out());
		
		//ロードシーン非アクティブ
		SceneManager.UnloadScene ("load");
	}
}
