using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneDisplay : MonoBehaviour
{
    public Plane plane;
    public MeshRenderer bodyRenderer;
    public MeshRenderer wingRenderer;

    public Material klmMaterial;
    public Material ryanAirMaterial;
    public Material transaviaMaterial;

    void Start()
    {
        if (plane.company == Plane.Company.KLMRoyalDutchAirlines)
        {
            bodyRenderer.material = klmMaterial;
            wingRenderer.material = klmMaterial;
        }
        else if (plane.company == Plane.Company.RyanAir)
        {
            bodyRenderer.material = ryanAirMaterial;
            wingRenderer.material = ryanAirMaterial;
        }
        else if (plane.company == Plane.Company.Transavia)
        {
            bodyRenderer.material = transaviaMaterial;
            wingRenderer.material = transaviaMaterial;
        }
    }
}
