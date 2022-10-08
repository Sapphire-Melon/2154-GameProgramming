using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] public Audio audioController;
    public ParticleSystem sparkle;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Gem"))
        {
            SparkleGem();
            audioController.PlayCollectSound();
            Destroy(collision.gameObject);
        }
    }

    private void SparkleGem()
    {
        sparkle.Play();
    }
}
