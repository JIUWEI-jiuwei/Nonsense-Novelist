using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

///<summary>
///血条UI
///</summary>
class HealthBar : MonoBehaviour
{
    /// <summary>血条预制体 </summary>
    public GameObject healthBarPrefab;
    /// <summary>角色头顶血条的位置 </summary>
    public Transform barPoint;
    /// <summary>剩余血量数值 </summary>
    private Image healthSlider;
    /// <summary>角色位置 </summary>
    private Transform UIbar;

    private void OnEnable()
    {
        foreach(Canvas canvas in FindObjectsOfType<Canvas>())
        {
            if (canvas.name == "UIcanvas")
            {
                UIbar = Instantiate(healthBarPrefab, canvas.transform).transform;
                healthSlider = UIbar.GetChild(0).GetComponent<Image>();
            }   
        }        
    }
    private void Update()
    {
        var charaComponent = gameObject.GetComponent<AbstractCharacter>();
        UpdateHealthBar(charaComponent.hp, charaComponent.maxHP);
        if (UIbar != null)
        {
            UIbar.position = barPoint.position;
        }
    }
    /// <summary>
    /// 更新血量数值
    /// </summary>
    /// <param name="currentHP">当前血量</param>
    /// <param name="maxHP">总血量</param>
    private void UpdateHealthBar(int currentHP,int maxHP)
    {
        if (currentHP <= 0) Destroy(UIbar.gameObject);
        float sliderPercent = (float)currentHP / maxHP;
        healthSlider.fillAmount = sliderPercent;
    }    
}
