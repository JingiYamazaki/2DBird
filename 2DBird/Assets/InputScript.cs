using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour
{
    GameObject gameManagerObj;
    GameManager gameManager;

    private void Start()
    {
        gameManagerObj = GameObject.Find("GameManager");
        gameManager = gameManagerObj.GetComponent<GameManager>(); // スクリプトを取得
    }

    private void Update()
    {
        /*if ()
        {
            // 画面タッチ中は何かが起きる
        }

        if (Collision2D.gameObject.name == "Wall") // ボタン離した時の判定
        {
            gameManager.CallInoperable(2.0f); // 2 秒間　このスクリプトを無効にする（Inputできない）
        }*/
    }
    void OnCollisionEnter(Collision collision)
    {
        gameManager.CallInoperable(10.0f);
    }
}