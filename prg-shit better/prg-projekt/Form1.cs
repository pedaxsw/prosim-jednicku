﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Media;
using System.Windows.Forms;

namespace prg_projekt
{
    public partial class Form1 : Form
    {
        private SoundPlayer? player;
        private List<KeyValuePair<string, string>> dictionary = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("hej", "hello"),
            new KeyValuePair<string, string>("tack", "thank you"),
            new KeyValuePair<string, string>("god dag", "good day"),
            new KeyValuePair<string, string>("hej då", "goodbye"),
            new KeyValuePair<string, string>("ja", "yes"),
            new KeyValuePair<string, string>("nej", "no"),
            new KeyValuePair<string, string>("bra", "good"),
            new KeyValuePair<string, string>("nej", "no"),
            new KeyValuePair<string, string>("hus", "house"),
            new KeyValuePair<string, string>("hund", "dog"),
            new KeyValuePair<string, string>("tåg", "train"),
            new KeyValuePair<string, string>("sjuk", "sick"),
            new KeyValuePair<string, string>("kunde", "could"),
            new KeyValuePair<string, string>("läsa", "read"),
            new KeyValuePair<string, string>("skriva", "write"),
            new KeyValuePair<string, string>("säga", "say"),
            new KeyValuePair<string, string>("sverige", "sweden"),
            new KeyValuePair<string, string>("jag", "I"),
            new KeyValuePair<string, string>("du", "you"),
            new KeyValuePair<string, string>("är", "are"),
            new KeyValuePair<string, string>("snabel", "trunk"),
            new KeyValuePair<string, string>("engelska", "english"),
            new KeyValuePair<string, string>("bara", "only"),
            new KeyValuePair<string, string>("göra", "do"),
            new KeyValuePair<string, string>("lärare", "teacher"),
        };
        private int wrong = 0;
        private int correct = 0;
        private int currentIndex = 0;
        private int numero = 0;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            menu_text.Visible = false;
            test.Visible = false;
            learn.Visible = false;
            learn_text.Visible = false;
            yourAnswer.Visible = false;
            learning_next.Visible = false;
            selected.Visible = false;
            start_learning.Visible = false;
            learning_next.Visible = false;
            learning_text.Visible = false;
            wrongL.Visible = false;
            correctL.Visible = false;
            ruka.Visible = false;
            pusa.Visible = false;
            bad.Visible = false;
            learn_score.Visible = false;
            question.Visible = false;
            start_test.Visible = false;
            test_next.Visible = false;
            trans.Visible = false;
            test_text.Visible = false;
            testing_text.Visible = false;

            learn_text.Text = "You are now in Test section, you can test yourself \nfrom the words that you have learnt, Lycka Till!";
            Welcome_text.Text = "Hej! My name is Tom and I will be your tutor at your swedish jorney :))";




        }


        private void nextButton_Click(object sender, EventArgs e)
        {
            // move to the next word in the queue
            currentIndex++;
            if (currentIndex == dictionary.Count)
            {
                currentIndex = 0;
            }
            selected.Text = dictionary[currentIndex].Key;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            string mp3File = "C:\\Users\\Danko\\Desktop\\prg-shit better\\prg-projekt\\bin\\Debug\\net6.0-windows\\app_sweden.wav";

            player = new SoundPlayer(mp3File);
            player.PlayLooping();

        }

        private void menu_Click(object sender, EventArgs e)
        {
            Welcome_text.Visible= false;
            menu.Visible=false;
            menu_text.Visible = true;
            test.Visible = true;
            learn.Visible = true;
            learn_text.Visible = false;
            start_learning.Visible = false;
            selected.Visible = false;
            yourAnswer.Visible = false;
            learning_next.Visible = false;
            learning_text.Visible = false;
            wrongL.Visible = false;
            correctL.Visible = false;
            ruka.Visible = false;
            pusa.Visible = false;
            bad.Visible = false;
            learn_score.Visible = false;
            question.Visible = false;
            start_test.Visible = false;
            test_next.Visible = false;
            trans.Visible = false;
            test_text.Visible = false;
            testing_text.Visible = false;


            menu.Text = "Menu";
            correct = 0;
            wrong = 0;

            wrongL.Text = "Wrong: ";
            correctL.Text = "Correct: ";
            yourAnswer.Text = "";
            question.Text = "0" + " / " + "15";
            numero = 0;


        }

        private void tom_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_text_Click(object sender, EventArgs e)
        {

        }

        private void menu_text_Click(object sender, EventArgs e)
        {

        }

        private void test_Click(object sender, EventArgs e)
        {
            Welcome_text.Visible = false;
            menu.Visible = false;
            menu_text.Visible = false;
            test.Visible = false;
            learn.Visible = false;
            menu.Visible = true;
            learn_text.Visible = false;
            start_learning.Visible = false;
            learning_text.Visible = false;
            ruka.Visible = false;
            pusa.Visible = false;
            bad.Visible = false;
            learn_score.Visible = false;
            start_test.Visible = true;
            test_text.Visible = true;
        }

        private void learn_Click(object sender, EventArgs e)
        {
            Welcome_text.Visible = false;
            menu.Visible = false;
            menu_text.Visible = false;
            test.Visible = false;
            learn.Visible = false;
            menu.Visible = true;
            learn_text.Visible = true;
            start_learning.Visible = true;
            learning_text.Visible = false;
            ruka.Visible = false;
            pusa.Visible = false;
            bad.Visible = false;
            learn_score.Visible = false;


        }

        private void learn_text_Click(object sender, EventArgs e)
        {

        }

        private void learning_next_Click(object sender, EventArgs e)
        {
            numero += 1;
            question.Text = numero + " / " + "15";
            // move to the next word in the queue
            currentIndex++;
            if (currentIndex == dictionary.Count)
            {
                currentIndex = 0;
            }
            selected.Text = dictionary[currentIndex].Key;

            if (currentIndex == 16)
            {
                learning_next.Visible = false;
                pusa.Visible = false;
                ruka.Visible = false;
                bad.Visible = false;
                yourAnswer.Visible = false;
                selected.Visible = false;
                learning_text.Visible = false;
                wrongL.Visible = false;
                correctL.Visible = false;

            }
            else
            {
                learning_next.Visible = true;
            }

            int ubrany = currentIndex - 1;
            if (yourAnswer.Text == dictionary[ubrany].Value)
            {
                correct += 1;
                correctL.Text = "Correct: " + correct;

                bad.Visible = false;
                pusa.Visible = true;
                ruka.Visible = true;

                if (!(currentIndex == 16))
                {
                    bad.Visible = false;
                    ruka.Visible = true;
                    pusa.Visible = true;

                    learn_score.Text = "Your score is " + correct + " answers right and " + wrong + " answers wrong.";
                }
                else
                {
                    bad.Visible = false;
                    pusa.Visible = false;
                    ruka.Visible = false;
                }
          


              
            }
            else
            {   //"Wrong: " + wrong;
                wrong += 1;
                wrongL.Text = "Wrong: " + wrong;

                bad.Visible = true;
                pusa.Visible = false;
                ruka.Visible = false;
                if (!(currentIndex == 16))
                {
                    bad.Visible = true;
                    ruka.Visible = false;
                    pusa.Visible = false;
                }
                else
                {
                    bad.Visible = false;
                    pusa.Visible = false;
                    ruka.Visible = false;
                }

            }

            if (currentIndex == 16)
            {
                learn_score.Visible= true;
                learn_score.Text = "Your score is " + correct + " answers right and " + wrong + " answers wrong.";
                question.Visible = false;
                question.Text = "0" + " / " + "15";
                numero = 0;

                if (correct > wrong)
                {
                    learn_score.Text = learn_score.Text + "\nGood job!";
                    pusa.Visible = true;
                    ruka.Visible = true;
                    bad.Visible = false;

                    if (!(wrong == 0))
                    {
                        learn_score.Text = learn_score.Text + "\nAlthough I think you can still improve! :)";
                    }
                    else
                        learn_score.Text = learn_score.Text + "\nGood job!";
                }
                else
                {
                    learn_score.Text = learn_score.Text + "\nI think you should study more...";
                    pusa.Visible = false;
                    ruka.Visible = false;
                    bad.Visible = true;
                }
            }
            else
            {
                learn_score.Visible = false;
            }
            yourAnswer.Text = "";

        }

        private void yourAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void start_learning_Click(object sender, EventArgs e)
        {
            selected.Visible= true;
            yourAnswer.Visible= true;
            start_learning.Visible= false;
            learning_next.Visible= true;
            learn_text.Visible= false;
            learning_text.Visible = true;
            wrongL.Visible = true;
            correctL.Visible = true;
            ruka.Visible = false;
            pusa.Visible = false;
            bad.Visible = false;
            learn_score.Visible = false;
            question.Visible = true;



            // shuffle the order of words in the dictionary
            int n = dictionary.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                KeyValuePair<string, string> value = dictionary[k];
                dictionary[k] = dictionary[n];
                dictionary[n] = value;
            }

            // set the first word
            currentIndex = 0;
            selected.Text = dictionary[currentIndex].Key;
        }

        private void correctL_Click(object sender, EventArgs e)
        {

        }

        private void wrongL_Click(object sender, EventArgs e)
        {

        }

        private void question_Click(object sender, EventArgs e)
        {
            question.Text = numero + " / " + "15";
        }

        private void start_test_Click(object sender, EventArgs e)
        {
            test_text.Visible = false;
            start_test.Visible = false;
            test_next.Visible = true;
            trans.Visible = true;
            selected.Visible = true;
            testing_text.Visible = true;

            // shuffle the order of words in the dictionary
            int n = dictionary.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                KeyValuePair<string, string> value = dictionary[k];
                dictionary[k] = dictionary[n];
                dictionary[n] = value;
            }

            // set the first word
            currentIndex = 0;
            selected.Text = dictionary[currentIndex].Key;
            trans.Text = dictionary[currentIndex].Value;

        }

        private void test_next_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex == dictionary.Count - 1)
            {
                currentIndex= 0;
            }
            else
            {
                selected.Text = dictionary[currentIndex].Key;
                trans.Text = dictionary[currentIndex].Value;
            }
        }
    }
}