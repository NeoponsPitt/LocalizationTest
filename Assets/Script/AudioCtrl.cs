using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCtrl : MonoBehaviour
{
    public AudioSource audioSoure;

private void OnEnable() {
    audioSoure.PlayOneShot(audioSoure.clip);
}

}
