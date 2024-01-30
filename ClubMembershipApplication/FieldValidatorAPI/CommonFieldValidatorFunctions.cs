using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FieldValidatorAPI
{
    public delegate bool RequiredValidDel(string fieldVal);
    public delegate bool StringLenghtValidDel(string fieldVal, int min, int max);
    public delegate bool DateValiDel(string dateTime, out DateTime ValiDateTime);
    public delegate bool FieldPatternMatchDel(string fieldVal, string pattern);
    public delegate bool CompareFieldValiDel(string fieldVal, string FieldValCompare);
    public class CommonFieldValidatorFunctions
    {
        private static RequiredValidDel _requiredValidDel = null;
        private static StringLenghtValidDel _stringLengthValidDel = null;
        private static DateValiDel _dateValidDel = null;
        private static FieldPatternMatchDel _FieldpatternMatchValidDel = null;
        private static CompareFieldValiDel _compareFieldsValidDel = null;


        private static bool RequiredFieldValid(string fieldVal)
        {
            if (!string.IsNullOrEmpty(fieldVal)) return true; 
            
            return false;

        }

        private static bool StringLenghtValid(string fieldVal, int min, int max) {

            if(fieldVal.Length >= min && fieldVal.Length <=max) return true;

            return false;

        }

        private static bool DateValid(string dateTime, out DateTime ValiDateTime) 
        {
            if (DateTime.TryParse(dateTime, out ValiDateTime)) return true;

            return false;
        }

        private static bool FieldPatternMatch(string fieldVal, string pattern)
        { 
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(fieldVal)) return true;

            return false;
        }

    }
}
