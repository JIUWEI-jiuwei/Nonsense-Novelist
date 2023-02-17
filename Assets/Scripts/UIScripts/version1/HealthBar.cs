using UnityEngine;
using UnityEngine.UI;

///<summary>
///Ѫ��UI
///Ѫ������������������
///�ڽ�ɫԤ�������潨������������HP��SP������HP��SP��λ��
///Ȼ�󽫽ű�healthbar��SPbar��ק����ɫԤ����
///</summary>
class HealthBar : MonoBehaviour
{
    /// <summary>Ѫ��Ԥ���� </summary>
    public GameObject healthBarPrefab;
    /// <summary>��ɫͷ��Ѫ����λ�� </summary>
    private Transform hpBarPoint;
    /// <summary>ʣ��Ѫ����ֵ </summary>
    private Image healthSlider;
    /// <summary>��ɫλ�� </summary>
    private GameObject UIbar;
    /// <summary>��ȡ�ý�ɫ </summary>
    private AbstractCharacter charaComponent;
    /// <summary>��λ�� </summary>
    private Transform[] barPoint;
    public static bool isDead = false;

    public void Start()
    {
        charaComponent = gameObject.GetComponent<AbstractCharacter>();
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
    public void FixedUpdate()
    {
        UpdateHealthBar(charaComponent.hp, charaComponent.maxHP);
        if (UIbar != null)
        {
            UIbar.transform.position = hpBarPoint.position;
        }
    }
    /// <summary>
    /// ����Ѫ����ֵ
    /// </summary>
    /// <param name="currentHP">��ǰѪ��</param>
    /// <param name="maxHP">��Ѫ��</param>
    public void UpdateHealthBar(float currentHP, float maxHP)
    {
        if (currentHP <= 0) {
            Destroy(UIbar.gameObject);
            isDead = true;
        }       
        float sliderPercent = (float)currentHP / maxHP;
        if(healthSlider!=null)
        healthSlider.fillAmount = sliderPercent;
    }
}