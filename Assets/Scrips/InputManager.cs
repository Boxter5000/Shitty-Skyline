using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private GameObject _highlighter;
    private GameObject _highlighted;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (_highlighted == null)
                { 
                    _highlighted = Instantiate(_highlighter, hit.transform.position, Quaternion.identity);
                }

                _highlighted.transform.position = hit.transform.position;
            }
        }
    }
}
