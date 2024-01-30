using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Comparisons : MonoBehaviour
{

    [SerializeField] private TMP_InputField _inputFieldTheFirstNumber;
    [SerializeField] private TMP_InputField _inputFieldTheSecondNumber;
    [SerializeField] private TMP_Text _textFinalComparisons;
    [SerializeField] private TMP_Text _textIncorrectInput;

    void Start()
    {
        _textIncorrectInput.text = "";
    }

    private bool CheckInput(out decimal numberFirst, out decimal numberSecond)
    {
        numberFirst = 0;
        numberSecond = 0;

        if (decimal.TryParse(_inputFieldTheFirstNumber.text, out numberFirst) && decimal.TryParse(_inputFieldTheSecondNumber.text, out numberSecond))
        {
            return true;
        }
        else
        {
            _textIncorrectInput.text = "Неккоректный ввод, введите число";
            return false;
        }
    }

    public void OnClickAnswerComparisons()
    {
        _textIncorrectInput.text = "";

        if (CheckInput(out decimal numberFirst, out decimal numberSecond))
        {
            if (numberFirst == numberSecond)
            {
                _textFinalComparisons.text = $"{numberFirst} = {numberSecond}";
            }
            else if (numberFirst > numberSecond)
            {
                _textFinalComparisons.text = $"{numberFirst} > {numberSecond}";
            }
            else if (numberFirst < numberSecond)
            {
                _textFinalComparisons.text = $"{numberFirst} < {numberSecond}";
            }
        }
    }

}
