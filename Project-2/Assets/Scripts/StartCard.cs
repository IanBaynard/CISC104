using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCard : MonoBehaviour
{

    [SerializeField] private SceneController controller;
    [SerializeField] private GameObject card_back;

    public void OnMouseDown()
    {
        if (card_back.activeSelf && controller.canReveal)
        {
            card_back.SetActive(false);
            controller.CardRevealed(this);
        }
    }

    private int _id;
    public int id
    {
        get { return _id; }
    }

    public void ChangeSprite(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image; 
    }

    public void Unreveal()
    {
        card_back.SetActive(true);
    }

}