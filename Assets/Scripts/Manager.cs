using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    GameObject[] Planes;
    GameObject[] Hangars;

    void Start()
    {
        Planes = GameObject.FindGameObjectsWithTag("Plane");
        Hangars = GameObject.FindGameObjectsWithTag("Hangar");

        for (int i = 0; i < Hangars.Length; i++)
        {
            Hangar hangar = Hangars[i].GetComponent<Hangar>();
            hangar.number = i + 1;
            hangar.SetNumberInTextMesh();
        }

        for(int i = 0; i < Planes.Length; i++)
        {
            Planes[i].GetComponent<PlaneAI>().number = i + 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickPark()
    {
        foreach(GameObject plane in Planes)
        {
            GameObject correctHangar = FindCorrectHangar(plane.GetComponent<PlaneAI>().number);
            Park(plane, correctHangar);
        }
    }

    private GameObject FindCorrectHangar(int planeNumber)
    {
        foreach(GameObject hangar in Hangars)
        {
            if (hangar.GetComponent<Hangar>().number == planeNumber)
            {
                return hangar;
            }
        }
        GameObject backupHangar = new GameObject();
        backupHangar.transform.position = Vector3.zero;
        return backupHangar;
    }

    private void Park(GameObject plane, GameObject hangar)
    {
        PlaneAI planeAI = plane.GetComponent<PlaneAI>();
        planeAI.agent.SetDestination(hangar.GetComponent<Hangar>().transform.position);
        planeAI.isParked = true;
    }

    private void TurnOnParkingLight(GameObject hangar)
    {
        hangar.GetComponentInChildren<Light>().color = Color.green;
    }

    public void OnClickLight()
    {
        foreach (GameObject plane in Planes)
        {
           TurnOnLights(plane.GetComponentsInChildren<Light>());
        }
    }

    private void TurnOnLights(Light[] lights)
    {
        foreach(Light light in lights)
        {
            light.intensity = 0.5f;
        }
    }
}
