using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    private GameObject _buildGameObject;
    
    private GameObject BuildGammeObject { get; }

    private bool IsBuild { get; }

    public bool BuilHere(GameObject building)
    {
        if (!IsBuild)
        {
            _buildGameObject = building;
            return true;
        }

        return false;
    }
}
