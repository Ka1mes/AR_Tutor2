using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardTemplate : MonoBehaviour
{
    public bool renderIngame = false;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = renderIngame;
    }

    void Update()
    {
        gameObject.GetComponent<Renderer>().enabled = renderIngame;
    }

}
