using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystem
{
    private Field[,] _fields;
    
    public GridSystem(Field[,] fields)
    {
        _fields = fields;
    }
}
