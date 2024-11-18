using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float lifetime = 5f;
    private AudioSource audioSource;
    public AudioClip coinCollected;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifetime);
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D whatDidIHit)
    {
        if (whatDidIHit.CompareTag("Player"))
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().EarnScore(1);
            audioSource.PlayOneShot(coinCollected);
            Destroy(gameObject);
        }
    }
}
