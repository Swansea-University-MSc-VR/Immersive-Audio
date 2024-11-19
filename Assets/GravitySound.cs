using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySound : MonoBehaviour
{
    private AudioSource audioSource;
    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(rigidbody.velocity.magnitude > 0.1f)
        {
            audioSource.volume = rigidbody.velocity.magnitude / 10;
        }
        else
        {
            audioSource.volume = 0;
        }

        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
