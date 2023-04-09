using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardStack : MonoBehaviour
{
    private Stack<ScriptableObject> cards = new Stack<ScriptableObject>();

    private float turnTime = 10;

    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //how do i tell it which scriptable object to use? it says it wants the name but then it can't find them by name
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            cards.Push(ScriptableObject.CreateInstance(Death));
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            cards.Push(ScriptableObject.CreateInstance(TheHermit));
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            cards.Push(ScriptableObject.CreateInstance(TheMagician));
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            cards.Push(ScriptableObject.CreateInstance(TheMoon));
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            cards.Push(ScriptableObject.CreateInstance(TheStar));
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            cards.Push(ScriptableObject.CreateInstance(TheTower));
        }

        if (timer >= turnTime)
        {
            ShowCards();
        }
    }

    private void ShowCards()
    {
        while (cards.Count > 0)
            ScriptableObject.CreateInstance(cards.Pop());
    }
}
