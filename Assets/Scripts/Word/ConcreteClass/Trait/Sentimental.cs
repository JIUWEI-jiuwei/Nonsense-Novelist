using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �����Ը�
/// </summary>
class Sentimental :AbstractTrait
{
    public void Awake()
    {
        traitID = 1;
        traitName = "����";
        description = "��������ȴ�ּ����ж��������Ը�";
        growSP = 8;
        growPSY = 1.7f;
        growSAN = 0.3f;
        restrainRole.Add(3, 0.1f);
        restrainRole.Add(6, 0.5f);
    }
}
