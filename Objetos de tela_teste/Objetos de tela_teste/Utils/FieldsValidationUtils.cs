
using System.Windows.Forms;
namespace Objetos_de_tela_teste.Utils
{
    public static class FieldsValidationUtils
    {
        public static bool ValidateLaserFields(Control name, Control iMin, Control iMax, Control increment, Control Ntc, ErrorProvider errorProvider)
        {
            bool laserValidationResult = false;
            bool validateIMax = false;
            bool validateNtc = false;
            bool validateLaserName = false;
            bool validateIncrement = false;
            bool validateIMin = false;
            if (!string.IsNullOrEmpty(iMax.Text))
            {
                validateIMax = ValidateIMax(iMax, int.Parse(iMax.Text), errorProvider);
            }

            if (!string.IsNullOrEmpty(iMin.Text))
            {
                validateIMin = ValidateIMax(iMin, int.Parse(iMin.Text), errorProvider);
            }

            if (!string.IsNullOrEmpty(Ntc.Text))
            {
                validateNtc = ValidateNtc(Ntc, int.Parse(Ntc.Text), errorProvider);
            }

            validateLaserName = !string.IsNullOrWhiteSpace(name.Text);
            validateIncrement = !string.IsNullOrWhiteSpace(increment.Text);

            if (validateIMax && validateNtc && validateLaserName && validateIncrement && validateIMin)
            {
                laserValidationResult = true;
            }
            else
            {
                laserValidationResult = false;
            }

            return laserValidationResult;
        }

        public static bool ValidateTempeatureLaserFields(Control name, Control NtcMin, Control NtcMax, Control increment, Control Iop, ErrorProvider errorProvider)
        {
            bool laserValidationResult = false;
            bool validateNtcMax = false;
            bool validateIop = false;
            bool validateLaserName = false;
            bool validateIncrement = false;
            bool validateNtcMin = false;
            if (!string.IsNullOrEmpty(NtcMax.Text))
            {
                validateNtcMax = ValidateNtc(NtcMax, int.Parse(NtcMax.Text), errorProvider);
            }

            if (!string.IsNullOrEmpty(NtcMin.Text))
            {
                validateNtcMin = ValidateNtc(NtcMin, int.Parse(NtcMin.Text), errorProvider);
            }

            if (!string.IsNullOrEmpty(Iop.Text))
            {
                validateIop = ValidateIMax(Iop, int.Parse(Iop.Text), errorProvider);
            }

            validateLaserName = !string.IsNullOrWhiteSpace(name.Text);
            validateIncrement = !string.IsNullOrWhiteSpace(increment.Text);

            if (validateNtcMax && validateIop && validateLaserName && validateIncrement && validateNtcMin)
            {
                laserValidationResult = true;
            }
            else
            {
                laserValidationResult = false;
            }

            return laserValidationResult;
        }

        public static bool ValidateIMax(Control control, int value, ErrorProvider errorProvider)
        {
            bool result = false;
            if (value > 110)
            {
                errorProvider.SetError(control, "Corrente máxima permitida: 110mA");
            }
            else
            {
                errorProvider.SetError(control, string.Empty);
                result = true;
            }

            return result;
        }

        private static bool ValidateNtc(Control control, int value, ErrorProvider errorProvider)
        {
            bool result = false;
            if (value < 4400 | value > 20000)
            {
                errorProvider.SetError(control, "Valores de NTC devem estar entre 4400 e 20000");
            }
            else
            {
                errorProvider.SetError(control, string.Empty);
                result = true;
            }

            return result;
        }
    }
}