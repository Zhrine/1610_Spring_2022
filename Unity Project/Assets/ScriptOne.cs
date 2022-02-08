using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Update()
    {
        if (input.getkeydown(keycode.R))
        {
            GetComponent<Renderer>().material.color = Color.Red;
        }
        if (input.getkydown(keycode.g))
        {
            GetComponent<Renderer>().material.color = Color.Green;
        }
        if (input.getkeydown(keycode.B))
        {
            GetComponent<Renderer>().material.color = Color.Blue;
        }
    }
}
