using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BookWordsAll
{
    /// <summary>
    /// �������<����>
    /// </summary>
    public class AbstractWordsAll : MonoBehaviour
    {
        /// <summary>
        /// �鼮��ö��
        /// </summary>
        public enum BookName
        {
            /// <summary>ȫ�鼮 </summary>
            allBooks = 0,
        };
    }


    /// <summary>
    /// �����ɫ��
    /// </summary>
    public class Character :AbstractWordsAll
    {
        

        /// <summary>
        /// ���ö��
        /// </summary>
        public enum CharacterRole {
            /// <summary>����</summary>
            player = 0,
            /// <summary>����</summary>
            relative = 1,
            

        };
        /// <summary>
        /// �Ա�
        /// </summary>
        public enum Gender
        {
            boy=0,
            girl=1,
        };
        /// <summary>
        /// ��Ӫ
        /// </summary>
        public enum Camp
        {
            
            /// <summary>İ����</summary>
            stranger = 0,
            /// <summary>�ѷ�</summary>
            friend = 1,
            /// <summary>����</summary>
            enemy = 2,
        };
        /// <summary>
        /// �Ը�
        /// </summary>
        public enum Trait
        {
            
        };

        public string name_n;
        /// <summary>Ѫ��</summary>
        public int hp = 0;
        /// <summary>��Ѫ��</summary>
        public int maxHP = 0;
        /// <summary>����</summary>
        public int sp = 0;
        /// <summary>������</summary>
        public int maxSP=0;
        /// <summary>������</summary>
        public int atk = 0;
        /// <summary>������</summary>defensive force
        public int def = 0;
        /// <summary>������</summary>psychic force
        public int psy = 0;
        /// <summary>��־��</summary>
        public int san = 0;
        /// <summary>��������</summary>critical strike chance
        public double csc = 0.00;
        /// <summary>��������</summary>multiple critical strike
        public double mcs = 0.00;
        /// <summary>�����ٶ�</summary>attack speed
        public int attackSpeed=0;
        /// <summary>���ܼ���</summary>dodge chance
        public double dodgeChance = 0.00;
        /// <summary>�ƶ��ٶ�</summary>move speed
        public int moveSpeed = 0;
        /// <summary>�øж�</summary>favorite
        public int fav = 0;
        /// <summary>�Ƹ�</summary>wealth
        public int wealth = 0;
        /// <summary>����ֵ</summary>
        public int luckyValue = 0;
        /// <summary>��ȴʱ��</summary>
        public int CD =0;




    }

    /// <summary>
    /// ������Ʒ��
    /// </summary>
    public class AbstractItems : AbstractWordsAll { }

    /// <summary>
    /// ���󶯴���
    /// </summary>
    public class AbstractVerbs : AbstractWordsAll { }

    /// <summary>
    /// �������ݴ���
    /// </summary>
    public class AbstractAdjectives : AbstractWordsAll { }

}