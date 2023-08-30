using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Enemy2 : MonoBehaviour
{
    public int EnemyNumber; //�G�̐���(Unity�Őݒ�)
    public GameObject LevelText; //�����̃e�L�X�g
    public GameObject textMeshPro;  //�e�L�X�g�̓���
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)             // �Փ˔���
    {
        if (other.gameObject.CompareTag("Player"))              //"Player"�̃^�O�������v���C���[�ɂԂ������Ƃ�
        {
            if (Player2.PlayerNumber >= EnemyNumber)    //�v���C���[�̐������G�̐������傫�������Ƃ�
            {
                Player2.PlayerNumber -= EnemyNumber;   //�v���C���[�̐����ɓG�̐��������Z����
                Destroy(this.gameObject);                       //�G�̃I�u�W�F�N�g���폜����
                Destroy(textMeshPro);                           //�e�L�X�g���폜����
            }
            else                                                //�v���C���[�̐������G�̐������傫���Ȃ������Ƃ�
            {
                SceneManager.LoadScene("GameOverScene");        //�Q�[���I�[�o�[�V�[���Ɉړ�����
            }
        }
    }
}
