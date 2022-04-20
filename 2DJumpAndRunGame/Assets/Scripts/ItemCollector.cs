using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int collectables = 0;
    [SerializeField] private Text collectablesCounter; 
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Collectable"))
        {
            Destroy(col.gameObject);
            collectables++;
            collectablesCounter.text = "Collectable: " + collectables;
        }
    }
}
