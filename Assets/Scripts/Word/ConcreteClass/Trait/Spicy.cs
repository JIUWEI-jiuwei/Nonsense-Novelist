using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ���Ը�
/// </summary>
class Spicy : AbstractTrait
{
    public void Awake()
    {
        traitID = 4;
        traitName = "��";
        description = "���ͱ��˾������һ����������˵�����";
        growSP = 5;
        growPSY = 1.5f;
        growSAN = 0.6f;
        restrainRole.Add(1, 0.2f);
        restrainRole.Add(2, 0.2f);
        restrainRole.Add(5, 0.2f);
    }
}
