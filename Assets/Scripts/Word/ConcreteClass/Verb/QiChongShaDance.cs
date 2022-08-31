using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ����ɴ֮��
/// </summary>
class QiChongShaDance : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.verb;
        skillID = 6;
        wordName = "����ɴ֮��";
        bookName = BookNameEnum.Salome;
        description = "ѧ������ɴ֮�裬����Χ�����Ѿ��ָ�5��ħ����";
        banUse.Add(gameObject.AddComponent<Girl>());
        skillMode = gameObject.AddComponent<SpecialMode>();
        skillMode.attackRange = new SingleSelector();
        percentage = 5;// �������Ѿ��ظ�5��SP
        attackDistance = 7;
        skillTime = 0;
        skillEffectsTime = 0;
        cd=maxCD=3;
        comsumeSP = 0;
        prepareTime = 0;
        afterTime = 0;
        allowInterrupt = false;
        possibility = 0;
        description = "ÿһ�ض���ж��һ�㱡ɴ�������赸������Χ���Ѿ�����������";
    }
    /// <summary>
    /// �������Ѿ��ظ�5��SP
    /// </summary>
    /// <param name="useCharacter">ʩ����</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        useCharacter.teXiao.PlayTeXiao("QiChongShaZhiWu");
        base.UseVerbs(useCharacter);
        foreach (AbstractCharacter aim in aims)
        {
            skillMode.UseMode(useCharacter,percentage, aim);
        }
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "������������Ϲ�׹��ײ�Ľ�������" + character.wordName + "��ʼ�������衣��Χ�����Ƕ��׷ױ���������������˼����ˣ����Ҹо�������������";

    }
}
