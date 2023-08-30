using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public int EnemyNumber;
    public GameObject LevelText;
    public GameObject textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            if (PlayerController.PlayerNumber > EnemyNumber)
            {
                PlayerController.PlayerNumber += EnemyNumber;
                Destroy(this.gameObject);
                Destroy(textMeshPro);
            }
            else
            {
                SceneManager.LoadScene("GameOverScene");
            }
        }
    }
}
