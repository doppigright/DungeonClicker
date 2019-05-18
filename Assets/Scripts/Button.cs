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

    [System.Obsolete]
    private void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "play":
                Application.LoadLevel("Dungeon&Home");
                break;
            case "cog":
                Application.LoadLevel("Settings");
                break;
            case "sideswipe":
                Application.LoadLevel("Menu");
                break;
            case "hut":
                Application.LoadLevel("Home");
                break;
            case "dungeon-gate":
                Application.LoadLevel("Dungeon");
                break;
        }
    }
}
