using System;
using TMPro;
using UnityEngine;

namespace Asteroids.Interpreter
{
    internal sealed class Example : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;
        [SerializeField] private TMP_InputField _inputField;
        private void Start()
        {
            _inputField.onValueChanged.AddListener(Interpret);
        }
        private void Interpret(string value)
        {
            if (Int64.TryParse(value, out var number))
            {
                _text.text = ToRoman(number);
            }
        }
        private string ToRoman(long number)
        {
            if ((number < 0) || (number > 40000)) throw new
            ArgumentOutOfRangeException(nameof(number),
            "insert value betwheen 1 and 3999");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "1k" + ToRoman(number - 1000);
            /*if (number >= 900) return "900" + ToRoman(number - 900);
            if (number >= 500) return "500" + ToRoman(number - 500);
            if (number >= 400) return "400" + ToRoman(number - 400);
            if (number >= 100) return "100" + ToRoman(number - 100);
            if (number >= 90) return "90" + ToRoman(number - 90);
            if (number >= 7) return "7" + ToRoman(number - 7);
            if (number >= 6) return "6" + ToRoman(number - 6);
            if (number >= 5) return "5" + ToRoman(number - 5);
            if (number >= 4) return "4" + ToRoman(number - 4);*/
            if (number >= 30000) return "30k" + ToRoman(number - 30000);
            if (number >= 2000) return "2k" + ToRoman(number - 2000);
            if (number >= 1) return string.Empty;

            throw new ArgumentOutOfRangeException(nameof(number));
        }
    }
}
