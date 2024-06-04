using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] private GameObject winPanel;
    [SerializeField] private GameObject pause;
    [SerializeField] private ParticleSystem winPt;
    [SerializeField] private Animator slimeWin;
    [SerializeField] private Animator timer;
    [SerializeField] private Rigidbody rg;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            winPanel.SetActive(true);
            winPt.Play();
            pause.SetActive(false);
            slimeWin.SetBool("Win", true);
            timer.enabled = false;
            rg.isKinematic = true;
            slimeWin.SetBool("Win", true);
        }
    }
}
