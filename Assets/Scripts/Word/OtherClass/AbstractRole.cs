using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �������
/// </summary>
abstract class AbstractRole : MonoBehaviour
{
    /// <summary>������ </summary>
    public int roleID;
    /// <summary>������� </summary>
    public string roleName;
    /// <summary>������� </summary>
    public string description;
    /// <summary>���Ƶ���ݣ�����ǿ�ȣ�С���� </summary>
    public Dictionary<AbstractRole, float> restrainRole;
}
