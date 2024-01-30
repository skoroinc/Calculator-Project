using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField] private GameObject canvasCalculator;
    [SerializeField] private GameObject canvasComparisons;
    [SerializeField] private TMP_InputField _inputFieldTheFirstNumberCalculator;
    [SerializeField] private TMP_InputField _inputFieldTheSecondNumberCalculator;
    [SerializeField] private TMP_InputField _inputFieldTheFirstNumberComparisons;
    [SerializeField] private TMP_InputField _inputFieldTheSecondNumbersComparisons;
    [SerializeField] private TMP_Text _textFinalNumberCalculator;
    [SerializeField] private TMP_Text _textFinalComparisons;
    [SerializeField] private TMP_Text _textIncorrectInputCalculator;
    [SerializeField] private TMP_Text _textIncorrectInputComparisons;

    private GameObject currentCanvas;

    private void Start()
    {
        canvasCalculator.SetActive(true);
        currentCanvas = canvasCalculator;
    }

    public void ChangeCanvas(GameObject canvas)
    {
        if (currentCanvas != null)
        {
            ClearInputFields();
            currentCanvas.SetActive(false);
            canvas.SetActive(true);
            currentCanvas = canvas;
        }
    }
    private void ClearInputFields()
    {
        if (_inputFieldTheFirstNumberCalculator != null)
        {
            _inputFieldTheFirstNumberCalculator.text = "";
        }

        if (_inputFieldTheSecondNumberCalculator != null)
        {
            _inputFieldTheSecondNumberCalculator.text = "";
        }

        if (_inputFieldTheFirstNumberComparisons != null)
        {
            _inputFieldTheFirstNumberComparisons.text = "";
        }

        if (_inputFieldTheSecondNumbersComparisons != null)
        {
            _inputFieldTheSecondNumbersComparisons.text = "";
        }

        if (_textFinalNumberCalculator != null)
        {
            _textFinalNumberCalculator.text = "";
        }

        if (_textFinalComparisons != null)
        {
            _textFinalComparisons.text = "";
        }

        if (_textIncorrectInputCalculator != null)
        {
            _textIncorrectInputCalculator.text = "";
        }

        if (_textIncorrectInputComparisons != null)
        {
            _textIncorrectInputComparisons.text = "";
        }
    }


}
