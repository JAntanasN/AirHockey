using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalChecker : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pin"))
        {
            audioSource.Play();
        }
    }
}
