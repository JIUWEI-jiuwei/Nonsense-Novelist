using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ���Ը�
/// </summary>
class NullTrait : AbstractTrait
{
    public void Awake()
    {
        traitID = 0;
        traitName = "���Ը�";
        description = "���Զ�����Ը�";
        growSP = 5;
        growPSY = 1.2f;
        growSAN = 0.7f;
    }
}
