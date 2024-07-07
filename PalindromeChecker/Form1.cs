
using System;
using System.Windows.Forms;

namespace PalindromeChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;

            if (IsNumericPalindrome(input))
            {
                lblResult.Text = $"{input} is a palindrome.";
            }
            else
            {
                lblResult.Text = $"{input} is not a palindrome.";
            }
        }

        static bool IsNumericPalindrome(string number)
        {
            int left = 0;
            int right = number.Length - 1;

            while (left < right)
            {
                if (number[left] != number[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
