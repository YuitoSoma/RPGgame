using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speeder : MonoBehaviour
{
    public float speed = 5.0f;
    public Collider playerCollider;
    public AudioSource speedSound;

    private void Start()
    {
        speedSound = GetComponent<AudioSource>();
    }
}
