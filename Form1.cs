using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Conversion_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void Output()
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void input_addition2_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e) //Run Conversion Button
        {
            bool valid = false; //valid is initialised as false

            string userInput1 = inputBoxConv.Text; //takes the users input into a string


            if (convFromBox.SelectedIndex == 0) //if statements to check the contents of the input combobox to see which subprogram to run
            {
                valid = BinaryInput(userInput1); //binary input
            }


            else if (convFromBox.SelectedIndex == 1)
            {
                valid = DenaryInput(userInput1); //denary input
            }


            else if (convFromBox.SelectedIndex == 2)
            {
                valid = HexadecimalInput(userInput1); //hex input
            }

            else
            {
                valid = false;
            }



            if (valid == true) //if the input was valid (meaning program will run)
            {
                //reset contents of boxes in the conversion section
                inputBoxConv.Clear();
                convFromBox.Text = "Please Select"; 
                convToBox.Text = "Please Select";

                //hides labels for previous chosen option
                chosenBin.Visible = false;
                chosenHex.Visible = false;
                chosenDen.Visible = false;

                //changes the page by hiding the labels and boxes for inputting and showing labels and boxes for comboboxes
                //show labels and boxes for combobox select page
                fromBase.Visible = true;
                toBase.Visible = true;
                convFromBox.Visible = true;
                convToBox.Visible = true;
                selectConvBottomButton.Visible = true;

                //hide labels and boxes for input box enter page
                inputConvLabel.Visible = false;
                inputBoxConv.Visible = false;
                convertButton.Visible = false;
                resetConvButton.Visible = false;
            }

        }



        public bool BinaryInput(string userInput)
        {
            bool valid = true; //valid set true

            if (userInput.Length == 8) //checks length of input to see if it of 8 characters, representing bits
            {

                for (int i = 0; i < 8; i++) //for loop in the range of 8 for the length of a binary input
                {

                    if ((userInput[i] != '1') && (userInput[i] != '0')) //checks if each character is a 1 or 0 for binary
                    {

                        valid = false; //if one character isnt a 1 or 0 it will make valid false, so it wont work.

                    }


                }

                if (valid == false)// since in the loop of valid length, if valid is false it returns an error about characters
                {

                    MessageBox.Show("Invalid Characters;\nMust Be Composed Of 1's and 0's");
                    return false;

                }

                else
                {

                    //not possible for index to be 0 or 3 as it is checked in the select button subprogram
                    if (convToBox.SelectedIndex == 1) //will check contents of convToBox (select output) and will run the subprogram that correlates, index 1 is denary
                    {
                        MessageBox.Show("Your Binary Number Converted to Denary is: " + BinaryToDenary(userInput));
                        return true;

                    }

                    else //index 2 is hexadecimal
                    {
                        MessageBox.Show("Your Binary Number Converted to Hexadecimal is: " + BinaryToHex(userInput));
                        return true;

                    }

                }

            }
            else //input not 8 characters long
            {

                if (userInput.Length > 8) //error if longer than 8
                {

                    MessageBox.Show("Invalid Length;\nInput Too Long (Length Must Be 8)");
                    return false;

                }

                else //error if shorter than 8
                {

                    MessageBox.Show("Invalid Length;\nInput Too Short (Length Must Be 8)");
                    return false;

                }

            }

        }



        public bool DenaryInput(string userInput)  //denary input
        {
            int denaryNum = -1; //set to -1 so if string not converted, it is not valid

            bool isNumeric = int.TryParse(userInput, out denaryNum); //will try to convert to int, if it can it returns true and converts, if it doesnt work it returns false
            
            if (isNumeric == true)
            {

                if ((denaryNum > -1) && (denaryNum < 256)) //checks if the input is a number between 0 and 256
                {

                    //not possible for index to be 1 or 3 as it is checked in the select button subprogram

                    if (convToBox.SelectedIndex == 0) //checks what output if desired from convToBox, and will run the corresponding subprogram, index 0 is binary
                    {

                        MessageBox.Show("Your Denary Number Converted to Binary is: " + DenaryToBinary(denaryNum));
                        return true;

                    }

                    else //not possible to make it here unless combobox2 contains index 2 (hexadecimal)
                    {

                        MessageBox.Show("Your Denary Number Converted to Hexadecimal is: " + BinaryToHex(DenaryToBinary(denaryNum)));
                        return true;

                    }

                }

                else //if not in the range
                {

                    if (denaryNum > 255)
                    {

                        MessageBox.Show("Invalid Denary Input;\nInteger Too Large, Must Be In The Range 0 - 255"); //outputs a message to show input is invalid.
                        return false;

                    }

                    else
                    {

                        MessageBox.Show("Invalid Denary Input;\nInteger Too Small, Must Be In The Range 0 - 255"); //outputs a message to show input is invalid.
                        return false;

                    }

                }

            }

            else //since couldnt convert to int it returns an error on characters
            {

                MessageBox.Show("Invalid Denary Input;\nAll Characters Must Be Integers");
                return false;

            }

        }



        public bool HexadecimalInput(string userInput) //hex input
        {
            bool isOneValid = false; //is char one a valid char?

            bool isTwoValid = false; //is char two a valid char?

            string[] validChars = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" }; //list of valid characters


            if (userInput.Length == 2) //checks the length of the input to see if it is of length 2
            {

                for (int i = 0; i < (validChars.Length); i++)
                {

                    if ((userInput[0].ToString() == validChars[i])) //is character 1 composed of a valid character?
                    {

                        isOneValid = true; //char 1 valid

                    }

                    if ((userInput[1].ToString() == validChars[i])) //is character 2 composed of a valid character?
                    {

                        isTwoValid = true; //char 2 valid

                    }

                }

                if ((isOneValid == true) && (isTwoValid == true)) //both characters of hex are valid
                {

                    //not possible for index to be 2 or 3 as it is checked in the select button subprogram
                    if (convToBox.SelectedIndex == 0) //checks what the desired output is from convToBox and will run the corresponding subprogram, index 0 is binary
                    {

                        MessageBox.Show("Your Hexadecimal Number Converted to Binary is: " + HexToBinary(userInput));
                        return true;

                    }

                    else //index 1 is denary
                    {

                        MessageBox.Show("Your Hexadecimal Number Converted to Denary is: " + BinaryToDenary(HexToBinary(userInput).ToString()));
                        return true;

                    }

                }

                else //return an error if characters are invalid
                {

                    MessageBox.Show("Invalid Characters;\nMust Be Composed Of The Following Characters:\n0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F");
                    return false;

                }

            }

            else //if length not 2  will return errors
            {

                if (userInput.Length > 2) //too long
                {

                    MessageBox.Show("Invalid Length;\nInput Too Long (Length Must Be 2)");
                    return false;

                }


                else //too short
                {

                    MessageBox.Show("Invalid Length;\nInput Too Short (Length Must Be 2)");
                    return false;

                }

            }

        }



        public int BinaryToDenary(string binaryNum) //conversion of binary to denary
        {
            int toDenary = 0; //initialise the variable to store the result

            for (int i = 0; i < (binaryNum.Length); i++) //will allow for both 8 bit binary and nibbles (can be used for binary to hex)
            {

                if (binaryNum[i] == '1') //if character is a 1 then a number should be added to the total
                {

                    toDenary = toDenary + Int32.Parse(Math.Pow(2, ((binaryNum.Length - 1) - i)).ToString()); //power of 2 added to result depending on which character the 1 is stored in

                }

            }

            return toDenary; //returns the result of the conversion

        }



        public string DenaryToBinary(int denaryNum) //conversion of denary to binary
        {

            string toBinary = null; //initialises an empty string to store the binary result

            for (int i = 8; i > 0; i--) //only works for 8 bit binary
            {

                if ((denaryNum - Int32.Parse(Math.Pow(2, i - 1).ToString())) >= 0) //checks if you can subract 2^i-1 as msb stores 128 (2^7) and lsb stores 1 (2^0)
                {

                    denaryNum = (denaryNum - Int32.Parse(Math.Pow(2, i - 1).ToString())); //will do the subraction from the initial denary number
                    toBinary = toBinary + '1'; //will append a 1 to the string as it is being added to the binary

                }

                else
                {

                    toBinary = toBinary + '0'; //will append a 0 to the string as that bit is too large for the denary number we need.

                }

            }

            return toBinary;

        }



        public string BinaryToHex(string binaryNum) //binary to hex
        {

            string nibble1 = binaryNum[0].ToString() + binaryNum[1].ToString() + binaryNum[2].ToString() + binaryNum[3].ToString(); //creates nibble 1

            string nibble2 = binaryNum[4].ToString() + binaryNum[5].ToString() + binaryNum[6].ToString() + binaryNum[7].ToString(); //creates nibble 2


            int nibble1ToDen = BinaryToDenary(nibble1); //converts each nibble to denary

            int nibble2ToDen = BinaryToDenary(nibble2); //converts each nibble to denary


            string hexConv;

            hexConv = nibbleToHex(nibble1ToDen) + nibbleToHex(nibble2ToDen); //runs nibble to hex conversion on both nibbles and stores them together in hexConv
            return hexConv; //returns the result

        }



        public string nibbleToHex(int nibble)
        {

            string hexChar; //initialises hexChar

            switch (nibble)
            {

                case 10: //switch case for checking the denary values (0-15 {16 total possibilities})
                    hexChar = "A";
                    break;

                case 11:
                    hexChar = "B";
                    break;

                case 12:
                    hexChar = "C";
                    break;

                case 13:
                    hexChar = "D";
                    break;

                case 14:
                    hexChar = "E";
                    break;

                case 15:
                    hexChar = "F";
                    break;

                default: //case for integers 0-9 as the character
                    hexChar = nibble.ToString(); //numbers 0-9 are just theire respective numbers in denary as hex.
                    break;

            }

            return hexChar;

        }



        public string HexToBinary(string hexNum) //hex to binary
        {

            string nibble1 = hexCharToNibble(hexNum[0].ToString()); //split the hex in two then perform hex to nibble

            string nibble2 = hexCharToNibble(hexNum[1].ToString()); //split the hex in two then perform hex to nibble

            string binaryConv = nibble1 + nibble2; //concatenate the result into a string

            return binaryConv; //return binary result

        }



        public string hexCharToNibble(string hexChar) //single hex character to nibble
        {
            string nibble; //initialise the nibble variable

            switch (hexChar) //switch case to test each possibility for the hex character, converting it to it respective nibble
            {

                case "0":
                    nibble = "0000";
                    break;

                case "1":
                    nibble = "0001";
                    break;

                case "2":
                    nibble = "0010";
                    break;

                case "3":
                    nibble = "0011";
                    break;

                case "4":
                    nibble = "0100";
                    break;

                case "5":
                    nibble = "0101";
                    break;

                case "6":
                    nibble = "0110";
                    break;

                case "7":
                    nibble = "0111";
                    break;

                case "8":
                    nibble = "1000";
                    break;

                case "9":
                    nibble = "1001";
                    break;

                case "A":
                    nibble = "1010";
                    break;

                case "B":
                    nibble = "1011";
                    break;

                case "C":
                    nibble = "1100";
                    break;

                case "D":
                    nibble = "1101";
                    break;

                case "E":
                    nibble = "1110";
                    break;

                default: //this is the case for "F"
                    nibble = "1111";
                    break;

            }

            return nibble;

        }



        private void Calculate_Click(object sender, EventArgs e) //binary addition button to calculate
        {

            string input1 = inputBoxAdd1.Text; //get input for textbox 1
            string input2 = inputBoxAdd2.Text; //get input for textbox 2

            bool valid = true; //valid default to true

            if ((input1.Length == 8) && (input2.Length == 8)) //validates length and characters of each one
            {

                for (int i = 0; i < 8; i++)
                {

                    if (((input1[i] != '1') && (input1[i] != '0')) || ((input2[i] != '1') && (input2[i] != '0')))
                    {

                        valid = false;

                    }

                }

                if (valid == false)
                {

                    MessageBox.Show("Invalid Characters;\nMust Be Composed Of 1's and 0's");

                }

                else
                {

                    //Convert to denary, add, size check, reconv to binary.
                    int den1 = BinaryToDenary(input1); //Convert inp1 to denary
                    int den2 = BinaryToDenary(input2); //Convert inp2 to denary

                    int total = den1 + den2; //add both

                    if (total > 255) //if greater than 255 (limit of 8 bit binary)
                    {

                        total = total - 256; // subtract the overflow digit

                        string binaryWithOverflow = DenaryToBinary(total); //convert 

                        MessageBox.Show("Overflow Error;\nThe Result Of The Exceeds The Limits Of Being Stored In 8-Bit Binary\nResult: (1) " + binaryWithOverflow);

                    }

                    else
                    {

                        //reconvert and print it out

                        string binaryTotal = DenaryToBinary(total);
                        string format = input1 + " + " + input2 + " =\n" + "In Binary: " + binaryTotal + "\nIn Denary: " + total;

                        MessageBox.Show(format);
                    }

                }

            }

            else //length of either inputs is not 8
            {

                MessageBox.Show("Invalid Length;\nBoth Inputs Must Be 8-Bit Binary Numbers");
                valid = false;

            }

            if (valid == true) //if inputs were valid, means subprogram was ran, so input boxes can be cleared.
            {

                inputBoxAdd1.Clear();
                inputBoxAdd2.Clear();

            }

        }



        private void RESETCONVERSION_Click(object sender, EventArgs e) //reset button for the conversion side on the gui
        {

            //hide the input text box and labels | show comboboxes, clearing them too, and showing the neccessary labels for it.
            //screen2
            //reset input box
            inputBoxConv.Clear();
            //reset comboboxes
            convFromBox.Text = "Please Select";
            convToBox.Text = "Please Select";
            //labels
            fromBase.Visible = true;
            toBase.Visible = true;
            //comboboxes
            convFromBox.Visible = true;
            convToBox.Visible = true;
            //button
            selectConvBottomButton.Visible = true;

            //screen2
            //label
            inputConvLabel.Visible = false;
            //input box
            inputBoxConv.Visible = false;
            //buttons
            convertButton.Visible = false;
            resetConvButton.Visible = false;


            //hide the "Chosen:" labels
            chosenBin.Visible = false;
            chosenHex.Visible = false;
            chosenDen.Visible = false;    

        }



        private void RESETCALCULATION_Click(object sender, EventArgs e)//reset button for binary addition
        {

            inputBoxAdd1.Clear(); //clear both input textboxes
            inputBoxAdd2.Clear();

        }



        private void select_conv_Click(object sender, EventArgs e) //select button (selecting what conversion you want)
        {

            if (!(convFromBox.SelectedIndex == 3) && !(convToBox.SelectedIndex == 3) && !(convFromBox.SelectedIndex == convToBox.SelectedIndex)) //Checks if user has selected a valid option in the comboboxes (not "Please Select") 
            {

                //hide the combo boxes and labels and select button
                //labels
                fromBase.Visible = false;
                toBase.Visible = false;
                //comboboxes
                convFromBox.Visible = false;
                convToBox.Visible = false;
                //button
                selectConvBottomButton.Visible = false;


                //show the labels and text box for inputting a number
                //label
                inputConvLabel.Visible = true; 
                //input box
                inputBoxConv.Visible = true;
                //buttons
                convertButton.Visible = true;
                resetConvButton.Visible = true;


                if (convFromBox.SelectedIndex == 0) //if combobox index selected is 0 - it means binary
                {

                    chosenBin.Visible = true; //show the label "Chosen:" for binary

                }

                else if (convFromBox.SelectedIndex == 1)
                {

                    chosenDen.Visible = true; //show the label "Chosen:" for denary

                }

                else
                {

                    chosenHex.Visible = true; //show the label "Chosen:" for hexadecimal

                }

            }

            else if ((convFromBox.SelectedIndex == 3) || (convToBox.SelectedIndex == 3)) //"please select" is selected in one of the comboboxes, which isnt valid
            {

                MessageBox.Show("Please Select Valid Options (Binary, Denary or Hexadecimal)");

            }

            else //if both boxes input are the same
            {

                MessageBox.Show("Please Do Not Select The Same Option For Both Boxes;\nChange One Box To Complete A Valid Conversion");

            }

        }


        private void input_convert_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (convFromBox.SelectedIndex == 0) //input binary
            {

                inputBoxConv.MaxLength = 8; //change max length to 8 in the text box for 8 bit binary

                if (!isBinary(e.KeyChar) && !char.IsControl(e.KeyChar)) //if not an accepted binary character (isBinary subprogram) or a control character (like enter or backslash) then:
                {

                    e.Handled = true; //dont accept input
                    MessageBox.Show("Error: Please Enter The Allowed Characters In The Centre Of The Page (Binary)"); //return an error message
                
                }


                if (e.KeyChar == (char)Keys.Enter) //if input is an enter key then run the program of clicking the convert button
                {

                    button1_Click(this, new EventArgs()); 
                
                }

            }


            else if (convFromBox.SelectedIndex == 1) //input denary
            {
                
                inputBoxConv.MaxLength = 3; //change max length to 3 in the text box so that numbers over 3 digits cannot be entered (255 is max)

                if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) //if not number or a control character (like enter or backslash) then:
                {
                    
                    e.Handled = true; //dont accept input
                    MessageBox.Show("Error: Please Enter The Allowed Characters In The Centre Of The Page (Denary)"); //return error as its not accepted input
                
                }


                if (e.KeyChar == (char)Keys.Enter) //if input is an enter key then run the program of clicking the convert button
                {
                    
                    button1_Click(this, new EventArgs());
                
                }

            }


            else //input hexadecimal
            {

                inputBoxConv.MaxLength = 2; //change max length to 2 in the text box 

                if (!isHex(e.KeyChar) && !char.IsControl(e.KeyChar)) //if not part of accepted hex input (isHex subprogram) or a control character (like enter or backslash) then:
                {

                    e.Handled = true; //dont accept input
                    MessageBox.Show("Error: Please Enter The Allowed Characters In The Centre Of The Page (Hexadecimal)"); //return an error message

                }


                if (e.KeyChar == (char)Keys.Enter) //if input is an enter key then run the program of clicking the convert button
                {

                    button1_Click(this, new EventArgs());

                }

            }

        }


        public bool isBinary(char char_input) //binary input check
        {

            string input = char_input.ToString(); //create variable to convert char to string


            if ((input == "0") || (input == "1")) //check if input is 1 or 0
            {

                return true; //if yes return true

            }


            else
            {

                return false; //if no return false

            }

        }


        public bool isHex(char char_input) //hex input check
        {

            string input = char_input.ToString(); //create variable to convert char to string | below is the check against the accepted inputs for hex.

            if ((input == "0") || (input == "1") || (input == "2") || (input == "3") || (input == "4") || (input == "5") || (input == "6") || (input == "7") || (input == "8") || (input == "9") || (input == "A") || (input == "B") || (input == "C") || (input == "D") || (input == "E") || (input == "F"))
            {

                return true; //if character is one of the above return true

            }


            else
            {

                return false; //if not return false

            }
        }



        private void input_addition1_KeyPress(object sender, KeyPressEventArgs e) //check for inputting num1 for binary addition
        {

            if (!isBinary(e.KeyChar) && !char.IsControl(e.KeyChar)) //if not an accepted binary character (isBinary subprogram) or a control character (like enter or backslash) then:
            {

                e.Handled = true; //dont accept input

            }

            if (e.KeyChar == (char)Keys.Enter) //if key entered is enter then run the button for calculating binary addition
            {

                Calculate_Click(this, new EventArgs());

            }

        }



        private void input_addition2_KeyPress(object sender, KeyPressEventArgs e) //check for inputting num2 for binary addition
        {

            if (!isBinary(e.KeyChar) && !char.IsControl(e.KeyChar)) //if not an accepted binary character (isBinary subprogram) or a control character (like enter or backslash) then:
            {

                e.Handled = true; //dont accept input

            }

            if (e.KeyChar == (char)Keys.Enter) //if key entered is enter then run the button for calculating binary addition
            {

                Calculate_Click(this, new EventArgs());

            }

        }



        private void button2_Click(object sender, EventArgs e) //select button for converting
        {

            //hide the labels describing conversion and show the label describing binary addition
            //conv description hidden
            convDesc1.Visible = false;
            convDesc2.Visible = false;
            //add description shown
            addDesc.Visible = true;


            //show comboboxes and respective labels, hide input boxes and its respective labels (showing base gui for conversion)
            //labels screen1
            fromBase.Visible = true;
            toBase.Visible = true;
            //comboboxes screen1
            convFromBox.Visible = true;
            convToBox.Visible = true;
            //label screen2 
            inputConvLabel.Visible = false;
            //input box screen 2
            inputBoxConv.Visible = false;
            //buttons
            convertButton.Visible = false;
            resetConvButton.Visible = false;
            selectConvBottomButton.Visible = true;
            //back button
            backButton.Visible = true;


            //show labels describing which inputs are restricted
            //inputs restricted label
            inputsRestricted.Visible = true;
            //binary restrictions
            restrictionBin1.Visible = true;
            restrictionBin2.Visible = true;
            //hexadecimal restrictions
            restrictionHex1.Visible = true;
            restrictionHex2.Visible = true;
            restrictionHex3.Visible = true;
            //denary restrictions
            restrictionDen1.Visible = true;
            restrictionDen2.Visible = true;


            //hide top select button for converting and show selected button for converting
            selectedConv.Visible = true;
            selectConvTopButton.Visible = false;
            //show top select button for addition and hide selected button for addition
            selectAddButton.Visible = true;
            selectedAddButton.Visible = false;


            //hide the inputs and buttons and labels for binary addition, clearing the text boxes too
            //label
            binAddLabel1.Visible = false;
            //input box
            inputBoxAdd1.Visible = false;
            inputBoxAdd2.Visible = false;
            //plus sign label
            binAddPlusSign.Visible = false;
            //buttons
            calculateAdditionButton.Visible = false;
            resetAdditionButton.Visible = false;
            //clear input boxes
            inputBoxAdd1.Clear();
            inputBoxAdd2.Clear();

        }



        private void button3_Click(object sender, EventArgs e) //select button for addition
        {

            //hide the description for binary addition, show the description for conversion
            convDesc1.Visible = true;
            addDesc.Visible = false;
            convDesc2.Visible = true;


            //show the gui menu for binary addition
            binAddLabel1.Visible = true;
            //input boxes
            inputBoxAdd1.Visible = true;
            inputBoxAdd2.Visible = true;
            //plus sign label
            binAddPlusSign.Visible = true;
            //buttons
            calculateAdditionButton.Visible = true;
            resetAdditionButton.Visible = true;
            backButton.Visible = true;

            //hide labels describing which inputs are restricted 
            //inputs restricted label
            inputsRestricted.Visible = false;
            //binary restrictions
            restrictionBin1.Visible = false;
            restrictionBin2.Visible = false;
            //hexadecimal restrictions
            restrictionHex1.Visible = false;
            restrictionHex2.Visible = false;
            restrictionHex3.Visible = false;
            //denary restrictions
            restrictionDen1.Visible = false;
            restrictionDen2.Visible = false;

            //show labels describing which inputs are restricted only for binary
            inputsRestricted.Visible = true;
            restrictionBin1.Visible = true;
            restrictionBin2.Visible = true;

            //hide the "Chosen:" labels in the middle
            chosenBin.Visible = false;
            chosenHex.Visible = false;
            chosenDen.Visible = false;


            //hide top select button for addition and show selected button for addition
            selectAddButton.Visible = false;
            selectedAddButton.Visible = true;
            //show top select button for converting and hide selected button for converting
            selectedConv.Visible = false;
            selectConvTopButton.Visible = true;


            //hide labels,buttons,text boxes and comboboxes
            //labels
            fromBase.Visible = false;
            toBase.Visible = false;
            //comboboxes
            convFromBox.Visible = false;
            convToBox.Visible = false;
            //input label
            inputConvLabel.Visible = false;
            //input box
            inputBoxConv.Visible = false;
            //buttons
            convertButton.Visible = false;
            resetConvButton.Visible = false;
            selectConvBottomButton.Visible = false;


            //clearing the contents of comboboxes and input box
            inputBoxConv.Clear();
            //reset the text in the combobox
            convFromBox.Text = "Please Select";
            convToBox.Text = "Please Select";

        }



        private void button4_Click(object sender, EventArgs e) //back button
        {
            //show the description for binary addition, show the description for conversion
            convDesc1.Visible = true;
            addDesc.Visible = true;
            convDesc2.Visible = true;


            //hide menu for conversion and clear contents of boxes, and hide the back button too
            
            //conversion side
            //labels for screen1 conv
            fromBase.Visible = false;
            toBase.Visible = false;
            //comboboxes
            convFromBox.Visible = false;
            convToBox.Visible = false;
            //label for screen2 conv
            inputConvLabel.Visible = false;
            //inputbox conv
            inputBoxConv.Visible = false;
            //buttons for conv
            convertButton.Visible = false;
            resetConvButton.Visible = false;
            selectConvBottomButton.Visible = false;
            //clear boxes conv
            inputBoxConv.Clear();
            convFromBox.Text = "Please Select";
            convToBox.Text = "Please Select";


            //back button
            backButton.Visible = false;


            //show the boxes "select" at the top of the page for conversion and binary addition
            //select conv, select add buttons
            selectConvTopButton.Visible = true;
            selectAddButton.Visible = true;
            //hide the "selected" buttons
            selectedConv.Visible = false;
            selectedAddButton.Visible = false;

            //hide menu for addition and clear the contents of boxes
            //labels
            binAddLabel1.Visible = false;
            binAddPlusSign.Visible = false;
            //input boxes
            inputBoxAdd1.Visible = false;
            inputBoxAdd2.Visible = false;
            //buttons
            calculateAdditionButton.Visible = false;
            resetAdditionButton.Visible = false;
            //clear contents
            inputBoxAdd1.Clear();
            inputBoxAdd2.Clear();

            //hide the restrictions in the middle of the page and hide "Chosen:" buttons
            inputsRestricted.Visible = false;
            //binary,denary,hex
            //binary
            restrictionBin1.Visible = false;
            restrictionBin2.Visible = false;
            //hex
            restrictionHex1.Visible = false;
            restrictionHex2.Visible = false;
            restrictionHex3.Visible = false;
            //denary
            restrictionDen1.Visible = false;
            restrictionDen2.Visible = false;
            //chosen labels
            chosenBin.Visible = false;
            chosenHex.Visible = false;
            chosenDen.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void convDesc2_Click(object sender, EventArgs e)
        {

        }
    }
}
