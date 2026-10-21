namespace MethodsPractice;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    /// <summary>
    /// This method checks if a number is within a specific inclusive range.
    /// </summary>
    /// <param name="numToCheck">The number checked if it is within range</param>
    /// <param name="minValue">Minimum inclusive value</param>
    /// <param name="maxValue">Maximum inclusive value</param>
    /// <returns></returns>
    private static bool IsWithinRange(int numToCheck, int minValue, int maxValue)
    {

       // return numToCheck >= minValue && numToCheck <= maxValue;
       // The code above is the same as below witj less syntax

		if (numToCheck >= minValue && numToCheck <= maxValue)
        {
            return true;
        }
        else 
        { 
            return false;
        }
    }

}
