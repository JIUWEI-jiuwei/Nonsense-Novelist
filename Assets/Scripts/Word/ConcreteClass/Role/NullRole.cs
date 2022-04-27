using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �����
/// </summary>
class NullRole : AbstractRole
{
    public void Awake()
    {
        roleID = 0;
        roleName = "�����";
        description = "���Զ�������";
        growHP = 5;
        growATK = 1.2f;
        growDEF = 1;
        restrainRole.Add(3, 0.1f);
        restrainRole.Add(6, 0.3f);
    }
}
