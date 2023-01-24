using AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class BeiLuoJi : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 10;
        wordName = "���弧������";
        bookName = BookNameEnum.PHXTwist;
        gender = GenderEnum.noGender;
        hp =maxHP  = 100;
        atk = 0;
        def = 4;
        psy = 3;
        san = 5;
        mainProperty.Add("��־","��");
        trait=gameObject.AddComponent<Mercy>();
        attackInterval = 2.2f;
        attackDistance = 5;
        brief = "����¥�Ρ���һλ�Ը����д�����ȴ�ּ������Ե���Ů��";
        description = "�������й��ŵ���������¥�Ρ���Ů���ǣ�����ʮ��������˫��֮һ��������Ӱ�����ɲ�ת��������ڼֱ���Ѧ���δ��֮ҹ�ᾡ���š���������ò����������ʫ�ţ��ǹŴ���ѧ��Ʒ�м��������ľ���Ů������" +
            "\n���ǣ�" +
            "\n��̾ͣ���£�����ӽ���š�" +
            "\n������йң�����ѩ����";
    }

    private void Start()
    {
        attackState = GetComponent<AttackState>();
        Destroy(attackState.attackA);
        attackState.attackA = gameObject.AddComponent<CureMode>();
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
        aims = attackState.attackA.CalculateAgain(10, this);
        foreach (AbstractCharacter aim in aims)
        {//��ͨ����Ŀ��Ϊ���ж��ѣ��ָ�70%��־��Ѫ��������������������Ч
            attackState.attackA.UseMode(myState.character, san * 0.7f, aim) ;
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
