using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int kiwis = 0;
    [SerializeField] private Text kiwisText; 
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Kiwi"))
        {
            Destroy(col.gameObject);
            kiwis++;
            kiwisText.text = "Kiwis: " + kiwis;
        }
    }
}
