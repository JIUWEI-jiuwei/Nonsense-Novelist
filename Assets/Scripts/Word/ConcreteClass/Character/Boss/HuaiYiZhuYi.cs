using AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class HuaiYiZhuYi : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 0;
        wordName = "��������";
        bookName = BookNameEnum.allBooks;
        gender = GenderEnum.noGender;
        camp = CampEnum.stranger;
        hp =maxHP  = 350;
        atk = 10;
        def = 30;
        psy = 15;
        san = 30;
        trait=gameObject.AddComponent<Sentimental>();
        roleName = "˼��";
        attackInterval = 2.2f;
    }
    private void Start()
    {
        skillMode = gameObject.AddComponent<DamageMode>();
    }

    AbstractSkillMode skillMode;
    AbstractCharacter[] aims;
    float record;
    public override void AttackA()
    {
        base.AttackA();
        aims = skillMode.CalculateAgain(100, this);
        //��ȡ����ÿ������5����־���������Լ�����
        foreach(AbstractCharacter aim in aims)
        {
            record = aim.san;
            aim.san -= 5;
            record = record - aim.san;
            san += record;
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
