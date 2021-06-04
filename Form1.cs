using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Atbash
{
    public partial class Form1 : Form
    {
        FileStream file = new FileStream("message.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        char[] chars = new char[]{' ','!','"','#','$','%','&','\'','(',')','*','+',',','-','.','/','0',
            '1','2','3','4','5','6','7','8','9',':',';','<','=','>','?','@','A','Ą','B','C','Ć','D','E',
            'Ę','F','G','H','I','J','K','L','Ł','M','N','Ń','O','Ó','P','Q','R','S','Ś','T','U','V','W',
            'X','Y','Z','Ź','Ż','[','/',']','^','_','`','a','ą','b','c','ć','d','e','ę','f','g','h','i',
            'j','k','l','ł','m','n','ń','o','ó','p','q','r','s','ś','t','u','v','w','x','y','z','ź','ż',
            '{','|','}','~'}; //ASCII code combined with Polish diacritized letters

        string message = "";
        char[] messagechar;
        char[] codetable;
        public Form1()
        {
            InitializeComponent();
            //creating a code table
            int k =-1;
            codetable = new char[chars.Length];
            for (int i = codetable.Length-1; i >= 0; i--)
            {
                k++;
                codetable[k] = chars[i];
            }
        }

        //select a message input method
        private void Selectsource(object sender, EventArgs e)
        {
            if (rBText.Checked == true) tBText.Enabled = true;
            else if (rBFile.Checked == true) tBText.Enabled = false;
        }

        private void Btngo_Click(object sender, EventArgs e)
        {
            //loading the message from the text field and saving it to a file
            if (rBText.Checked == true)
            {
                message = tBText.Text;
                StreamWriter sw = new StreamWriter(file);
                sw.WriteLine(message);
                sw.Close();
            }
            //loading a message from a file and saving it to the text field
            else if (rBFile.Checked == true)
            {
                StreamReader sr = new StreamReader(file);
                message = sr.ReadLine();
                sr.Close();
                tBText.Text = message;
            }

            //message encryption or decryption
            messagechar = message.ToCharArray();
            for(int i = 0; i < messagechar.Length; i++)
            {
                //encrypting or decrypting messages works the same
                for (int j = 0; j < chars.Length;j++) 
                    if (messagechar[i] == chars[j]) tBMessage.Text += codetable[j];
            }
            //protection against the next operation
            tBText.Enabled = false;
            btnoperation.Enabled = false;
            gBSource.Enabled = false;
        }
    }
}
