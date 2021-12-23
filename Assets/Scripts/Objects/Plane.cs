using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Plane", menuName = "Plane")]
public class Plane : ScriptableObject
{
    public string type;
    public enum Company { KLMRoyalDutchAirlines, RyanAir, Transavia };
    public Company company;
}
