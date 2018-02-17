using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace HoloLensKeyboard
{
    public class Controller : MonoBehaviour
    {
        public GameObject manager;
        public GameObject myCreator;
        public GameObject blocker;
        public InputField myInputField;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void startClicked()
        {
            blocker.SetActive(false);
            manager.GetComponent<TextToFile>().storeFile("[" + DateTime.UtcNow.ToString("MM-dd-yyyy HH:mm:ss:") + DateTime.UtcNow.Millisecond.ToString() + "]       Start\n");
            myCreator.GetComponent<KeyboardCreator>().currentTheme = "keyboard";
            myCreator.GetComponent<KeyboardCreator>().Initialize();
        }

        public void submitClicked()
        {
            blocker.SetActive(true);
            myInputField.text = "";
            manager.GetComponent<TextToFile>().storeFile("[" + DateTime.UtcNow.ToString("MM-dd-yyyy HH:mm:ss:") + DateTime.UtcNow.Millisecond.ToString() + "]       Submit\n");
            myCreator.GetComponent<KeyboardCreator>().currentTheme = "default";
            myCreator.GetComponent<KeyboardCreator>().Initialize();
        }
    }
}
