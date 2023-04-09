using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NewCard", menuName = "Card")]
public class CardsScriptableObjects : ScriptableObject
{
   public Sprite cardImage;
   public string cardName;
}
