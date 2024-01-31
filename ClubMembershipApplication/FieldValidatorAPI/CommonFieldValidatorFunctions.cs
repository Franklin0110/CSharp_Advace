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
    public delegate bool DateFieldValidDel(string dateTime, out DateTime ValiDateTime);
    public delegate bool FieldPatternMatchDel(string fieldVal, string pattern);
    public delegate bool CompareFieldValidDel(string fieldVal, string FieldValCompare);


    public class CommonFieldValidatorFunctions
    {
        private static RequiredValidDel _requiredValidDel = null;
        private static StringLenghtValidDel _stringLengthValidDel = null;
        private static DateFieldValidDel _dateFieldValidDel = null;
        private static FieldPatternMatchDel _FieldpatternMatchValidDel = null;
        private static CompareFieldValidDel _compareFieldsValidDel = null;

        public static FieldPatternMatchDel PatternFieldMatchDel
        {
            get
            {
                if (_FieldpatternMatchValidDel == null) _FieldpatternMatchValidDel = new FieldPatternMatchDel(FieldPatternMatch);

                return _FieldpatternMatchValidDel;


            }

        }
        public static CompareFieldValidDel FieldCompareValidDel
        {
            get
            {
                if (_compareFieldsValidDel == null) _compareFieldsValidDel = new CompareFieldValidDel(FieldComparisonValid);

                return _compareFieldsValidDel;


            }

        }

        public static RequiredValidDel RequiredValidDel
        {
            get
            {
                if (_requiredValidDel == null) _requiredValidDel = new RequiredValidDel(RequiredFieldValid);

                return _requiredValidDel;


            }

        }

        public static StringLenghtValidDel StringLengthFieldValidDel
        {
            get
            {
                if (_stringLengthValidDel == null) _stringLengthValidDel = new StringLenghtValidDel(StringLenghtValid);

                return _stringLengthValidDel;


            }

        }

        public static DateFieldValidDel DateFieldValidDel
        {
            get
            {
                if (_dateFieldValidDel == null) _dateFieldValidDel = new DateFieldValidDel(DateFieldValid);

                return _dateFieldValidDel;
            }
        }


        private static bool RequiredFieldValid(string fieldVal)
        {
            if (!string.IsNullOrEmpty(fieldVal)) return true;

            return false;

        }

        private static bool StringLenghtValid(string fieldVal, int min, int max)
        {

            if (fieldVal.Length >= min && fieldVal.Length <= max) return true;

            return false;

        }

        private static bool DateFieldValid(string dateTime, out DateTime ValiDateTime)
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

        private static bool FieldComparisonValid(string field1, string field2)
        {
            if (field1.Equals(field2)) return true;
            return false;
        }

    }
}
