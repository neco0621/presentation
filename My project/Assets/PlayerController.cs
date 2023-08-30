using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public static int PlayerNumber = 5; //�v���C���[�̐���
    public GameObject player;   //�@�ړ����������I�u�W�F�N�g
    Vector3 touchWorldPosition;�@//�A�}�E�X�Ń^�b�`�����ӏ��̍��W���擾
    public int speed = 5; //�����X�s�[�h
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))  //���N���b�N��if���N��
        {
            Vector3 touchScreenPosition = Input.mousePosition;  //�A�}�E�X�Ń^�b�`�������W��touchScreenPosition�ɁB
            touchScreenPosition.z = 5.0f;  //�A���s����O�ɗ���悤��5.0f���w��B
            Camera camera = Camera.main;  //�A
            touchWorldPosition = camera.ScreenToWorldPoint(touchScreenPosition);  //�A
        }
        player.transform.position = Vector3.MoveTowards(player.transform.position, touchWorldPosition, speed * Time.deltaTime); //player�I�u�W�F�N�g��, �ړI�n�Ɉړ�, �ړ����x
        if (PlayerNumber >= 40) //�v���C���[�̐�����40�𒴂����Ƃ�(���ׂĂ̓G��|�����Ƃ�)
        {
            SceneManager.LoadScene("GameClearScene"); //�Q�[���N���A�V�[���Ɉړ�����
        }
    }
}
