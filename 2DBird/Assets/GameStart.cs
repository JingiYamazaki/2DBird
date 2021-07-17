using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{

	public string sceneName;

	//　スタートボタンを押したら実行する
	public void OnMouseDown()
	{
		SceneManager.LoadScene(sceneName);
	}
}
