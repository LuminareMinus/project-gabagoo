using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlaying : MonoBehaviour
{
    public AudioSource Click;

    public void PlayClick() {
        Click.Play();
    }
}
