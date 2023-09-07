using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JoinButtonHandler : MonoBehaviour
{
    public InputField playerNameInput; // �÷��̾� �̸��� �Է��ϴ� Input Field

    private void Start()
    {
        // JOIN ��ư�� Ŭ�� �̺�Ʈ �����ʸ� �߰��մϴ�.
        Button joinButton = GetComponent<Button>();
        joinButton.onClick.AddListener(JoinGame);
    }

    private void JoinGame()
    {
        // �Էµ� �÷��̾� �̸��� �����ɴϴ�.
        string playerName = playerNameInput.text;

        // ���� ������ ��ȯ�մϴ�. ���� ������ �÷��̾� �̸��� ����Ϸ��� PlayerPrefs�� ����� �� �ֽ��ϴ�.
        PlayerPrefs.SetString("PlayerName", playerName);
        SceneManager.LoadScene("MainScene");
    }
}
