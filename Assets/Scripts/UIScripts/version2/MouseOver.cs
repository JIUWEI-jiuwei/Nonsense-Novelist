using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
///�����ͣ�ڽ�ɫ����
///</summary>
class MouseOver : MonoBehaviour
{
    private void OnMouseOver()
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color((float)255 /255, (float)225/255, (float)189/255, (float)255/255);
    }
    private void OnMouseExit()
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color((float)255 / 255, (float)255/ 255, (float)255 / 255, (float)255 / 255);
    }
}
