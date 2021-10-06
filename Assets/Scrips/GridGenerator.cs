using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    private Field[,] _fields;

    [SerializeField] private Field fieldPrefab;
    [SerializeField] private int gridWidth;
    [SerializeField] private int gridHeight;
    void Start()
    {
        _fields = new Field[gridWidth,gridHeight];
        for (int x = 0; x < gridWidth; x++)
        {
            for (int z = 0; z < gridWidth; z++)
            {
                _fields[x, z] = Instantiate(fieldPrefab, new Vector3(x, 0.0f, z), Quaternion.identity);
            }
        }

        GridSystem myGrid = new GridSystem(_fields);
    }
}
