using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ���Ը�
/// </summary>
class Obsessed : AbstractTrait
{
    public void Awake()
    {
        traitID = 6;
        traitName = "��";
        description = "��̰���������������";
        growSP = 8;
        growPSY = 1.1f;
        growSAN = 0.4f;
        restrainRole.Add(2, 0.2f);
        restrainRole.Add(5, 0.5f);
        restrainRole.Add(7, 0.5f);
    }
}
