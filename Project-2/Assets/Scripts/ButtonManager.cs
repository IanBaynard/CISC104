using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private GameObject targetObject;
    [SerializeField] private string targetMessage;
    public Color highlightColor = Color.white;

    public void OnMouseOver()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            sprite.color = highlightColor;
        }
    }

    public void OnMouseExit()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            sprite.color = Color.black;
        }
    }

    public void OnMouseDown()
    {
        transform.localScale = new Vector3(0.4f, 0.4f, 1.0f);
    }

    public void OnMouseUp()
    {
        transform.localScale = new Vector3(0.3f, 0.3f, 1.0f);
        if (targetObject != null)
        {
            targetObject.SendMessage(targetMessage);
        }
    }
}

