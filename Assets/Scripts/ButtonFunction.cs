using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFunction : MonoBehaviour {

    public Function function;

    public enum Function {
        function1,
        function2,
        function3,
        function4
    }

    private void Start() {

        Button mButton = GetComponent<Button>();

        if (function == Function.function1)
            mButton.onClick.AddListener(() => Function1());

        if (function == Function.function2)
            mButton.onClick.AddListener(() => Function2());

        if (function == Function.function3)
            mButton.onClick.AddListener(() => Function3());

        if (function == Function.function4)
            mButton.onClick.AddListener(() => Function4());

    }

    public void Function1() {
        print("Funzione 1");
    }

    public void Function2() {
        print("Funzione 2");
    }

    public void Function3() {
        print("Funzione 3");
    }

    public void Function4() {
        print("Funzione 4");
    }

}