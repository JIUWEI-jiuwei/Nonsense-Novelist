using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���ݴʣ�����Ⱦ��
/// </summary>
public class HeWuRan : AbstractAdjectives
{
    static public string s_description = "<color=#dd7d0e>�ж�</color>������10s";
    static public string s_wordName = "����Ⱦ��";
    public override void Awake()
    {  
        base.Awake();
        adjID = 11;
        wordName = "����Ⱦ��";
        bookName = BookNameEnum.ElectronicGoal;
<<<<<<< HEAD
        description = "<color=#dd7d0e>�ж�</color>������10s";
=======
        description = "�ж�������10s";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454

        skillMode = gameObject.AddComponent<DamageMode>();

        skillEffectsTime = 10;
        rarity = 1;
      
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision")) 
            wordCollisionShoots[0]=gameObject.AddComponent<ChuanBoCollision>();
<<<<<<< HEAD
    }


    override public string[] DetailLable()
    {
        string[] _s = new string[2];
        _s[0] = "ChuanBoCollision";
        _s[1] = "Toxic";
        return _s;
=======
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        aimCharacter.gameObject.AddComponent<Toxic>()
            .maxTime = skillEffectsTime;
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
    }

    

    public override void End()
    {
        base.End();
    }

}
