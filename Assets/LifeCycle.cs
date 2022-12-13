using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{

    // 1. Awake : 객체 생성 될때 한번만 실행
    private void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    // 2. OnEnable : 객체가 Enalble 될때 실행
    void OnEnable()
    {
        Debug.Log("플레이어가 로그인했습니다.");
    }

    // 3. Start : OnEnable 이후 한번만 실행
    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    // 4. FixedUpdate : 1초에 50번 실행
    // 게임 물리 로직 처리
    void FixedUpdate()
    {
        Debug.Log("이동~");
    }

    // 5. Update : 주기적 실행, 1초에 60번 실행(60FPS)
    // 주기적으로 변하는 게임 로직에 사용
    // 컴퓨터 환경에 따라서 실행 주기가 떨어질수 있음
    void Update()
    {
        Debug.Log("몬스터 사냥!!");
    }

    // 6. LateUpdate : 주기적 실행, Update 이후에 실행 
    // 캐릭터를 따라가는 카메라 라던지.. 로직의 후처리에 사용
    void LateUpdate()
    {
        Debug.Log("경험치 획득");
    }

    // 7. OnDisable : 객체가 Disable 될때 실행
    void OnDisable()
    {
        Debug.Log("플레이어가 로그아웃 했습니다.");
    }

    // 8. OnDestroy : 객체가 삭제 될때 실행
    void OnDestroy()
    {
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }

}
