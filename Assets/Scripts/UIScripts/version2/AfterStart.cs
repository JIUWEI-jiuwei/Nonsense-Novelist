using UnityEngine.UI;
using UnityEngine;

/// <summary>
/// combat after start
/// </summary>
public class AfterStart : MonoBehaviour
{
    /// <summary>角色简要预制体（手动挂）</summary>
    private GameObject charaShortInstance;
    /// <summary>角色简要预制体克隆</summary>
    private GameObject charaShort;
    /// <summary></summary>
    private bool one;

    private void Start()
    {
        charaShortInstance = Resources.Load<GameObject>("CharacterShort");
    }
    private void OnMouseOver()
    {

        //颜色变黄
        GetComponent<SpriteRenderer>().color = new Color((float)255 / 255, (float)225 / 255, (float)189 / 255, (float)255 / 255);

        if (!one)
        {
            one = true;
            //显示角色简要信息(注意第二个参数对于UI)
            charaShort = Instantiate(charaShortInstance,this.transform.GetComponentInChildren<Canvas>().gameObject.transform);

            //给角色简要赋值
            AbstractCharacter abschara = GetComponent<AbstractCharacter>();
            //name
            charaShort.transform.GetChild(0).GetComponent<Text>().text = abschara.wordName;
            //HP
            charaShort.transform.GetChild(1).GetComponentInChildren<Text>().text = abschara.hp.ToString() + "/" + abschara.maxHp.ToString();
            //ATK
            charaShort.transform.GetChild(2).GetComponentInChildren<Text>().text = IntToString.SwitchATK(abschara.atk);
            //def
            charaShort.transform.GetChild(3).GetComponentInChildren<Text>().text = IntToString.SwitchATK(abschara.def);
            //san
            charaShort.transform.GetChild(4).GetComponentInChildren<Text>().text = IntToString.SwitchATK(abschara.san);
            //psy
            charaShort.transform.GetChild(5).GetComponentInChildren<Text>().text = IntToString.SwitchATK(abschara.psy);
        }
    }
    private void OnMouseExit()
    {
        //颜色恢复
        GetComponent<SpriteRenderer>().color = new Color((float)255 / 255, (float)255 / 255, (float)255 / 255, (float)255 / 255);

        if (one)
        {
            //角色简要不显示
            Destroy(charaShort.gameObject);
            one = false;
        }
    }
}
