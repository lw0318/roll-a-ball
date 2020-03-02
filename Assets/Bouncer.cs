using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    [SerializeField]
    public float bouncepower = 100;
    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        PlayerController pc = collision.gameObject.GetComponent<PlayerController>();

        Vector3 bounce = Vector3.Reflect(pc.lastvelocity, collision.contacts[0].normal);
        Debug.Log("velocity" + rb.velocity);
        Debug.Log("bounce" + bounce * bouncepower);

        rb.AddForce(bounce.normalized * bouncepower);
    }
}