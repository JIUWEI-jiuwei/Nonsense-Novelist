using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �����Ը񡾲��á�
/// </summary>
abstract public class AbstractTrait : MonoBehaviour
{
    /// <summary>�Ը�ID </summary>
    public int traitID;
    /// <summary>�Ը��� </summary>
    public string traitName;
    /// <summary>�Ը����� </summary>
    public string description;
    /// <summary>�����ɳ� </summary>
    public int growSP;
    /// <summary>�������ɳ� </summary>
    public float growPSY;
    /// <summary>��־���ɳ� </summary>
    public float growSAN;
    /// <summary>�ܿ��Ƶ��Ը���ţ�����ǿ�ȣ�С����</summary>
    public Dictionary<int, float> restrainRole=new  Dictionary<int, float>();
}
