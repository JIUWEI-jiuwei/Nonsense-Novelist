using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �������
/// </summary>
abstract class AbstractRole : MonoBehaviour
{
    /// <summary>������ </summary>
    public int rooleID;
    /// <summary>������� </summary>
    public string name;
    /// <summary>������� </summary>
    public string description;
    /// <summary>���Ƶ�?????���׶���˵ </summary>
    public Dictionary<int, int> restrainRole;
}
