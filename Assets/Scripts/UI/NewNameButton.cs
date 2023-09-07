using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewNameButton : MonoBehaviour
{
    public GameObject nameChangeUI; // 이름 변경 UI 요소를 참조하기 위한 변수

    public void OnModifyButtonClick()
    {
        // 이름 변경 UI 요소를 활성화합니다.
        nameChangeUI.SetActive(true);
    }
}
