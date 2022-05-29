using UnityEngine;
using UnityEngine.UI;

///<summary>
///蓝量UI
///</summary>
class SPbar : MonoBehaviour
{
    /// <summary>蓝量预制体 </summary>
    public GameObject SPBarPrefab;
    /// <summary>角色头顶蓝量的位置 </summary>
    private Transform SPbarPoint;
    /// <summary>剩余蓝量数值 </summary>
    private Image SPSlider;
    /// <summary>角色位置 </summary>
    private Transform UIbar;
    /// <summary>获取该角色 </summary>
    private AbstractCharacter chara;
    /// <summary>条位置 </summary>
    private Transform[] barPoint;

    public void Start()
    {
        chara = gameObject.GetComponent<AbstractCharacter>();
        barPoint= gameObject.GetComponentsInChildren<Transform>();
        SPbarPoint = barPoint[2];
        foreach (Canvas canvas in FindObjectsOfType<Canvas>())
        {
            if (canvas.name == "UIcanvas")
            {
                UIbar = Instantiate(SPBarPrefab, canvas.transform).transform;
                SPSlider = UIbar.GetChild(0).GetComponent<Image>();
            }
        }
    }
    public void FixedUpdate()
    {
        UpdateSPBar(chara.sp, chara.maxSP,chara.hp);
        if (UIbar != null)
        {
            UIbar.position = SPbarPoint.position;
        }
    }
    /// <summary>
    /// 更新蓝量数值
    /// </summary>
    /// <param name="currentHP">当前蓝量</param>
    /// <param name="maxHP">总蓝量</param>currentHP=当前血量
    private void UpdateSPBar(float currentSP, float maxSP,float currentHP)
    {
        if (currentSP <= 0) {
            currentSP = 0;
        }
        if (currentHP <= 0) {
            Destroy(UIbar.gameObject);
        }       
        float sliderPercent = (float)currentSP / maxSP;
        if(SPSlider!=null)SPSlider.fillAmount = sliderPercent;
    }
}
