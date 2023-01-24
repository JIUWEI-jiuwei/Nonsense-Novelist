using AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class ShuiShou : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 5;
        wordName = "˰��";
        bookName = BookNameEnum.ElectronicGoal;
        gender = GenderEnum.noGender;
        hp =maxHP  = 220;
        atk = 5;
        def = 5;
        psy = 3;
        san = 3;
        mainProperty.Add("����","����T");
        trait=gameObject.AddComponent<ColdInexorability>();
        roleName = "¢�Ϲ�˾";
        attackInterval = 2.2f;
        attackDistance = 1;
        brief = "�����ճ�������������ľ���ѹ��";
        description = "�����ճ�������������ľ���ѹ����";
    }

    private void Start()
    {
        attackState=GetComponent<AttackState>();
    }

    AttackState attackState;
    AbstractCharacter[] aims;
    public override void AttackA()
    {
        base.AttackA();
        myState.aim = null;
        if (myState.character.aAttackAudio != null)
        {
            myState.character.source.clip = myState.character.aAttackAudio;
            myState.character.source.Play();
        }
        myState.character.charaAnim.Play(AnimEnum.attack);
        //attackA����DamageMode
        aims = attackState.attackA.CalculateAgain(10, this);
        foreach (AbstractCharacter aim in aims)
        {//��ͨ����Ϊ�����е�����ɹ�����10%���˺�������������Ч
            attackState.attackA.UseMode(myState.character, myState.character.atk*0.1f * (1 - myState.aim.def / (myState.aim.def + 20)), aim);
        }
    }

    public override void CreateBullet(GameObject aimChara)
    {
        base.CreateBullet(aimChara);
        DanDao danDao = bullet.GetComponent<DanDao>();
        danDao.aim = aimChara;
        danDao.bulletSpeed = 0.5f;
        danDao.birthTransform = this.transform;
        ARPGDemo.Common.GameObjectPool.instance.CreateObject(bullet.gameObject.name, bullet.gameObject, this.transform.position, aimChara.transform.rotation);
    }
    public override string ShowText(AbstractCharacter otherChara)
    {
        if (otherChara != null)
            return otherChara.wordName + "���ѿ�������һ�����ã�ϸ�����ݣ�ֻ������㣬����΢΢���о�ʱ��毻���ˮ���ж������������磬" + otherChara.wordName + "Ц������������ã����������ġ�";
        else
            return null;
    }
    public override string CriticalText(AbstractCharacter otherChara)
    {
        if (otherChara != null)
            return "���Ҿ�֪�������˲���ʣ�µ�Ҳ�����ҡ�������������һ�仨�꣬��" + otherChara.wordName + "��ȥ";
        else
            return null;
    }

    public override string LowHPText()
    {
        return "�������Ů��Ϣ���������ϻ���ա����㽫һ�����ӣ�һ��ʫ��پ��ڻ����С�";
    }
    public override string DieText()
    {
        return "�����񡭱�����á���������û˵��������˫�ۡ�";
    }

}
