using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage2Button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnClick()
    {
        SceneManager.LoadScene("Stage2");
        Player2.PlayerNumber = 80;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
