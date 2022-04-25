using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlattform : MonoBehaviour
{
    [SerializeField] private float disappear = 2f;

    private void OnTriggerEnter2D(Collider2D col)
    {
        StartCoroutine(Fall());
    }

    IEnumerator Fall()
    {
        yield return new WaitForSeconds(this.disappear);
        Destroy(this.gameObject);
    }
}
