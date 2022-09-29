using System.Collections;
using System.Collections.Generic;
using UnityEngine;


enum EnemyType{ Move = 0, Attack}
public class Enemy : MonoBehaviour
{
    private int wayPointCount;
    private Transform[] wayPoints;
    private int currentIndex;
    private Movement2D movement2D;
    private Animator anim;
    private EnemySpawner enemySpawner;

    public void SetUp(EnemySpawner enemySpawner, Transform[] wayPoints) 
    {
        movement2D = GetComponent<Movement2D>();
        this.enemySpawner = enemySpawner;
        this.wayPoints = wayPoints;
        
        wayPointCount = wayPoints.Length;
        this.wayPoints = new Transform[wayPointCount];
        this.wayPoints = wayPoints;

        // 적의 위치를 첫번째 wayPoint 로 설정ㄹ
        transform.position = wayPoints[currentIndex].position;

        // 나오자마자 시작
        StartCoroutine("OnMove");
    }

    // 맵전체를 검색해서 가장 가까운 Damageable layer 찾기 

    private IEnumerator OnMove() 
    {
        // 다음 이동 방향 설정 
        NextMoveTo();

        //anim.SetBool("Move", true);
        while (true)
        {
            if (Vector3.Distance(transform.position, wayPoints[wayPointCount].position) <= 0.02f * movement2D.MoveSpeed) 
            {
                NextMoveTo();
            }

            yield return null;
        }


    }

    private void NextMoveTo() 
    {
        if (currentIndex < wayPointCount - 1) 
        {
          
        }
    }


    
}


