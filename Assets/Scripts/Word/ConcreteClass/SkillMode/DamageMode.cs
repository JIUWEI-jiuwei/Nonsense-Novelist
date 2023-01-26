using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �˺�����
/// </summary>
class DamageMode : AbstractSkillMode
{
    /// <summary>�Ƿ�Ϊ�����˺���������չʾ�� </summary>
    public bool isPhysics=true;
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
        if (useCharacter != null)//��ɫʹ��
        {
            /*float a = Random.Range(0, 100);//�����齱
            if (a <= useCharacter.criticalChance * 100)//����
            {
                value *= useCharacter.multipleCriticalStrike;
                aimCharacter.teXiao.PlayTeXiao("BaoJi");
                AbstractBook.afterFightText += useCharacter.CriticalText(aimCharacter);
            }*/
                aimCharacter.hp -= value;
        }
        else//���ʹ�ã����ݴʣ�
            aimCharacter.hp -= (int)value;
    }
    /// <summary>
    /// �ٴμ���������Ŀ��
    /// </summary>
    /// <param name="character">ʩ����</param>
    /// <returns></returns>
    override public AbstractCharacter[] CalculateAgain(int attackDistance, AbstractCharacter character)
    {
        AbstractCharacter[] a = attackRange.CaculateRange(attackDistance, character.situation, NeedCampEnum.enemy);
        return a;
    }
}
