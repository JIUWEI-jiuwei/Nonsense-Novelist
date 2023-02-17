using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��ˣ����
/// </summary>
class FireBall_x : AbstractVerbs
{
    private GameObject bullet;

    public override void Awake()
    {
        base.Awake();
        skillID = 10;
        wordName = "��ˣ����";
        bookName = BookNameEnum.StudentOfWitch;

        skillMode = gameObject.AddComponent<DamageMode>();
        skillMode.attackRange = new SingleSelector();
        skillEffectsTime = 0.3f;
        needCD = 5;
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
       /* if (aims != null)
        {
            skillMode.UseMode(useCharacter, useCharacter.atk  * (1 - aims[0].def / (aims[0].def + 20)), aims[0]);
            SpecialAbility(useCharacter);
        }*/
    }
    /// <summary>
    /// ��ѣ0.3��
    /// </summary>
    public override void BasicAbility(AbstractCharacter useCharacter)
    {
       /* DanDao danDao = bullet.GetComponent<DanDao>();
            danDao.aim = aims[0].gameObject;
            danDao.bulletSpeed = 0.5f;
            danDao.birthTransform = this.transform;
            ARPGDemo.Common.GameObjectPool.instance.CreateObject(bullet.gameObject.name, bullet.gameObject, this.transform.position, aims[0].transform.rotation);

        aims[0].dizzyTime = skillEffectsTime;
        aims[0].AddBuff(5);*/
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null || aimState == null)
            return null;

        return character.wordName + "���˶���ָ��������������ŵ��������������֮��Ծ�����Ի��ڵĶ�����ת�Ų���" + aimState.wordName + "���˹�ȥ��";

    }
}
