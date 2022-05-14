using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingPlattform : MonoBehaviour
{
    [SerializeField] private float disappear = 2f;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            StartCoroutine(Fall());
        }
    }

    IEnumerator Fall()
    {
        yield return new WaitForSeconds(this.disappear);
        Destroy(this.gameObject);
    }
}
