using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ����Ը�
/// </summary>
class Inexorability : AbstractTrait
{
    public void Awake()
    {
        traitID = 2;
        traitName = "���";
        description = "���ı��䵫��������˸е�ͷ��";
        growSP = 5;
        growPSY = 1.3f;
        growSAN = 0.7f;
        restrainRole.Add(1, 0.2f);
        restrainRole.Add(6, 0.5f);
}
}
