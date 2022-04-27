using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

///<summary>
///Ѫ��UI
///</summary>
class HealthBar : MonoBehaviour
{
    /// <summary>Ѫ��Ԥ���� </summary>
    public GameObject healthBarPrefab;
    /// <summary>��ɫͷ��Ѫ����λ�� </summary>
    public Transform barPoint;
    /// <summary>ʣ��Ѫ����ֵ </summary>
    private Image healthSlider;
    /// <summary>��ɫλ�� </summary>
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
    /// ����Ѫ����ֵ
    /// </summary>
    /// <param name="currentHP">��ǰѪ��</param>
    /// <param name="maxHP">��Ѫ��</param>
    private void UpdateHealthBar(int currentHP,int maxHP)
    {
        if (currentHP <= 0) Destroy(UIbar.gameObject);
        float sliderPercent = (float)currentHP / maxHP;
        healthSlider.fillAmount = sliderPercent;
    }    
}
