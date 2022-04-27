using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ˤ
/// </summary>
class FallBadly : AbstractVerbs
{
    public void Awake()
    {
        skillID = 4;
        wordName = "ˤ";
        bookName = BookNameEnum.HongLouMeng;
        description = "������������ˤ��Է�";
        nickname.Add("��");
        nickname.Add("˦");
        nickname.Add("Ͷ��");
        skillMode = new DamageMode();
        skillMode.attackRange =new CircleAttackSelector();//
        percentage = 1.5f;
        attackDistance = 6;
        skillTime = 0f;
        skillEffectsTime = 1.5f;
        cd=0;
        maxCD=6;
        comsumeSP = 0;
        prepareTime = 0.5f;
        afterTime = 0;
        allowInterrupt = false;
        possibility = 0;
    }

    private AbstractCharacter aimState;//Ŀ��ĳ����ɫ��
    /// <summary>
    /// ���150%���������˺�
    /// </summary>
    /// <param name="character">ʩ����</param>
    public override void UseVerbs(AbstractCharacter character)
    {
        base.UseVerbs(character);
        foreach (GameObject aim in aims)
        {
            aimState = aim.GetComponent<AbstractCharacter>();
           skillMode.UseMode(character, character.atk * percentage - aimState.def * 0.6f, aimState);
        }
        SpecialAbility();
    }
    /// <summary>
    /// ��ѣ1.5��
    /// </summary>
    public override void SpecialAbility()
    {

    }
}
