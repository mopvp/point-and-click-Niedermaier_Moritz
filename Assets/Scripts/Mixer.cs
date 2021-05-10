using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mixer : MonoBehaviour
{   
    public Transform MixerPosition;
    public chemiker z;

    private void OnMouseDown()
    {
        // z -> chemiker
        // z.activeI -> Ingredient
        // z.active.self -> Transform
        z.activeI.self.position = MixerPosition.position;

       z.activeI.tg.isOn = true;
       z.activeI.enabled = false;

       z.activeI.self.position = z.activeI.Mixer.position;
    }
}
