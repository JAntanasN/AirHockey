using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Goal : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;
    int score = 0;
    AudioSource audioSource;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pin"))
        {
            scoreTxt.text = (++score).ToString();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
