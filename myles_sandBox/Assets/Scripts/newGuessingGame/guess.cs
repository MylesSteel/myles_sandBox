using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guess : MonoBehaviour
{

    [SerializeField]
    recipe rS;                      //refrence to recipe script
    public GameObject[] guesses;        //public gameobject array to be populated by on mouse down.
    public int guessCount = 0;        //public int used to track amount of guesses on each click. 

    public void PlayerGuessCheck()
    {
        if (guessCount == guesses.Length -1)
        {
            for (int i = 0; i < guesses.Length; i++)
            {
                if (guesses[i] == rS.correctAnswer[i])
                {
                    Debug.Log("Correct");
                }
                else
                {
                    Debug.Log("Incorrect.");
                }
            }
        }
    }
}
