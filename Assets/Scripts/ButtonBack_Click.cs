using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBack_Click : MonoBehaviour {
    public Button mButton;
    // Use this for initialization
    void Start()
    {
        Button btn = mButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnclick);
    }

    void TaskOnclick()
    {
        //加载场景一
        Application.LoadLevel(0);
    }
}
