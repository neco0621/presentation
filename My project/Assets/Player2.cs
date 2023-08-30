using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player2 : MonoBehaviour
{

    public static int PlayerNumber = 80; //プレイヤーの数字
    public GameObject player;   //①移動させたいオブジェクト
    Vector3 touchWorldPosition;　//②マウスでタッチした箇所の座標を取得
    public int speed = 5; //動くスピード
    public Text text;
    Camera cam;
    Vector2 setPos;

    void Start()
    {
        

        cam = Camera.main;
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))  //左クリックでif分起動
        {
            Vector3 touchScreenPosition = Input.mousePosition;  //②マウスでタッチした座標をtouchScreenPositionに。
            touchScreenPosition.z = 5.0f;  //②奥行を手前に来るように5.0fを指定。
            Camera camera = Camera.main;  //②
            touchWorldPosition = camera.ScreenToWorldPoint(touchScreenPosition);  //②
        }
        player.transform.position = Vector3.MoveTowards(player.transform.position, touchWorldPosition, speed * Time.deltaTime); //playerオブジェクトが, 目的地に移動, 移動速度
        if (PlayerNumber <= 1) //プレイヤーの数字が40を超えたとき(すべての敵を倒したとき)
        {
            SceneManager.LoadScene("GameClearScene"); //ゲームクリアシーンに移動する
        }
        text.text = PlayerNumber.ToString();
    }

    void FixedUpdate()
    {
        //setPos = cam.WorldToScreenPoint(player.transform.position);
        setPos = player.transform.position;
        setPos.y += 2f;
        text.transform.position = setPos;
    }
}
