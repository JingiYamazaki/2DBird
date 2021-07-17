using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
    // ①スコア
    int _score = 0;

    void Start()
    {
    }

    void Update()
    {
    }

    private void FixedUpdate()
    {
        // ②スコア上昇
        _score += 1;
    }

    private void OnGUI()
    {
        // ③スコアを描画
        _DrawScore();
    }

    // ④スコアの描画
    void _DrawScore()
    {
        // 文字を大きくする
        GUI.skin.label.fontSize = 32;
        // 左揃え
        GUI.skin.label.alignment = TextAnchor.MiddleLeft;
        Rect position = new Rect(10, 10, 400, 100);
        GUI.Label(position, string.Format("score:{0}", _score));
        
    }
}