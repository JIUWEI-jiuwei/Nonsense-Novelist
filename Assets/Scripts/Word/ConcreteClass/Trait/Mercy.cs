using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �ȱ��Ը�
/// </summary>
class Mercy :AbstractTrait
{
    public void Awake()
    {
        traitID = 7;
        traitName = "�ȱ�";
        description = "��ϧ�������ƴ�����";
        growSP = 3;
        growPSY = 0.9f;
        growSAN = 1.2f;
        restrainRole.Add(4, 0.3f);
    }
}
