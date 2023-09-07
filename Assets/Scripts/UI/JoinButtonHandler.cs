using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JoinButtonHandler : MonoBehaviour
{
    public InputField playerNameInput; // 플레이어 이름을 입력하는 Input Field

    private void Start()
    {
        // JOIN 버튼에 클릭 이벤트 리스너를 추가합니다.
        Button joinButton = GetComponent<Button>();
        joinButton.onClick.AddListener(JoinGame);
    }

    private void JoinGame()
    {
        // 입력된 플레이어 이름을 가져옵니다.
        string playerName = playerNameInput.text;

        // 메인 씬으로 전환합니다. 메인 씬에서 플레이어 이름을 사용하려면 PlayerPrefs를 사용할 수 있습니다.
        PlayerPrefs.SetString("PlayerName", playerName);
        SceneManager.LoadScene("MainScene");
    }
}
