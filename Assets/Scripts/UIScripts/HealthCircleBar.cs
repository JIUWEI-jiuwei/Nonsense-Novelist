using UnityEngine.UI;
using UnityEngine;

///<summary>
///—™Ãı‘≤»¶º”‘ÿ
///</summary>
class HealthCircleBar : MonoBehaviour
{
    public AbstractCharacter lin;
    private void Start()
    {
        lin = GameObject.Find("LinDaiYu").GetComponent<AbstractCharacter>();
    }
    private void FixedUpdate()
    {
        if (this.name == "LinDaiYu_Circle")
        {
            this.GetComponent<Image>().fillAmount = (float)(lin.hp / lin.maxHP);
        }
    }
}
