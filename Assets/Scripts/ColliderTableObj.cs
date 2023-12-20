using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTableObj : MonoBehaviour
{

    WaitForFixedUpdate waitForFixedUpdate = new WaitForFixedUpdate();
    Vector3 oriPos;
    Coroutine onlyCoroutine = null;
    float speed = 15;
    float timer = 0;
    private void Start()
    {
        oriPos = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        timer = 0;
        if(onlyCoroutine!=null)
            StopCoroutine(onlyCoroutine);
        onlyCoroutine = StartCoroutine(Move());

    }

    IEnumerator Move()
    {
        while (timer < 3.14)
        {
            yield return waitForFixedUpdate;
            timer += Time.deltaTime * speed;
            transform.position = oriPos + Mathf.Sin(timer) *0.05f* new Vector3(0, 1, 0); ;
        }
  
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (onlyCoroutine != null)
    //    {
    //        StopCoroutine(onlyCoroutine);
    //        onlyCoroutine = null;
    //    }

    //    onlyCoroutine=StartCoroutine (MoveBack());
    //}
    //IEnumerator MoveBack()
    //{
    //    yield return new WaitForSeconds(0.2f);
    //    while (Vector3.Distance(transform.position, oriPos)>0.1f)
    //    {
    //        print("sasdd");
    //        rb.angularVelocity = 0;
    //        rb.velocity = Vector2.zero;
    //           yield return waitForFixedUpdate;
          
    //        transform.position += speed * Time.deltaTime * (oriPos - transform.position);
    //            }
    //    onlyCoroutine = null;
    //}
}
