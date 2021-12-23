using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
    public Player Player;
    public enum State
    {
        Playing,
        Won,
        Loss,
    }

    public State CurrentState { get; private set; }

    public GameObject CompleteLvl;
    public GameObject DeadLvl;
    
    public void OnPlayerDied()
    {
        if (CurrentState != State.Playing) return;

        CurrentState = State.Loss;
        Player.enabled = false;
        Debug.Log("You Loss!");
        DeadLvl.SetActive(true);

    }

    public void OnPlayerReachFinish()
    {
       if (CurrentState != State.Playing) return;

       CurrentState = State.Won;
       Player.enabled = false;
       Debug.Log("You Won!");
       CompleteLvl.SetActive(true);
    }
    
}
