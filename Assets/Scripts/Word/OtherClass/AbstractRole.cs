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
    /// <summary>���Ƶ�?????���׶���˵ </summary>
    public Dictionary<int, int> restrainRole;
}
