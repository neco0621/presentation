using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgm : MonoBehaviour
{
    public void StopBgm()
    {
        this.GetComponent<AudioSource>().Stop();
    }

}
