using System;

namespace WebApplication2
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void CalculateButton_Click(object sender, EventArgs e)
        {
            
            string expression = expressionInput.Value.Trim(); 

            
            var solution = new Solution();

            
            int result = solution.Calculate(expression);

            
            ResultLabel.Text = "Result: " + result.ToString();
        }
    }
}
