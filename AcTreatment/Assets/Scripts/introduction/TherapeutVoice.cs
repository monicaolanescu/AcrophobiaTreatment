﻿using System.Collections;
using UnityEngine;

public class TherapeutVoice : MonoBehaviour
{
    public static AudioSource cybersickness;
    
    void Start()
    {
        Debug.Log("[TherapeutVoice] Start()");
        cybersickness = GetComponent<AudioSource>();
        StartCoroutine(takeCareOfCyberSickness());
    }
    
    IEnumerator takeCareOfCyberSickness()
    {
        Debug.Log("[TherapeutVoice] cybersickness audio source play");
        yield return new WaitForSeconds(5);
        cybersickness.Play();
    }
}
