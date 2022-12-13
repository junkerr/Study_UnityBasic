using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{

    // 1. Awake : ��ü ���� �ɶ� �ѹ��� ����
    private void Awake()
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }

    // 2. OnEnable : ��ü�� Enalble �ɶ� ����
    void OnEnable()
    {
        Debug.Log("�÷��̾ �α����߽��ϴ�.");
    }

    // 3. Start : OnEnable ���� �ѹ��� ����
    void Start()
    {
        Debug.Log("��� ��� ì����ϴ�.");
    }

    // 4. FixedUpdate : 1�ʿ� 50�� ����
    // ���� ���� ���� ó��
    void FixedUpdate()
    {
        Debug.Log("�̵�~");
    }

    // 5. Update : �ֱ��� ����, 1�ʿ� 60�� ����(60FPS)
    // �ֱ������� ���ϴ� ���� ������ ���
    // ��ǻ�� ȯ�濡 ���� ���� �ֱⰡ �������� ����
    void Update()
    {
        Debug.Log("���� ���!!");
    }

    // 6. LateUpdate : �ֱ��� ����, Update ���Ŀ� ���� 
    // ĳ���͸� ���󰡴� ī�޶� �����.. ������ ��ó���� ���
    void LateUpdate()
    {
        Debug.Log("����ġ ȹ��");
    }

    // 7. OnDisable : ��ü�� Disable �ɶ� ����
    void OnDisable()
    {
        Debug.Log("�÷��̾ �α׾ƿ� �߽��ϴ�.");
    }

    // 8. OnDestroy : ��ü�� ���� �ɶ� ����
    void OnDestroy()
    {
        Debug.Log("�÷��̾� �����͸� �����Ͽ����ϴ�.");
    }

}
