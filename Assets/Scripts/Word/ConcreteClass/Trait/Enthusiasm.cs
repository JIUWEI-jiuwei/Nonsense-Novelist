using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �����Ը�
/// </summary>
class Enthusiasm : AbstractTrait
{
    public void Awake()
    {
        traitID = 3;
        traitName = "����";
        description = "���鿪�ʵ���������δ���ϸ��ĸ���";
        growSP = 3;
        growPSY = 0.7f;
        growSAN = 1;
        restrainRole.Add(2, 0.2f);
    }
}
