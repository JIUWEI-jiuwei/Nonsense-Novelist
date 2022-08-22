using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��ˣ����
/// </summary>
class FireBall : AbstractVerbs
{
    private GameObject bullet;

    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.verb;
        skillID = 10;
        wordName = "��ˣ����";
        bookName = BookNameEnum.StudentOfWitch;
        description = "ѧ����ˣ�������150%���������˺�����ѣ0.3�롣";
        skillMode = gameObject.AddComponent<DamageMode>();
        skillMode.attackRange = new CircleAttackSelector();//
        percentage = 1.5f;
        attackDistance = 999;
        skillTime = 0;
        skillEffectsTime = 0.3f;
        cd = 0;
        maxCD = 5;
        comsumeSP = 5;
        prepareTime = 0.5f;
        afterTime = 0;
        allowInterrupt = false;
        possibility = 0;
        description = "�������˺����׵��Ӽ���Ϸ��";

        bullet = Resources.Load<GameObject>("FirstStageLoad/" + "bullet/Fireball_bullet");
    }

    private AbstractCharacter aimState;//Ŀ��ĳ����ɫ��
    /// <summary>
    /// ���150%���������˺�
    /// </summary>
    /// <param name="useCharacter">ʩ����</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        if (aims != null)
        {
            aimState = aims[0].GetComponent<AbstractCharacter>();
            skillMode.UseMode(useCharacter, useCharacter.atk * percentage * (1 - aimState.def / (aimState.def + 20)), aimState);
            SpecialAbility(useCharacter);
        }
    }
    /// <summary>
    /// ��ѣ0.3��
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        DanDao danDao = bullet.GetComponent<DanDao>();
            danDao.aim = aims[0];
            danDao.bulletSpeed = 0.5f;
            danDao.birthTransform = this.transform;
            ARPGDemo.Common.GameObjectPool.instance.CreateObject(bullet.gameObject.name, bullet.gameObject, this.transform.position, aims[0].transform.rotation);

            AbstractCharacter a = aims[0].GetComponent<AbstractCharacter>();
            a.dizzyTime = skillEffectsTime;
            a.AddBuff(5);
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null || aimState == null)
            return null;

        return character.wordName + "���˶���ָ��������������ŵ��������������֮��Ծ�����Ի��ڵĶ�����ת�Ų���" + aimState.wordName + "���˹�ȥ��";

    }
}
