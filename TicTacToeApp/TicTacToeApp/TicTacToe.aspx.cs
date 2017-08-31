using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicTacToeApp
{
    public partial class TicTacToe : System.Web.UI.Page
    {
        static int turn = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void Button_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            if (button.Text == "Option")
            {
                if (turn % 2 != 0)
                {
                    button.Text = "X";
                    if (Winning_Condition() == true)
                    {
                        Label1.Text = "player X has won";
                        return;
                    }

                }
                else
                {
                    button.Text = "O";
                    if (Winning_Condition() == true)
                    {
                        Label1.Text = "player O has won";
                        return;
                    }
                }
                turn++;

                if(turn==10)
                {
                    Label1.Text = "Draw";
                }
            }

        }


        protected bool Winning_Condition()
        {
            if (Button1.Text == Button2.Text && Button2.Text == Button3.Text && Button1.Text != "Option")
            {
                return true;
            }
            if (Button1.Text == Button5.Text && Button5.Text == Button9.Text && Button1.Text != "Option")
            {
                return true;
            }
            if (Button1.Text == Button4.Text && Button4.Text == Button7.Text && Button1.Text != "Option")
            {
                return true;
            }
            if (Button2.Text == Button5.Text && Button5.Text == Button8.Text && Button2.Text != "Option")
            {
                return true;
            }
            if (Button3.Text == Button6.Text && Button6.Text == Button9.Text && Button3.Text != "Option")
            {
                return true;
            }
            if (Button3.Text == Button5.Text && Button5.Text == Button7.Text && Button3.Text != "Option")
            {
                return true;
            }
            if (Button4.Text == Button5.Text && Button5.Text == Button6.Text && Button4.Text != "Option")
            {
                return true;
            }
            if (Button7.Text == Button8.Text && Button8.Text == Button9.Text && Button7.Text != "Option")
            {
                return true;
            }
            else
                return false;

        }
        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("TicTacToe.aspx");
        }
    }
}