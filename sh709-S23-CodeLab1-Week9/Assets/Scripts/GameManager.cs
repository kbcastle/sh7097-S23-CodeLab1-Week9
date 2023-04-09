using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public List<ScriptableObject> cardList = new List<ScriptableObject>();
    public Sprite card1;
    public Sprite card2;
    public Sprite card3; 
    int listIndex;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (card1 = null)
            {
                listIndex = Random.Range(0, 5);
                card1 = cardList[listIndex].GetComponent<Sprite>();
                cardList.RemoveAt(listIndex);
            }
            else
            {
                if (card2 = null)
                {
                    listIndex = Random.Range(0, 4);
                    card2 = cardList[listIndex].GetComponent<Sprite>();
                    cardList.RemoveAt(listIndex);
                }
                else
                {
                    listIndex = Random.Range(0, 3);
                    card3 = cardList[listIndex].GetComponent<Sprite>();
                    cardList.Clear();
                    cardList.Add(CardsScriptableObjects);
                    
                }
            }//trying to make grab bag style random card selection - 
            //select three cards, every time a card is selected, delete it from the lsit so it can't be listed again,
            //once three cards are selected, on next space bar press delete rest of the list and fill it up again with all cards to start over
            
        }
    }
}