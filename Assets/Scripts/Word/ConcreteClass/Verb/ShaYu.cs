using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
class ShaYu : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 4;
        wordName = "ɳԡ";
        bookName = BookNameEnum.ZooManual;
        skillMode = gameObject.AddComponent<SelfMode>();
        skillEffectsTime = 10;
        rarity = 2;
        needCD = 4;
    }

    /// <summary>
    /// ����
    /// </summary>
    /// <param name="useCharacter">ʩ����</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        buffs.Add(gameObject.AddComponent<KangFen>());
        buffs[0].maxTime = skillEffectsTime;
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "�ּ�ʢ�����һ������Ʈ���ڵء�\n"+character.wordName+"��Ʈ���ڵص��һ���£���ţ����������ᣬΪ�䰧��������л���ɻ����죬����������˭������";

    }
    
}
