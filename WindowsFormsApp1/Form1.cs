using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		private GuessNumber game;
		public Form1()
		{
			InitializeComponent();
			game = new GuessNumber();
			game.NewGame();
		}

		private void CalcButton_Click(object sender, EventArgs e)
		{
			string input = InputTextBox.Text;
			int[] inputArray = new int[4];
			var game = new GuessNumber();
			for (int i = 0; i < 4; i++)
			{
				inputArray[i] =Convert.ToInt32( input.Substring(i, 1));
			}
			string oldHint = ResultTextBox.Text;
			string Hint =$"{oldHint} \r\n{game.Guess(inputArray)}";
			ResultTextBox.Text = Hint;

		}

		private void NewGameButton_Click(object sender, EventArgs e)
		{
			game.NewGame();
		}
	}

	public class GuessNumber
	{
		private int[] answer { get ; set; }
		public void NewGame()
		{
			int seed = Guid.NewGuid().GetHashCode();
			int[] answerb = new int[4];
			for (int i = 0; i < 4; i++)
			{
				var random = new Random(seed);
				answerb[i] = random.Next(0, 10);

				for (int k = 0; k < i; k++)
				{
					while (answerb[i] == answer[k])
					{
						k = 0;
						answerb[i] = random.Next(0, 10);
					}
				}
			}
			answer = answerb;
			
		}
		public string Guess(int[]inputArray)
		{
			int aNumber = 0;
			int bNumber = 0;
			 for (int i = 0; i < 4; i++)
			{
				for (int k = 0; k < 4; k++)
				{
					if (inputArray[i] == this.answer[k]&&i==k)
						aNumber++;
					else if(inputArray[i] == this.answer[k]&&i!=k)
						bNumber++;
				}
			}
			string result = $"{aNumber}A{bNumber}B {answer[0]}{answer[1]}{answer[2]}{answer[3]}";
			return result;
		}
	}
}
