using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewNameButton : MonoBehaviour
{
    public GameObject nameChangeUI; // �̸� ���� UI ��Ҹ� �����ϱ� ���� ����

    public void OnModifyButtonClick()
    {
        // �̸� ���� UI ��Ҹ� Ȱ��ȭ�մϴ�.
        nameChangeUI.SetActive(true);
    }
}
