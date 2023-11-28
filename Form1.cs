using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRG521_FA3_TaxCalculator
{
    public partial class TaxCalculator : Form
    {
        // This is the form
        public TaxCalculator()
        {
            InitializeComponent();
        }

        // This is the 'Save amount' label
        private void SamountLabel_Click(object sender, EventArgs e)
        {

        }

        // This is the 'Save Tax' label
        private void StaxLabel_Click(object sender, EventArgs e)
        {

        }

        // This is the text box where the user will have to input the Rand amount.
        private void UserTexBox_TextChanged(object sender, EventArgs e)
        {

        }

        // This is the numeric box containing the 0 to 25% range.
        private void PercNum_ValueChanged(object sender, EventArgs e)
        {

        }

        // This is the submit button. When it is clicked the calculations must start and be saved to the txt file.
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(UserTexBox.Text, out double Sales_Amount_Text))
                {
                    double Tax_Amount = (double)PercNum.Value;
                    if (Tax_Amount >= 0 && Tax_Amount <= 25)
                    {
                        double taxAmount = Sales_Amount_Text * (Tax_Amount / 100);
                        double Amount_Total = Sales_Amount_Text + taxAmount;
                        string Total_Result = $"Tax on {Sales_Amount_Text:C} at {Tax_Amount}% is {taxAmount:C}. The total is {Amount_Total:C}";

                        // The result must be saved to the TaxCalculation.txt file with the date and time included.
                        string FileName = "TaxCalculation.txt";
                        string Formatted_Result = $"{DateTime.Now}: {Total_Result}";
                        SaveToFile(FileName, Formatted_Result);

                        MessageBox.Show(Total_Result, "Tax Calculation Result: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // When user does not enter the correct tax amount they must recieve an error message. 
                        string error_Message = "The tax rate you have entered is invalid.\n Please enter a tax rate between 0 and 25%";
                        Exception_To_File_Save(error_Message);
                        MessageBox.Show(error_Message, "Invalid Tax Rate: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // When the user does not enter a numeric value they must recieve an error message.
                    string error_Message = "The value you have entered is not of numeric value. \n Please enter a numeric value for sales amount. ";
                    Exception_To_File_Save(error_Message);
                    MessageBox.Show(error_Message, "Invalid Input: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            // When the user does not enter the correct input an erroe message must appear.
            catch (Exception ex)
            {
                string error_Message = $"An error occurred: {ex.Message}";
                Exception_To_File_Save(error_Message);
                MessageBox.Show(error_Message, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Save all the data to the file.
        private void SaveToFile(string fileName, string content)
        {
            using (var writer = new System.IO.StreamWriter(fileName, true))
            {
                writer.WriteLine(content);
            }
        }

        // When an error appears, save it to Exceptionfile.txt
        private void Exception_To_File_Save(string errorMessage)
        {
            string FileName = "Exceptionfile.txt";
            string Formatted_Message = $"{DateTime.Now}: {errorMessage}";
            SaveToFile(FileName, Formatted_Message);
        }

        // This is the clear button. When the user clicks it all the fields will be reset.
        private void ClearButton_Click(object sender, EventArgs e)
        {
            UserTexBox.Clear();
            PercNum.Value = 0;
        }

        // This is the exit button. When it is clicked the form will be closed.
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
