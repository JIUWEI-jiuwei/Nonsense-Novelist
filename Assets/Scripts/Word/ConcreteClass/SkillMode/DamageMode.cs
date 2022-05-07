using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �˺�����
/// </summary>
class DamageMode : AbstractSkillMode
{
    public void Awake()
    {
        skillModeID = 1;
        skillModeName = "�˺�";
    }

    /// <summary>
    /// ��Ŀ��ʵ��Ӱ��
    /// </summary>
    /// <param name="value">ʵ���˺�</param>
    /// <param name="character">Ŀ�꣨����Ŀ�����飩</param>
    public override void UseMode(AbstractCharacter useCharacter, float value, AbstractCharacter aimCharacter)
    {
        if (useCharacter != null)//���ʹ�ò������ж�
        {
            if (useCharacter.role.restrainRole.ContainsKey(aimCharacter.role.roleID))//�����߿˱�������
            {
                aimCharacter.hp -= (int)(value * (1 + useCharacter.role.restrainRole[aimCharacter.role.roleID]));
            }
            else if (aimCharacter.role.restrainRole.ContainsKey(useCharacter.role.roleID))//�������߿��ƹ�����
            {
                aimCharacter.hp -= (int)(value * (1 - aimCharacter.role.restrainRole[useCharacter.role.roleID]));
            }
        }
        else
            aimCharacter.hp -= (int)value;
    }
    /// <summary>
    /// �ٴμ���������Ŀ��
    /// </summary>
    /// <param name="character">ʩ����</param>
    /// <returns></returns>
    override public GameObject[] CalculateAgain(float attackDistance, GameObject character)
    {
        CampEnum camp = character.GetComponent<AbstractCharacter>().camp;
        GameObject[] a = attackRange.AttackRange(attackDistance, character.transform, extra);
        if (a != null)
        {
            if (camp == CampEnum.enemy)
            {
                a = CollectionHelper.FindAll<GameObject>(a, p => p.GetComponent<AbstractCharacter>().camp == CampEnum.friend);
            }
            else if (camp == CampEnum.friend)
            {
                a = CollectionHelper.FindAll<GameObject>(a, p => p.GetComponent<AbstractCharacter>().camp == CampEnum.enemy);
            }
        }
        return a;
    }
}
