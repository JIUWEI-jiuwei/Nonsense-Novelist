using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BookWordsAll
{
    /// <summary>
    /// 抽象词类<父类>
    /// </summary>
    public class AbstractWordsAll : MonoBehaviour
    {
        /// <summary>
        /// 书籍名枚举
        /// </summary>
        public enum BookName
        {
            /// <summary>全书籍 </summary>
            allBooks = 0,
        };
    }


    /// <summary>
    /// 抽象角色类
    /// </summary>
    public class Character :AbstractWordsAll
    {
        

        /// <summary>
        /// 身份枚举
        /// </summary>
        public enum CharacterRole {
            /// <summary>主角</summary>
            player = 0,
            /// <summary>亲人</summary>
            relative = 1,
            

        };
        /// <summary>
        /// 性别
        /// </summary>
        public enum Gender
        {
            boy=0,
            girl=1,
        };
        /// <summary>
        /// 阵营
        /// </summary>
        public enum Camp
        {
            
            /// <summary>陌生人</summary>
            stranger = 0,
            /// <summary>友方</summary>
            friend = 1,
            /// <summary>敌人</summary>
            enemy = 2,
        };
        /// <summary>
        /// 性格
        /// </summary>
        public enum Trait
        {
            
        };

        public string name_n;
        /// <summary>血量</summary>
        public int hp = 0;
        /// <summary>总血量</summary>
        public int maxHP = 0;
        /// <summary>蓝量</summary>
        public int sp = 0;
        /// <summary>总蓝量</summary>
        public int maxSP=0;
        /// <summary>攻击力</summary>
        public int atk = 0;
        /// <summary>防御力</summary>defensive force
        public int def = 0;
        /// <summary>精神力</summary>psychic force
        public int psy = 0;
        /// <summary>意志力</summary>
        public int san = 0;
        /// <summary>暴击几率</summary>critical strike chance
        public double csc = 0.00;
        /// <summary>暴击倍数</summary>multiple critical strike
        public double mcs = 0.00;
        /// <summary>攻击速度</summary>attack speed
        public int attackSpeed=0;
        /// <summary>闪避几率</summary>dodge chance
        public double dodgeChance = 0.00;
        /// <summary>移动速度</summary>move speed
        public int moveSpeed = 0;
        /// <summary>好感度</summary>favorite
        public int fav = 0;
        /// <summary>财富</summary>wealth
        public int wealth = 0;
        /// <summary>幸运值</summary>
        public int luckyValue = 0;
        /// <summary>冷却时间</summary>
        public int CD =0;




    }

    /// <summary>
    /// 抽象物品类
    /// </summary>
    public class AbstractItems : AbstractWordsAll { }

    /// <summary>
    /// 抽象动词类
    /// </summary>
    public class AbstractVerbs : AbstractWordsAll { }

    /// <summary>
    /// 抽象形容词类
    /// </summary>
    public class AbstractAdjectives : AbstractWordsAll { }

}