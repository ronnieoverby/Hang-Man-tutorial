using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HangmanGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //=====================================================================
        //THE FOUR VARIABLES BELOW ARE AVAILBLE TO ALL BUTTONS AND METHODS
        //=====================================================================

        private string tbWord;                  //HOLDS THE WORD FROM TEXTBOX
        string newWord;                         //STORE THE NEW WORD
        private HashSet<string> _alreadyPlayed = new HashSet<string>();

        //=====================================================================
        //      THE FORM_LOAD EVENT FILLS THE WORDLIST ARRAY WHEN THE FORM LOADS
        //      NOTICE THAT A METHOD CALLED disableLetters IS CALLED
        //=====================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeLetterButtonEnabled(false);                        //DISABLE ALL THE LETTER BUTTONS


        }

       


        //==============================================================================
        //              THE NEW WORD BUTTON
        //      AS ITS NAME SUGGEST, THIS BUTTON GETS A NEW WORD FROM THE ARRAY
        //      THIS BUTTON ALSO DOES THE FOLOWING
        //              - ADVANCES THE COUNTER FOR THE ARRAY
        //              - ENABLES ALL THE LETTER BUTTONS
        //              - SETS THE NUMBER OF GUESSES A PLAYER HAS
        //              - PUTS 3 * SYMBOLS IN THE TEXTBOX (CHANGE THIS FOR THE EXERCISE!
        //===============================================================================
        private void getNewWord_Click(object sender, EventArgs e)
        {

            do
            {
                newWord = WordList.GetRandomWord();     //GET A NEW WORD 
            } while (_alreadyPlayed.Contains(newWord));

            ChangeLetterButtonEnabled(true);                        //ENABLE ALL THE LETTER BUTTONS
            getNewWord.Enabled = false;
            textBox3.Text = "6";                    //SET THE NUMBER OF GUESSES
            textBox2.Text = new string('*',newWord.Length);                  //PUTS N * SYMBOLS IN THE TEXTBOX
        }


        //=================================================================================
        //                      THE LETTER BUTTONS
        //      WHEN A LETTER BUTTON IS CLICKED, THE METHOD checkGuessedLetter() IS CALLED
        //      THE METHOD TAKES THE FOLLOWING 3 ARGUEMENTS:
        //                  - THE WORD THAT THE PLAYER IS TRYING TO GUESS
        //                  - THE LETTER THAT THE PLAYER CLICKED ON
        //                  - THE LETTER BUTTON ITSELF (letterA, letterB, letterC, etc)
        //      (When you pass a button object, you can then access its properties.
        //       All we want to do is turn off a button when that letter is guessed.)

        //          SCROLL DOWN TO SEE HOW THE checkGuessedLetter() METHOD WORKS
        //=================================================================================

        private void letterA_Click(object sender, EventArgs e)
        {
            var btn = (Button) sender;
            checkGuessedLetter(newWord.ToUpper(), btn.Text, btn);
        }

        



        //==========================================================================================
        //      THIS METHOD DOES ALL THE WORK IN THE PROGRAMME. IT'S ACTUALLY A BIT TOO LONG AND
        //      TRIES TO DO TOO MANY THINGS. IT'S REALLY A FEW DIFFERENT METHODS IN ONE!
        //==========================================================================================

        private void checkGuessedLetter(string wordToGuess, string guessedLetter, Button butName)
        {
            tbWord = textBox2.Text;                //GET THE TEXT THAT'S CURRENTLY IN THE WORD TEXTBOX

            int strLen = wordToGuess.Length;        //USE THE LENGTH PROPERTY OF THE wordToGuess STRING

            int guessesLeft = int.Parse(textBox3.Text); //SEE HOW MANY GUESSES A PLAYER HAS LEFT
 
            int result = 0;
            int counter = 0;
            int foundLen = 0;
            string newChar = "";
            int guessedCorrectlyCounter = 0;

            //==========================================================================
            //          THIS LOOP IS USED TO GRAB CHARACTERS FROM THE WORD TO BE GUESSED
            //          WE THEN COMPARE THE LETTER GUESSED TO SEE IF IT IS IN THE WORD
            //          NOTE THE USE OF THE FOLLOWING STRING METHODS:
            //                  -IndexOf()
            //                  -Substring
            //                  -Remove
            //                  -Insert
            //==========================================================================
            for (int i = 0; i < strLen; i++)
            {
                result = wordToGuess.IndexOf(guessedLetter, foundLen,  strLen - foundLen);

                if (result != -1)
                {
                    foundLen = result + 1;
                    counter++;

                    newChar = wordToGuess.Substring((result), 1);   //grab the letter to be replaced

                    tbWord = tbWord.Remove(result, 1);              //Remove the * character at this position

                    tbWord = tbWord.Insert(result, newChar);        //insert the new character
                    guessedCorrectlyCounter++;
                }
            }

            //=================================================
            //          CHECK THE NUMBER OF GUESSES LEFT
            //=================================================
            if (guessedCorrectlyCounter == 0)
            {
                guessesLeft = guessesLeft - 1;
                textBox3.Text = guessesLeft.ToString();
            }

            //=================================================
            //          CHECK HOW MANY GUESSESS LEFT. 
            //          IF ZERO - GAME OVER, AND RESET
            //=================================================
            _alreadyPlayed.Add(newWord);
            if (guessesLeft == 0)
            {
                txtLosses.Increment();
                MessageBox.Show("You Lost. The word was " + wordToGuess);
                ChangeLetterButtonEnabled(false);
                getNewWord.Enabled = true;
            }
            else
            {
                //PLACE THE NEW VERSION OF THE WORD BACK INTO THE TEXTBOX
                textBox2.Text = tbWord;

                if (tbWord == wordToGuess)      //CHECK IF PLAYER HAS WON
                {
                    txtWins.Increment();
                    MessageBox.Show("You Won - Well Done!");
                    ChangeLetterButtonEnabled(false);
                    getNewWord.Enabled = true;
                }

            }

            //=================================================================================
            //      THIS IS WHERE WE USE THE BUTTON OBJECT THAT WE PASSED OVER TO THE METHOD.
            //      ALL WE'RE DOING IS SWITCHING THE LETTER BUTTON OFF
            //=================================================================================
            butName.Enabled = false;        
        }

        //==========================================================================
        //      THIS METHOD ENABLES ALL THE LETTER BUTTONS AT THE START OF THE GAME
        //==========================================================================
        void ChangeLetterButtonEnabled(bool enabled)
        {
            var letterButtons = Controls.OfType<Button>().Where(x => x.Text.Length == 1);
            foreach (var btn in letterButtons)
                btn.Enabled = enabled;
        }
    }
}