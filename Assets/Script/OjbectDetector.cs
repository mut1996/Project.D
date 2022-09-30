using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class OjbectDetector : MonoBehaviour
{
    private Camera mainCamera;
    private Ray ray;
    private RaycastHit hit;
    private Transform hitTransform = null;          //���콺 ��ŷ���� ����� Transform


    private void Awake()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject() == true) 
        {
            return;
        }

        if (Input.GetMouseButtonDown(0)) 
        {
            ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity)) 
            {
                hitTransform =  hit.transform;

                // ���� ��ü�� �±װ��� ������
                // ���� ���� ��ü�� �ױװ� Ground ��� PlantSpanwer���� ���� ���� �Լ� ȣ�� 
                if (hit.transform.CompareTag("Ground"))
                {
                    // �簡�� �̺�Ʈ
                }
                // Ÿ���̸� plant ��ȯ 
                else if (hit.transform.CompareTag("Tile"))
                {
                    // Ÿ�� ���� �̺�Ʈ 
                }
                else if (hit.transform.CompareTag("Plant"))
                {
                    // Ÿ�� ���� ��� �̺�Ʈ
                }

            }

        }
    }



}
