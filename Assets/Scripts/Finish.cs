using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameState GameState;

      private void OnCollisionEnter(Collision collision)
     {
         GameState.OnPlayerReachFinish();
     }
    
 }

