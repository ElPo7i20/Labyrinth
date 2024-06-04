using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] private GameObject losePanel;
    [SerializeField] private GameObject pause;
    [SerializeField] private ParticleSystem deathPt;
    [SerializeField] private MeshRenderer mr;
    public Move mv;
    [SerializeField] private Rigidbody rg;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            rg.isKinematic = true;
            mr.enabled = false;
            mv.enabled = false;
            losePanel.SetActive(true);
            deathPt.Play();
            pause.SetActive(false);
        }
    }
}
