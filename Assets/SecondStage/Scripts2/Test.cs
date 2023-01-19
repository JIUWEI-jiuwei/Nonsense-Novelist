using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent((typeof(AbstractBook)))]
[RequireComponent(typeof(AbstractItems))]
[RequireComponent(typeof(AbstractRole))]

public class Test : MonoBehaviour
{
    public List<string> a = new List<string>();

}
