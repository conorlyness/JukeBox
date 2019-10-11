using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JukeBox_Stack
{
    public partial class frmJukeBox : Form
    {
        public frmJukeBox()
        {
            InitializeComponent();
        }

        Spindle JBSP1 = new Spindle();
        Spindle JBSP2 = new Spindle();

        private void btnPush_Click(object sender, EventArgs e)
        {
            CDNode newCD = new CDNode();

                if (txtName.Text == "" || txtArtist.Text == "" || txtTracks.Text == "" || txtDuration.Text == "")
                {
                    lblOutput.Text = "All fields need to be filled before a new CD can be added";
                    return;
                }


                newCD.Name = txtName.Text;
                newCD.Artist = txtArtist.Text;


                if (JBSP1.push(newCD))
                {
                    lblOutput.Text = "CD was sucesfully added";
                }
                else
                {
                    lblOutput.Text = "CD could not be added, spindle is full";
                }

                try
                {
                    newCD.setTracks(Convert.ToInt32(txtTracks.Text));
                    newCD.setDuration(Convert.ToInt32(txtDuration.Text));

                }
                catch (FormatException fex)
                {
                    lblOutput.Text = "Error Occured, Tracks and Duration need to be a number!";
                    string err = "\n" + fex.Message + DateTime.Now.ToString();
                    File.AppendAllText(@"..\..\ErrorLog.txt", "\n" + err);
                }
            



        }

        private void btnList_Click(object sender, EventArgs e)
        { 
            gbSpindle1.Text = JBSP1.list();

        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            CDNode removeNode = JBSP1.pop();
            if (removeNode != null)
            {
                lblOutput.Text = " Removed " + removeNode.Name;
            }
            else
            {
                lblOutput.Text = "No CD's on Spindle to remove";
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            CDNode peekNode = JBSP1.peek();
            if (peekNode != null)
            {
                lblOutput.Text =  peekNode.Name  + " is at the top of the spindle";
            }
            else
            {
                lblOutput.Text = "Peek not possible, no CD's on the Spindle";
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (JBSP1.contains(txtRequest.Text))
            {
                lblOutput.Text = "Found CD, Now playing: " + txtRequest.Text;
            }
            else
            {
                lblOutput.Text = "CD not found";
            }
        }

        private void frmJukeBox_Load(object sender, EventArgs e)
        {

        }


        private void btnRemoveCD_Click(object sender, EventArgs e)
        {
            
            try
            {
                int toBeRemoved = (Convert.ToInt32(txtRemove.Text));
                for (int i = 0; i < toBeRemoved - 1; i++)
                {
                    CDNode nextSpindle = JBSP1.pop();
                    JBSP2.push(nextSpindle);
                   
                }

                JBSP1.pop();
                lblOutput.Text = "The CD at position:" + txtRemove.Text + " was Succesfully removed, view the spindle again to view the changes!";
            }
            catch(FormatException fx)
            {
                lblOutput.Text = "Error Occured, Enter a number which indicates the position of the CD you wish to remove";
                string err = "\n" + fx.Message + DateTime.Now.ToString();
                File.AppendAllText(@"..\..\ErrorLog.txt", "\n" + err);
            }
            
            
            catch (NullReferenceException nrx)
            {
                lblOutput.Text = "Error, enter a position which is possible to remove";
                string err = "\n" + nrx.Message + DateTime.Now.ToString();
                File.AppendAllText(@"..\..\ErrorLog.txt", "\n" + err);

            }


            while (JBSP2.peek() != null)
            {
                CDNode nextSpindle = JBSP2.pop();
                JBSP1.push(nextSpindle);
                
            }
           
        }
    }
}
