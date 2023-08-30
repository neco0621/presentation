using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField, Header("�������Ԃ̐ݒ�l")]
    public int battleTime;
    [SerializeField, Header("�������Ԃ̕\��")]
    public TMP_Text battleTimeText;
    private float timer;                  // ���Ԍv���p
    private int currentTime;              // ���݂̎c�莞�ԁi�s�v�ȏꍇ�͐錾���Ȃ��j
    // Start is called before the first frame update
    void Start()
    {
        // currentTime�𗘗p����ꍇ�ɂ͂����ő������B�ȉ��A�K�v�ɉ�����battleTime��currentTime�ɏ���������
        currentTime = battleTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // timer�𗘗p���Čo�ߎ��Ԃ��v��
        timer += Time.deltaTime;
        // 1�b�o�߂��Ƃ�timer��0�ɖ߂��AbattleTime(currentTime)�����Z����
        if (timer >= 1)
        {
            timer = 0;
            if (battleTime > 0)
            {
                battleTime--;  // ���邢�́AcurrentTime--;
                               // ���ԕ\�����X�V���郁�\�b�h���Ăяo��
                DisplayBattleTime(battleTime);   // ���邢�́ADisplayBattleTime(currentTime);
            }
            else if (battleTime == 0)
            {
                SceneManager.LoadScene("GameOverScene");
            }

        }
    }
    private void DisplayBattleTime(int limitTime)
    {
        // �����Ŏ󂯎�����l��[��:�b]�ɕϊ����ĕ\������
        // ToString("00")�Ń[���v���[�X�t�H���_�[���āA�P���̂Ƃ��͓���0������
        battleTimeText.text = ((int)(limitTime / 60)).ToString("00") + ":" + ((int)limitTime % 60).ToString("00");
    }
}
