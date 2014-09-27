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

        public int GuessesLeft
        {
            get { return int.Parse(txtGuessesLeft.Text); }
            set { txtGuessesLeft.Text = value.ToString(); }
        }

        public string Display
        {
            get { return txtWordBox.Text; } 
            set { txtWordBox.Text = value; }
        }

        private readonly Queue<string> _wordQueue = new Queue<string>(WordList.AllWords.Shuffle());
        private string _theSecretWord;
        private readonly List<char> _guesses = new List<char>();

        private void Form1_Load(object sender, EventArgs e)
        {
            SetLetterButtonEnabled(false);                        //DISABLE ALL THE LETTER BUTTONS
        }

        private void getNewWord_Click(object sender, EventArgs e)
        {
            _theSecretWord = _wordQueue.Dequeue();     //GET NEXT WORD
            _guesses.Clear();

            SetLetterButtonEnabled(true);                        //ENABLE ALL THE LETTER BUTTONS
            getNewWord.Visible = false;
            txtGuessesLeft.Text = "6";                    //SET THE NUMBER OF GUESSES
            txtWordBox.Text = new string('*', _theSecretWord.Length);                  //PUTS N * SYMBOLS IN THE TEXTBOX
        }

        private void LetterButtonClick(object sender, EventArgs e)
        {
            CheckGuessedLetter(_theSecretWord.ToUpper(), ((Button) sender).Text[0], (Button) sender);
        }

        private void CheckGuessedLetter(string wordToGuess, char guessedLetter, Button btn)
        {
            btn.Enabled = false;
            _guesses.Add(guessedLetter);
            Display = string.Concat(wordToGuess.Select(c => _guesses.Contains(c) ? c : '*'));

            var goodGuess = wordToGuess.Contains(guessedLetter);

            if (!goodGuess)
                GuessesLeft--;

            if (GuessesLeft == 0)
            {
                txtLosses.Increment();
                MessageBox.Show("You Lost. The word was " + wordToGuess);
                SetLetterButtonEnabled(false);
                getNewWord.Visible = true;
            }
            else if (Display == wordToGuess)
            {
                txtWins.Increment();
                MessageBox.Show("You Won - Well Done!");
                SetLetterButtonEnabled(false);
                getNewWord.Enabled = true;
            }
        }


        void SetLetterButtonEnabled(bool enabled)
        {
            var letterButtons = Controls.OfType<Button>().Where(x => x.Text.Length == 1);
            foreach (var btn in letterButtons)
                btn.Enabled = enabled;
        }
    }
}