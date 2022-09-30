using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    private int[,] spriteArray;

    [SerializeField]
    private Sprite[] sprites;

    public bool isCultivating { get; set; }
    public bool isBuilding { get; set; }

    private void Awake()
    {
        spriteArray = new int[3, 3];
        spriteRenderer = GetComponent<SpriteRenderer>();

        isCultivating = false;
        isBuilding = false;
    }

    // 만약에 9가지 경작 타일 중에 조건부로 전부 하나씩 sprite 교체 해줌 



    private void Update()
    {
        //   x x x 
        //   x 0 x 
        //   x x x
        if (transform.position)
        {
            spriteRenderer.sprite = sprites[3];
        }
        else if ()
        {
            
        }


    }

    private void SearchNearBySprite() 
    {
        spriteArray
    }





}
