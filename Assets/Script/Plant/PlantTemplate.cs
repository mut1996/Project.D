using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu]
public class PlantTemplate : ScriptableObject
{
    public GameObject plantPrefab;              // Ÿ�� ������ ���� ������ 
    public GameObject followTowerPrefab;        // �ӽ� Ÿ�� ������ '
    public plantData[] plant;

    public struct plantData 
    {
        public Sprite sprite;
        public float damage;
    }
    
}
