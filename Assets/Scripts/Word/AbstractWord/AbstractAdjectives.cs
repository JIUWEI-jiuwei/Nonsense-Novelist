using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���ݴʣ�״̬��
/// </summary>
abstract class AbstractAdjectives : AbstractWords0
{
    /// <summary>�������</summary>
    public int adjID;
    /// <summary>������ƣ����ܻ�ø����ݴʵ���ݣ�</summary>
    public List<AbstractRole> banRole;
    /// <summary>״̬����ʱ�� </summary>
    public float maxTime;
    /// <summary>״̬Ч����״̬���ͣ���ֵ�� </summary>
    public Dictionary<AbstractAdjMode, int> effect;
}
