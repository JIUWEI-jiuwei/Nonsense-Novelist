using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ���ڸ�������
/// </summary>
public class CharacterManager : MonoBehaviour
{
    public static GameObject father;

    private void Awake()
    {
        father = this.gameObject;
    }
}
