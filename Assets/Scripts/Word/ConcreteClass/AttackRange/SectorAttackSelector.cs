﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace ARPGSimpleDemo.Skill
{
    /// <summary>
    /// 扇形区域
    /// </summary>
	class SectorAttackSelector : IAttackRange
    {
        /// <summary>
        /// 计算影响区域
        /// </summary>
        /// <param name="attackDistance">射程</param>
        /// <param name="ownTrans">施法者位置</param>
        /// <param name="extra">角度</param>
        /// <returns>返回区域内目标数组</returns>
        public GameObject[] AttackRange(float attackDistance, Transform ownTrans,float angle)
        {
            //发一个球形射线，找出所有角色碰撞体
            Collider[] colliders = Physics.OverlapSphere(ownTrans.position, attackDistance, LayerMask.NameToLayer("Character"));
            if (colliders == null || colliders.Length == 0)
                return null;
            //取GameObject
            GameObject[] result = CollectionHelper.Select<Collider, GameObject>(colliders, p => p.gameObject);

            
            //筛选目标
            result = CollectionHelper.FindAll<GameObject>(result,
                p => p.GetComponent<AbstractCharacter>().hp>0 && //存活
                (Vector3.Angle(ownTrans.forward,p.transform .position -ownTrans .position)<angle));//角度在范围内

            //将所有目标按距离升序
            CollectionHelper.OrderBy<GameObject, float>(result, p => Vector3.Distance(ownTrans.position, p.transform.position));
            return result;

           
        }
    }
}
