using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableCharaController : MonoBehaviour
{

    public EnemyData enemyData;

    void Start()
    {
        ShowScriptableObjectData();
    }

    void Update()
    {

    }

    void ShowScriptableObjectData()
    {
        // 参照しているEnemyDataの中身をコンソールに表示する
        Debug.Log("私の名前は" + enemyData.enemyName +
                    ", 最大HPは" + enemyData.maxHp +
                    ", 攻撃力は" + enemyData.atk +
                    ", 防御力は" + enemyData.def +
                    ", 経験値は" + enemyData.exp +
                    ", ゴールドは" + enemyData.gold + "です。");
    }
}