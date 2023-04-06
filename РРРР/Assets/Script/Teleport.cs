using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.OnClicked += Teleporting;
    }


    private void OnDisable()
    {
        EventManager.OnClicked -= Teleporting;
    }


    private void Teleporting()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(1.0f, 3.0f);
        transform.position = pos;
    }
}
