using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��ˣ����
/// </summary>
class FireBall : AbstractVerbs
{
    public void Awake()
    {
        skillID = 10;
        wordName = " ��ˣ����";
        bookName = BookNameEnum.StudentOfWitch;
        skillMode = gameObject.AddComponent<DamageMode>();
        skillMode.attackRange =new CircleAttackSelector();//
        percentage = 1.5f;
        attackDistance = 999;
        skillTime = 0;
        skillEffectsTime = 0.3f;
        cd=0;
        maxCD=5;
        comsumeSP = 5;
        prepareTime = 0.5f;
        afterTime = 0;
        allowInterrupt = false;
        possibility = 0;
    }

    private AbstractCharacter aimState;//Ŀ��ĳ����ɫ��
    /// <summary>
    /// ���150%���������˺�
    /// </summary>
    /// <param name="useCharacter">ʩ����</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        foreach (GameObject aim in aims)
        {
            aimState = aim.GetComponent<AbstractCharacter>();
           skillMode.UseMode(useCharacter, useCharacter.atk * percentage *(1-aimState.def/(aimState.def+20)), aimState);
        }
        SpecialAbility(useCharacter);
    }
    /// <summary>
    /// ��ѣ0.3��
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        foreach(GameObject aim in aims)
        {
            AbstractCharacter a = aim.GetComponent<AbstractCharacter>();
            a.dizzyTime = skillEffectsTime;
            a.AddBuff(5);
        }
    }

    public override string PlaySentence()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null || aimState==null)
            return null;

        return character.wordName + "���˶���ָ��������������ŵ��������������֮��Ծ�����Ի��ڵĶ�����ת�Ų���"+aimState.wordName+"���˹�ȥ��";

    }
}
