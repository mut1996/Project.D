using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu]
public class PlantTemplate : ScriptableObject
{
    public GameObject plantPrefab;              // 타워 생성을 위한 프리펩 
    public GameObject followTowerPrefab;        // 임시 타워 프리펩 '
    public plantData[] plant;

    public struct plantData 
    {
        public Sprite sprite;
        public float damage;
    }
    
}
