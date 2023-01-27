using AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class GuanZhuangBingDu : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 0;
        wordName = "��״����";
        bookName = BookNameEnum.allBooks;
        gender = GenderEnum.noGender;
        camp = CampEnum.stranger;
        hp =maxHP  = 600;
        atk = 30;
        def = 60;
        psy = 25;
        san = 60;
        trait=gameObject.AddComponent<Vicious>();
        roleName = "˼��";
        attackInterval = 2.2f;

        nowTime = 0;
    }

    private void OnEnable()
    {
        cool = false;
        skillMode = gameObject.AddComponent<DamageMode>();
        allEnemy = skillMode.CalculateAgain(100, this);
        randomEnemy = allEnemy[Random.Range(0, allEnemy.Length)];   
    }

    AbstractSkillMode skillMode;

    float nowTime;
    bool cool;
    AbstractCharacter[] allEnemy;
    AbstractCharacter randomEnemy;
    private void Update()
    {
        nowTime += Time.deltaTime;
        if(cool && nowTime>1)
        {
            nowTime = 0;
            cool = true;
            if (randomEnemy != null)
            {
                skillMode.UseMode(myState.character, 10 * (1 - myState.aim.def / (myState.aim.def + 20)), myState.aim);
            }
            else
            {
                cool = true;
            }
        }
        if(!cool && nowTime>30)
        {
            nowTime = 1;
            allEnemy = skillMode.CalculateAgain(100, this);
            randomEnemy = allEnemy[Random.Range(0, allEnemy.Length)];
            cool = false;
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
