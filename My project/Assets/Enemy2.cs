using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Enemy2 : MonoBehaviour
{
    public int EnemyNumber; //敵の数字(Unityで設定)
    public GameObject LevelText; //数字のテキスト
    public GameObject textMeshPro;  //テキストの導入
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)             // 衝突判定
    {
        if (other.gameObject.CompareTag("Player"))              //"Player"のタグを持つをプレイヤーにぶつかったとき
        {
            if (Player2.PlayerNumber >= EnemyNumber)    //プレイヤーの数字が敵の数字より大きかったとき
            {
                Player2.PlayerNumber -= EnemyNumber;   //プレイヤーの数字に敵の数字を加算する
                Destroy(this.gameObject);                       //敵のオブジェクトを削除する
                Destroy(textMeshPro);                           //テキストを削除する
            }
            else                                                //プレイヤーの数字が敵の数字が大きくなかったとき
            {
                SceneManager.LoadScene("GameOverScene");        //ゲームオーバーシーンに移動する
            }
        }
    }
}
