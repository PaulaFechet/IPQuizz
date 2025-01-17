﻿/**************************************************************************
 *                                                                        *
 *  File:        FormMenu.cs                                              *
 *  Copyright:   (c) 2020, IP Project                                     *
 *  Authors:       Fechet Paula                                           *
 *                 Maftei Claudia                                         *
 *                 Radu Cosmina                                           *
 *                 Burbulea Ioana                                         *
 *                                                                        *
 *  Description: General Knowldege Quiz using Fabric Method Pattern       *
 *               it allows you to choose from the menu which consists of  *
 *               the name of the domains: Chemistry, Art, History, Arts   *
 *               Choose one to play.                                      *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/


using System;
using System.Windows.Forms;

namespace quizz
{
    // <summary>
    /// Form for choose the domain with questions
    /// </summary>
    public partial class FormMenu : Form
    {
       
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chemistryButton_Click(object sender, EventArgs e)
        {
            //determinarea tipului de quiz 
            try
            {
                FormStart chemistryQuizz = new FormStart("chimie");
                this.Hide();
                //inceperea jocului de cultura generala
                chemistryQuizz.Show();
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR at Chemistry Button Click in FormMenu");
            }
        }

        private void ITButton_Click(object sender, EventArgs e)
        {
            //determinarea tipului de quiz 
            try
            {
                FormStart ITQuizz = new FormStart("it");
                this.Hide();
                //inceperea jocului de cultura generala
                ITQuizz.Show();
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR at IT Button Click in FormMenu");
            }
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            //determinarea tipului de quiz 

            try
            {
                FormStart historyQuizz = new FormStart("istorie");
                this.Hide();
                //inceperea jocului de cultura generala
                historyQuizz.Show();
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR at History Button Click in FormMenu");
            }
        }

        private void artsButton_Click(object sender, EventArgs e)
        {
            //determinarea tipului de quiz 
            try
            {
                FormStart artsQuizz = new FormStart("arte");
                this.Hide();
                //inceperea jocului de cultura generala
                artsQuizz.Show();
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR at Arts Button Click in FormMenu");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:\\Users\\Ioana\\Desktop\\IPQuiz\\quizz\\quizz\\quiz_help\\Help.chm");
        }
    }
}
