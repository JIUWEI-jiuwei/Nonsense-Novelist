using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TTtool 
{
    static public TTtool instance;
    public void PrintArray<T>(T[] _array)where T : AbstractWord0
    {
        
        for (int i = 0; i < _array.Length; i++)
        {
            Debug.Log("Ä¿±ê" + i + ":" + _array[i].wordName);
        }
    }
}
