using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Food : MonoBehaviour
{
    public Text amountText;
    public AudioClip AudioClip;

    public int Amount { get; private set; }
    [SerializeField]
    private int minAmount = 1;
    [SerializeField]
    private int maxAmount = 6;

    private void Start()
    {
        Amount = Random.Range(minAmount, maxAmount);
        amountText.text = Amount.ToString();
        
    }
    private void OnColliderEnter(Collider other) 
    {
        var audio = GetComponent<AudioSource>();
        audio.PlayOneShot(AudioClip);    
    }
    
    
}