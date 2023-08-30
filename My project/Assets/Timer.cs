using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField, Header("制限時間の設定値")]
    public int battleTime;
    [SerializeField, Header("制限時間の表示")]
    public TMP_Text battleTimeText;
    private float timer;                  // 時間計測用
    private int currentTime;              // 現在の残り時間（不要な場合は宣言しない）
    // Start is called before the first frame update
    void Start()
    {
        // currentTimeを利用する場合にはここで代入する。以下、必要に応じてbattleTimeをcurrentTimeに書き換える
        currentTime = battleTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // timerを利用して経過時間を計測
        timer += Time.deltaTime;
        // 1秒経過ごとにtimerを0に戻し、battleTime(currentTime)を減算する
        if (timer >= 1)
        {
            timer = 0;
            if (battleTime > 0)
            {
                battleTime--;  // あるいは、currentTime--;
                               // 時間表示を更新するメソッドを呼び出す
                DisplayBattleTime(battleTime);   // あるいは、DisplayBattleTime(currentTime);
            }
            else if (battleTime == 0)
            {
                SceneManager.LoadScene("GameOverScene");
            }

        }
    }
    private void DisplayBattleTime(int limitTime)
    {
        // 引数で受け取った値を[分:秒]に変換して表示する
        // ToString("00")でゼロプレースフォルダーして、１桁のときは頭に0をつける
        battleTimeText.text = ((int)(limitTime / 60)).ToString("00") + ":" + ((int)limitTime % 60).ToString("00");
    }
}
