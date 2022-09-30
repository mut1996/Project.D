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
    private Transform hitTransform = null;          //마우스 픽킹으로 저장된 Transform


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

                // 맞은 물체의 태그값을 가져옴
                // 만약 맞은 물체의 테그가 Ground 라면 PlantSpanwer에서 밭을 가는 함수 호출 
                if (hit.transform.CompareTag("Ground"))
                {
                    // 밭가는 이벤트
                }
                // 타일이면 plant 소환 
                else if (hit.transform.CompareTag("Tile"))
                {
                    // 타일 생성 이벤트 
                }
                else if (hit.transform.CompareTag("Plant"))
                {
                    // 타일 정보 출력 이벤트
                }

            }

        }
    }



}
