using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �汾������ק��ɫվλ
/// </summary>
public class CharacterMouseDrag : MonoBehaviour
{
    /// <summary>OnMouseDown��ز���</summary>
    private Vector3 targetScreenpos;//��ק�������Ļ����
    private Vector3 targetWorldpos;//��ק�������������
    private Transform target;//��ק����
    private Vector3 mouseScreenpos;//������Ļ����
    private Vector3 offset;//ƫ����

    /// <summary>��¼Ŀǰ���ڵ�վλ</summary>
    private Transform nowParentTF;
    /// <summary>��¼��һ�����ڵ�վλ</summary>
    private Transform lastParentTF;
    /// <summary>��ɫ��վλposition��Yƫ����</summary>
    public static float offsetY = 0.5f;

    private void Start()
    {
        nowParentTF = transform.parent;
        target = transform;
    }

    private void OnMouseEnter()
    {
        
    }
    #region OnMouseDrag()������ƶ�(����)

    /* private void OnMouseDrag()
     {
         //������ƶ�
         var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
         transform.position = new Vector3(pos.x, pos.y, transform.position.z);
         
     }*/
    #endregion

    /// <summary>
    /// �����ͣ
    /// </summary>
    private void OnMouseOver()
    {
        //��ɫ���
        GetComponent<SpriteRenderer>().color = new Color((float)255 / 255, (float)225 / 255, (float)189 / 255, (float)255 / 255);

        //��ʾ��ɫ��Ҫ��Ϣ

    }
    private void OnMouseExit()
    {
        //��ɫ�ָ�
        GetComponent<SpriteRenderer>().color = new Color((float)255 / 255, (float)255 / 255, (float)255 / 255, (float)255 / 255);

    }
    //���ƶ�������Ҫ���collider���������ӦOnMouseDown()����
    //����˼·�������������ʱ��OnMouseDown�������������������ִֻ��һ�Σ���
    //��¼��ʱ���������������꣬����ò�ֵ������˺��û���Ȼ��������������ô����֮ǰ�Ĳ�ֵ���伴�ɡ�
    //���������������������꣬�����������Ļ���꣬��Ҫ����ת�����������������ʾ��
    IEnumerator OnMouseDown()
    {
        targetScreenpos = Camera.main.WorldToScreenPoint(target.position);
        mouseScreenpos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, targetScreenpos.z);
        offset = target.position - Camera.main.ScreenToWorldPoint(mouseScreenpos);

        while (Input.GetMouseButton(0))//���������������¡�
        {
            mouseScreenpos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, targetScreenpos.z);
            targetWorldpos = Camera.main.ScreenToWorldPoint(mouseScreenpos) + offset;
            target.position = targetWorldpos;
            yield return new WaitForFixedUpdate();
        }
    }
    private void OnMouseUp()
    {
        //�����˼��㼶�����Խ�ɫ����
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero,100,LayerMask.GetMask("Situation"));
        if (hit.collider != null)
        {
            Debug.Log(hit.transform.name);

            if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Situation"))
            {
                //��ɫ��ק��վλ����λ��У׼
                lastParentTF = nowParentTF;
                nowParentTF = hit.transform;
                this.transform.SetParent(nowParentTF);
                transform.position = new Vector3(nowParentTF.position.x, nowParentTF.position.y + offsetY, nowParentTF.position.z);

                //����/�ָ�վλ��ɫ��͸����Ϊ0
                nowParentTF.gameObject.GetComponent<SpriteRenderer>().material.color = Color.clear;
                if(lastParentTF.gameObject.GetComponent<SpriteRenderer>())
                    lastParentTF.gameObject.GetComponent<SpriteRenderer>().material.color = new Color((float)180/255, (float)180 /255, (float)180 /255, 1);

                //����վλ����ɫ��Ӫ��ֵ
                if (hit.collider.gameObject.GetComponent<Situation>().number < 6)
                {
                    this.GetComponent<AbstractCharacter>().camp = CampEnum.left;

                }
                else
                {
                    this.GetComponent<AbstractCharacter>().camp = CampEnum.right;

                }
            }

        }
        else//û�м�⵽վλ
        {
            transform.position = new Vector3(nowParentTF.position.x, nowParentTF.position.y + offsetY, nowParentTF.position.z);

        }
    }
} 

