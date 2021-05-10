using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ingredient : MonoBehaviour
{
    public Transform handPosition;
    public Transform self;
    public chemiker x;
    public Toggle tg;
    public Transform Mixer;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("Ingredient angeklickt");

        self.position = handPosition.position;

        //x.activeI = this;
    }
}
