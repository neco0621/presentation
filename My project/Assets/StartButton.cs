using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnClick()
    {
        SceneManager.LoadScene("SampleScene");
        PlayerController.PlayerNumber = 5;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
