using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseSlime : MonoBehaviour
{
    [SerializeField] private GameObject slime;
    [SerializeField] private float power;
    [SerializeField] private ParticleSystem explosion;
    [SerializeField] private float radius;
    [SerializeField] private GameObject ball;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Vector3.Distance(slime.transform.position, ball.transform.position) < radius)
            {

                Vector3 direction = ball.transform.position - slime.transform.position;
                explosion.Play();
                ball.GetComponent<Rigidbody>().AddExplosionForce(power, direction, radius - Vector3.Distance(slime.transform.position, ball.transform.position));
                slime.SetActive(false);
            }
        }
    }
}
