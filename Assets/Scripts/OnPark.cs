using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPark : MonoBehaviour
{
    public Light hangarLight;

    private void OnTriggerEnter(Collider other)
    {
        hangarLight.color = Color.green;
    }

    private void OnTriggerExit(Collider other)
    {
        hangarLight.color = Color.red;
    }
}
