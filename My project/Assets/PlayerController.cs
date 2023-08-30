using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public static int PlayerNumber = 5;
    public GameObject player;   //�@移動させたいオブジェクト
    Vector3 touchWorldPosition;　//�Aマウスでタッチした箇所の座標を取得
    public int speed = 5;
    
    

    void Start()
    {
       
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))  //左クリックでif分起動
        {
            Vector3 touchScreenPosition = Input.mousePosition;  //�Aマウスでタッチした座標をtouchScreenPositionに。
            touchScreenPosition.z = 5.0f;  //�A奥行を手前に来るように5.0fを指定。
            Camera camera = Camera.main;  //�A
            touchWorldPosition = camera.ScreenToWorldPoint(touchScreenPosition);  //�A
        }
        player.transform.position = Vector3.MoveTowards(player.transform.position, touchWorldPosition, speed * Time.deltaTime); //playerオブジェクトが, 目的地に移動, 移動速度
        if (PlayerNumber >= 40)
        {
            SceneManager.LoadScene("GameClearScene");
        }
    }
}
