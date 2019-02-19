using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Threading.Tasks;

public partial class JobTest : System.Web.UI.Page
{
    int[] a;

    protected void Page_Load(object sender, EventArgs e)
    {
        ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
    }

    public void Check(object sender, EventArgs e)
    {
        string letters = results.Text;

        string[] bubbleArr = letters.Split(','); //Takes the letters string and splits all values element by element and append to the array

        //If statements are meant to check if either value was selected from the dropdown menu
       

        if (SortingType.SelectedValue == "Bubble Sort")
        {
            bubbleSort(bubbleArr);
        }

        if (SortingType.SelectedValue == "List Sort")
        {
            listSort();
        }
    }

    public void listSort()
    {
        int i, j, temp; // Variables for the counters and the temporary storage to swap values.
        List<string> array = new List<string>(); //Creating an instance of a list of the type string
        List<int> arrayInt = new List<int>(); //Creating an instance for a list of type int named arrayInt

        array.AddRange(results.Text.Split(',').Select(txt => txt.Trim()).ToArray()); 
        //Adding any string values into a string array which are split into separate elements following ',' and trimming any potential whitespace.



        arrayInt = array.Select(s => int.Parse(s)).ToList(); //Converting string array to int array

        for (i = 1; i < array.Count(); i++) //Sorting everything with bubble sort algorithm.
        {
            j = i;

            while (j > 0 && arrayInt[j - 1] > arrayInt[j]) //j will always decrement and the sort will happen as long as the first element preceding the latest is greater
            {
                temp = arrayInt[j]; // Storing the value into temp
                arrayInt[j] = arrayInt[j - 1]; //Shifting values
                arrayInt[j - 1] = temp;
                j--;

                for (i = 0; i < array.Count(); i++)
                {
                    results.Text += arrayInt[i] + " "; //Printing the values to the textBox
                }
            }

        }
    }

    public void bubbleSort(string [] letters)
    {
            bool swap;
            string temp; 

            do
            {
                swap = false;

                for (int index = 0; index < (letters.Length - 1); index++)
                {
                    if (string.Compare(letters[index], letters[index + 1]) < 0) //if first number is greater then second then swap
                    {
                        //swap

                        temp = letters[index]; //store current value in variable temp
                        letters[index] = letters[index + 1]; //Switch values around 
                        letters[index + 1] = temp;
                        swap = true; //bool is true
                    }
                }

            } while (swap == true);

        for (int i = 0; i < letters.Count(); i++)
        {
            results.Text += letters[i] + " ";//Print the sorted value
        }
    }
        
    }