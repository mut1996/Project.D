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

        // ���� ��ġ�� ù��° wayPoint �� ������
        transform.position = wayPoints[currentIndex].position;

        // �����ڸ��� ����
        StartCoroutine("OnMove");
    }

    // ����ü�� �˻��ؼ� ���� ����� Damageable layer ã�� 

    private IEnumerator OnMove() 
    {
        // ���� �̵� ���� ���� 
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


