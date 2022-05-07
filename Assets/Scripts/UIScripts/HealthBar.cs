using UnityEngine;
using UnityEngine.UI;

///<summary>
///血条UI
///</summary>
class HealthBar : MonoBehaviour
{
    /// <summary>血条预制体 </summary>
    public GameObject healthBarPrefab;
    /// <summary>角色头顶血条的位置 </summary>
    private Transform hpBarPoint;
    /// <summary>剩余血量数值 </summary>
    private Image healthSlider;
    /// <summary>角色位置 </summary>
    private GameObject UIbar;
    /// <summary>获取该角色 </summary>
    private AbstractCharacter charaComponent;
    /// <summary>条位置 </summary>
    private Transform[] barPoint;

    public void Start()
    {
        charaComponent = gameObject.GetComponent<AbstractCharacter>();
        //hpBarPoint = gameObject.transform.GetChild(0).GetComponent<Transform>();
        barPoint = gameObject.GetComponentsInChildren<Transform>();
        hpBarPoint = barPoint[1];
        foreach (Canvas canvas in FindObjectsOfType<Canvas>())
        {
            if (canvas.name == "UIcanvas")
            {
                UIbar = Instantiate(healthBarPrefab, canvas.transform);
                healthSlider = UIbar.transform.GetChild(0).GetComponent<Image>();
            }
        }
    }
    public void Update()
    {
        UpdateHealthBar(charaComponent.hp, charaComponent.maxHP);
        if (UIbar != null)
        {
            UIbar.transform.position = hpBarPoint.position;
        }
    }
    /// <summary>
    /// 更新血量数值
    /// </summary>
    /// <param name="currentHP">当前血量</param>
    /// <param name="maxHP">总血量</param>
    public void UpdateHealthBar(int currentHP, int maxHP)
    {
        if (currentHP <= 0) {
            Destroy(gameObject); 
            Destroy(UIbar.gameObject);
        }       
        float sliderPercent = (float)currentHP / maxHP;
        if(healthSlider!=null)
        healthSlider.fillAmount = sliderPercent;
    }
}
