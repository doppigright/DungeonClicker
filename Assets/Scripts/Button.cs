using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.black;
    }

    void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
