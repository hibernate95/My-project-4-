using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeNameUI : MonoBehaviour
{
    public InputField newNameInput; // ���ο� �÷��̾� �̸��� �Է��ϴ� InputField
    public GameObject newNameUI; // �̸� ���� UI GameObject�� �����ϱ� ���� ����
    public GameObject PlayerName;

    public void OnApplyButtonClick()
    {
        // �Էµ� ���ο� �÷��̾� �̸��� �����ɴϴ�.
        string newPlayerName = newNameInput.text;

        // ���ο� �÷��̾� �̸��� PlayerPrefs�� �����մϴ�.
        PlayerPrefs.SetString("PlayerName", newPlayerName);

        // �̸� ���� UI ��Ҹ� ��Ȱ��ȭ�մϴ�.
        newNameUI.SetActive(false);
        Text playerNameText = PlayerName.GetComponent<Text>();
        playerNameText.text = newPlayerName;
    }
}
