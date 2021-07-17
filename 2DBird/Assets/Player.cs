using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    [SerializeField]
    float JumpVelocity = 10; //ジャンプ力

    Rigidbody2D rb2d;
    //追加
    Vector3 m_YAxis;

    [SerializeField]
    private Sprite sp;

    void Start()
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        renderer.sprite = sp;

        rb2d = GetComponent<Rigidbody2D>();
        //追加
        m_YAxis = new Vector3(0, 5, 0);

        Invoke("ChangeScene", 1.5f);
    }
    void Update()
    {
        TouchManager.Began += (info) =>
        {
            rb2d.velocity = Vector2.zero; //落下速度リセット
            rb2d.AddForce(transform.up * JumpVelocity, ForceMode2D.Impulse);
        };
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(GetComponent<Animator>());
        
        rb2d.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
        //JumpVelocity = 0; //ジャンプ力
        // rb2d.AddForce(transform.up * 0);
        // Input.GetMouseButtonDown(0);
        SceneManager.LoadScene("GameOver");
    }


}
