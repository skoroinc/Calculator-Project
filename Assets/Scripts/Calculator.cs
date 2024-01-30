using TMPro;
using UnityEngine;


public class Calculator : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputFieldTheFirstNumber;
    [SerializeField] private TMP_InputField _inputFieldTheSecondNumber;
    [SerializeField] private TMP_Text _textFinalNumber;
    [SerializeField] private TMP_Text _textIncorrectInput;
   
    void Start()
    {
        _textIncorrectInput.text = "";
    }


    private bool CheckInput(out decimal numberFirst, out decimal numberSecond)
    {
        numberFirst = 0m;
        numberSecond = 0m;

        if (decimal.TryParse(_inputFieldTheFirstNumber.text, out numberFirst) && decimal.TryParse(_inputFieldTheSecondNumber.text, out numberSecond))
        {
            return true;
        }
        else
        {
            _textIncorrectInput.text = "Некорректный ввод, введите число";
            return false;
        }
    }

    public void OnClickReceiveAnswerAddition()
    {
        _textIncorrectInput.text = "";
        
        if (CheckInput(out decimal numberFirst, out decimal numberSecond))
        {
            _textFinalNumber.text = $"{numberFirst + numberSecond}";
        }
    }
    public void OnClickReceiveAnswerSubtraction()
    {
        _textIncorrectInput.text = "";
        
        if (CheckInput(out decimal numberFirst, out decimal numberSecond))
        {
            _textFinalNumber.text = $"{numberFirst - numberSecond}";
        }
    }
    public void OnClickReceiveAnswerMultiplication()
    {
        _textIncorrectInput.text = "";
        

        if (CheckInput(out decimal numberFirst, out decimal numberSecond))
        {
            _textFinalNumber.text = $"{numberFirst * numberSecond}";
        }
    }
    public void OnClickReceiveAnswerDivision()
    {
        _textIncorrectInput.text = "";
        

        if (CheckInput(out decimal numberFirst, out decimal numberSecond))
        {
            _textFinalNumber.text = $"{numberFirst / numberSecond}";
        }
    }

}
