using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Water : MonoBehaviour
{
    public PostProcessVolume postProcessing;
    private void FixedUpdate()
    {
        if (this.transform.position.y < 5.88)
        {
            postProcessing.enabled = true;
        }
        else
        {
            postProcessing.enabled = false;

        }
    }
}
