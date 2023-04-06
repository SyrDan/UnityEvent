using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private Renderer rend;
    private void Start()
    {
        rend = GetComponent<Renderer>();
    }
    void OnEnable()
    {
        EventManager.OnClicked += TurnColor;
    }


    void OnDisable()
    {
        EventManager.OnClicked -= TurnColor;
    }


    void TurnColor()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        rend.material.color = col;
    }
}
