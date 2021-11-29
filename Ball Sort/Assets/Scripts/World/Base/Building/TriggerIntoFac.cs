using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerIntoFac : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player"))
            Debug.Log("Switch to Gun Factory Scene");
    }
}
