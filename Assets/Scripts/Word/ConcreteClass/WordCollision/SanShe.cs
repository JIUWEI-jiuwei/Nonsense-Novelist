using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ɢ��
/// </summary>
public class SanShe : WordCollisionShoot
{
    private int num = 0;
    public bool hasCol;
    private void Awake()
    {
    }
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)//(�Ƕȼ���������)
    {
        if (!hasCol && collision.transform.tag == "wall")
        {
            hasCol = true;
            while (num < 2)
            {
                GameObject clone = Instantiate(this.gameObject);//2
                hasCol = true;

                clone.transform.SetParent(this.transform);
                clone.transform.localScale = Vector3.one;
                clone.transform.GetComponent<Rigidbody2D>().velocity = this.transform.GetComponent<Rigidbody2D>().velocity;
                if (num == 0)
                {
                    clone.transform.localEulerAngles = new Vector3(this.transform.localEulerAngles.x, this.transform.localEulerAngles.y, this.transform.localEulerAngles.z + 60);
                    Vector3 a = this.GetComponent<Rigidbody2D>().velocity;
                    clone.transform.position = this.transform.position + a;
                }
                else if (num == 1)
                {
                    if (clone.transform.GetChild(0) != null)
                    {
                        Destroy(clone.transform.GetChild(0).gameObject);
                    }

                    clone.transform.localEulerAngles = new Vector3(this.transform.localEulerAngles.x, this.transform.localEulerAngles.y, this.transform.localEulerAngles.z - 60);
                    Vector3 b = this.GetComponent<Rigidbody2D>().velocity;
                    clone.transform.position = this.transform.position + b;
                }
                num++;
            }
        }
        
    }
}
