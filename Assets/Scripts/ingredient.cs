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
    public Transform platePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("Ingredient angeklickt");

        self.position = handPosition.position;

        x.activeI = this;
    }
}
