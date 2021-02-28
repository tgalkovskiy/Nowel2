using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManeger : MonoBehaviour
{
    [SerializeField] private AudioSource MainAudio;
    [SerializeField] private Slider Volume;

    private void Update()
    {
        MainAudio.volume = Volume.value;
    }
}
