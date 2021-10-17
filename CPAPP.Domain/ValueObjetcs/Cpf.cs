using System;
using System.Text.RegularExpressions;

namespace CPAPP.Domain.ValueObjetcs
{
    public struct Cpf
    {
        private readonly string _cleanedValue;
        private readonly string _originalValue;
        
        public Cpf(string value)
        {
            _cleanedValue = null;
            _originalValue = null;

            if (!string.IsNullOrEmpty(value))
            {
                _cleanedValue = value
                    .Replace(".", string.Empty)
                    .Replace("-", string.Empty);

                _originalValue = value;
            }
        }
        
        public bool IsValid()
        {
            var cpfComMascara = new Regex(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$");

            try
            {
                if (cpfComMascara.IsMatch(_originalValue))
                    return true;

                if (_originalValue.Length == _cleanedValue.Length && _originalValue.Length == 11)
                    return true;
            }
            catch (Exception)
            {
                return false;
            }

            return false;
        }
    }
}