using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeNameUI : MonoBehaviour
{
    public InputField newNameInput; // 새로운 플레이어 이름을 입력하는 InputField
    public GameObject newNameUI; // 이름 변경 UI GameObject를 참조하기 위한 변수
    public GameObject PlayerName;

    public void OnApplyButtonClick()
    {
        // 입력된 새로운 플레이어 이름을 가져옵니다.
        string newPlayerName = newNameInput.text;

        // 새로운 플레이어 이름을 PlayerPrefs에 저장합니다.
        PlayerPrefs.SetString("PlayerName", newPlayerName);

        // 이름 변경 UI 요소를 비활성화합니다.
        newNameUI.SetActive(false);
        Text playerNameText = PlayerName.GetComponent<Text>();
        playerNameText.text = newPlayerName;
    }
}
