
using UnityEngine;
using UnityEngine.UI;

///<summary>
///角色信息面板
///</summary>
class CharacterDetails : MonoBehaviour
{
    public Text[] texts1;
    public Text[] texts2;
    public Text[] texts3;

    /// <summary>获取mousedown脚本 </summary>
    private MouseDown mouseDown;

    private void Start()
    {
        mouseDown= GameObject.Find("MainCamera").GetComponent<MouseDown>();
        
    }
    private void Update()
    {
        //状态信息面板
        //HP
        texts1[0].text = mouseDown.abschara.hp.ToString() + "/" + mouseDown.abschara.maxHP.ToString();
        //ATK
        texts1[1].text = IntToString.SwitchATK(mouseDown.abschara.atk);
        //san
        texts1[2].text = IntToString.SwitchATK(mouseDown.abschara.san);
        //SP
        texts1[3].text = mouseDown.abschara.sp.ToString() + "/" + mouseDown.abschara.maxSP.ToString();
        //def
        texts1[4].text = IntToString.SwitchATK(mouseDown.abschara.def);
        //atkInterval
        texts1[5].text = IntToString.SwitchATK(mouseDown.abschara.attackInterval);
        //EXP
        texts1[6].text = mouseDown.abschara.exp.ToString() + "/100";
        //psy
        texts1[7].text = IntToString.SwitchATK(mouseDown.abschara.psy);
        //
        texts1[8].text = IntToString.SwitchATK(mouseDown.abschara.skillSpeed);

        //技能信息面板
        if (mouseDown.absAdj)
        {
            texts2[0].text = mouseDown.absAdj.wordName;
            texts2[1].text = mouseDown.absAdj.description;
            
        }
        else if (mouseDown.absVerbs)
        {
            texts2[0].text = mouseDown.absVerbs.wordName;
            texts2[1].text = mouseDown.absVerbs.description;
        }
        //背景信息面板
        texts3[0].text = "身份："+mouseDown.absRole.roleName;
        texts3[1].text = "性格：" + mouseDown.absTrait.traitName;
        texts3[2].text = mouseDown.abschara.brief;
    }
    /// <summary>
    /// 属性面板的关闭按钮（用预制体挂脚本来赋值）
    /// </summary>
    public void CloseCharaPanel()
    {
        Destroy(this.transform.parent.gameObject);
        mouseDown.isShow = false;
    }
}
