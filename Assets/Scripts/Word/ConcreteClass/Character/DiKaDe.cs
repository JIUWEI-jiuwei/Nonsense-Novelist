using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class DiKaDe : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 9;
        wordName = "�ҿ���";
        bookName = BookNameEnum.ElectronicGoal;
        gender = GenderEnum.boy;
        hp =maxHP  = 120;
        atk = 4;
        def = 4;
        psy = 3;
        san = 3;
        mainProperty.Add("����","Զ��dps");
        trait=gameObject.AddComponent<Persistent>();
        criticalChance = 0;
        attackInterval = 1.8f;
        attackDistance = 5;
        importantNum.AddRange(new int[] { 8 });
        brief = "����¥�Ρ���һλ�Ը����д�����ȴ�ּ������Ե���Ů��";
        description = "�������й��ŵ���������¥�Ρ���Ů���ǣ�����ʮ��������˫��֮һ��������Ӱ�����ɲ�ת��������ڼֱ���Ѧ���δ��֮ҹ�ᾡ���š���������ò����������ʫ�ţ��ǹŴ���ѧ��Ʒ�м��������ľ���Ů������" +
            "\n���ǣ�" +
            "\n��̾ͣ���£�����ӽ���š�" +
            "\n������йң�����ѩ����";
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
