using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage1Button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnClick()
    {
        SceneManager.LoadScene("Stage1");
        PlayerController.PlayerNumber = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
