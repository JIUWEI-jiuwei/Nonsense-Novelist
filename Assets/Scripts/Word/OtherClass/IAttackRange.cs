using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Ӱ������ֱ�ߡ����Ρ�Բ�Σ�
/// </summary>
public interface  IAttackRange
{
    /// <summary>
    /// ����Ӱ��������Ŀ��
    /// </summary>
    /// <param name="attackDistance">���</param>
    /// <param name="ownTrans">ʹ����λ��</param>
    /// <param name="extra">����ֵ</param>
    /// <returns>����������Ŀ������</returns>
    abstract public GameObject[] AttackRange(float attackDistance,Transform ownTrans,float extra);
}
