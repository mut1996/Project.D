using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="BaseData", menuName ="Data/PlayerData")]
public class PlayerData : ScriptableObject
{ 
    public int gold;
    public int stemina;
    public float maxHP;
    public float currentHP;          // ÁýÀÇ hp

}
