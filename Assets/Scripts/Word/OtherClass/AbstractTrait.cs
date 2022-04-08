using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �����Ը񡾲��á�
/// </summary>
abstract class AbstractTrait : MonoBehaviour
{
    /// <summary>�Ը�ID </summary>
    public int traitID;
    /// <summary>�Ը��� </summary>
    public string traitName;
    /// <summary>�Ը����� </summary>
    public string description;
    /// <summary>���Ƶ�?????���׶���˵</summary>
    public Dictionary<int, int> restrainRole;
}
