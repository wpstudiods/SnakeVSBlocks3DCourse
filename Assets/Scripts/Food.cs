using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Food : MonoBehaviour
{
    public Text amountText;


    public int Amount { get; private set; }
    public AudioSource AudioSource; 
    [SerializeField]
    private int minAmount = 1;
    [SerializeField]
    private int maxAmount = 6;

    private void Start()
    {
        Amount = Random.Range(minAmount, maxAmount);
        amountText.text = Amount.ToString();
    }
    public void Play()
    {
        var audio = GetComponent<AudioSource>();
        audio.Play();
    }
}