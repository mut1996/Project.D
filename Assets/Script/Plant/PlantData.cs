using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="BasePlantData", menuName ="Plant/Data")]
public class PlantData : ScriptableObject
{
    public int hp;
    public int maxHP;
    public float range;
    public int damage;

}
