using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Animator timer;
    [SerializeField] private GameObject losePanel;
    [SerializeField] private GameObject pause;
    [SerializeField] private ParticleSystem losePrt;
    [SerializeField] private Rigidbody rg;
    [SerializeField] private MeshRenderer mr;
    public void Time()
    {
        losePanel.SetActive(true);
        pause.SetActive(false);
        timer.enabled = true;
        losePrt.Play();
        rg.isKinematic = true;
        mr.enabled = false;
    }
}
