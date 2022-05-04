using UnityEngine;
using UnityEngine.UI;

///<summary>
///Ѫ��UI
///</summary>
class HealthBar : MonoBehaviour
{
    /// <summary>Ѫ��Ԥ���� </summary>
    public GameObject healthBarPrefab;
    /// <summary>��ɫͷ��Ѫ����λ�� </summary>
    private Transform barPoint;
    /// <summary>ʣ��Ѫ����ֵ </summary>
    private Image healthSlider;
    /// <summary>��ɫλ�� </summary>
    private GameObject UIbar;
    /// <summary>��ȡ�ý�ɫ </summary>
    private AbstractCharacter charaComponent;

    public void Start()
    {
        charaComponent = gameObject.GetComponent<AbstractCharacter>();
        barPoint = gameObject.transform.GetChild(0).GetComponent<Transform>();
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
            UIbar.transform.position = barPoint.position;
        }
    }
    /// <summary>
    /// ����Ѫ����ֵ
    /// </summary>
    /// <param name="currentHP">��ǰѪ��</param>
    /// <param name="maxHP">��Ѫ��</param>
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
