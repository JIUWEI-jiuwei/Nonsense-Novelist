using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��������
/// </summary>
abstract public class AbstractSkillMode : MonoBehaviour
{
    /// <summary>�����������</summary>
    public int skillModeID;
    /// <summary>������������</summary>
    public string skillModeName;
    /// <summary>Ŀ���������ȼ�(���ã�</summary>
    //public List<AbstractRole> roleOrder=new List<AbstractRole>();
    /// <summary>Ŀ���Ը����ȼ�(���ã�</summary>
    //public List<AbstractTrait> traitOrde=new List<AbstractTrait>();

    /// <summary>Ӱ������ֱ�ߡ����Ρ�Բ�Σ�</summary>
    public IAttackRange attackRange=new SingleSelector();

    /// <summary>
    /// �ٴμ���������Ŀ��
    /// </summary>
    /// <param name="character">ʩ����</param>
    /// <returns></returns>
    abstract public AbstractCharacter[] CalculateAgain(int attackDistance, AbstractCharacter character);
    /// <summary>
    /// ��Ŀ��ʵ��Ӱ��
    /// </summary>
    /// <param name="useCharacter">������</param>
    /// <param name="value">ֵ</param>
    /// <param name="aimCharacter">Ŀ�꣨����Ŀ�����飩</param>
    abstract public void UseMode(AbstractCharacter useCharacter ,float value,AbstractCharacter aimCharacter);    
}