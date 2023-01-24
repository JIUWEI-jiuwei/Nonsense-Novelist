using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 挂在父物体上
/// </summary>
public class CharacterManager : MonoBehaviour
{
    public static GameObject father;

    private void Awake()
    {
        father = this.gameObject;
    }
}
