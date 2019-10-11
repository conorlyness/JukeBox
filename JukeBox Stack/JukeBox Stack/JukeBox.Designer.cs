namespace JukeBox_Stack
{
    partial class frmJukeBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtTracks = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblTracks = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnPeek = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSpindle1 = new System.Windows.Forms.GroupBox();
            this.gbAddCD = new System.Windows.Forms.GroupBox();
            this.gbRemoveCD = new System.Windows.Forms.GroupBox();
            this.btnRemoveCD = new System.Windows.Forms.Button();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.gbRequest = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.gbAddCD.SuspendLayout();
            this.gbRemoveCD.SuspendLayout();
            this.gbRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtName.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(37, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtArtist
            // 
            this.txtArtist.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtArtist.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtist.Location = new System.Drawing.Point(37, 81);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(202, 20);
            this.txtArtist.TabIndex = 1;
            // 
            // txtTracks
            // 
            this.txtTracks.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTracks.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTracks.Location = new System.Drawing.Point(37, 124);
            this.txtTracks.Name = "txtTracks";
            this.txtTracks.Size = new System.Drawing.Size(202, 20);
            this.txtTracks.TabIndex = 2;
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDuration.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(37, 173);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(202, 20);
            this.txtDuration.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(37, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "CD Name:";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblArtist.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.Location = new System.Drawing.Point(37, 65);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(95, 13);
            this.lblArtist.TabIndex = 5;
            this.lblArtist.Text = "CD Artist :";
            // 
            // lblTracks
            // 
            this.lblTracks.AutoSize = true;
            this.lblTracks.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTracks.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTracks.Location = new System.Drawing.Point(37, 108);
            this.lblTracks.Name = "lblTracks";
            this.lblTracks.Size = new System.Drawing.Size(119, 13);
            this.lblTracks.TabIndex = 6;
            this.lblTracks.Text = "Num of Tracks:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDuration.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(37, 157);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(103, 13);
            this.lblDuration.TabIndex = 7;
            this.lblDuration.Text = "CD Duration:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblOutput.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(848, 61);
            this.lblOutput.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(108, 16);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.Text = "spindle 1:";
            // 
            // btnPush
            // 
            this.btnPush.BackColor = System.Drawing.Color.White;
            this.btnPush.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPush.ForeColor = System.Drawing.Color.Black;
            this.btnPush.Location = new System.Drawing.Point(7, 243);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(133, 53);
            this.btnPush.TabIndex = 9;
            this.btnPush.Text = "Add CD";
            this.btnPush.UseVisualStyleBackColor = false;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.White;
            this.btnList.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.ForeColor = System.Drawing.Color.Black;
            this.btnList.Location = new System.Drawing.Point(149, 319);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(133, 53);
            this.btnList.TabIndex = 10;
            this.btnList.Text = "view spindle ";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnPop
            // 
            this.btnPop.BackColor = System.Drawing.Color.White;
            this.btnPop.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPop.ForeColor = System.Drawing.Color.Black;
            this.btnPop.Location = new System.Drawing.Point(149, 243);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(133, 53);
            this.btnPop.TabIndex = 11;
            this.btnPop.Text = "Remove CD";
            this.btnPop.UseVisualStyleBackColor = false;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnPeek
            // 
            this.btnPeek.BackColor = System.Drawing.Color.White;
            this.btnPeek.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeek.ForeColor = System.Drawing.Color.Black;
            this.btnPeek.Location = new System.Drawing.Point(7, 319);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(133, 53);
            this.btnPeek.TabIndex = 12;
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = false;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.White;
            this.btnFind.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.Black;
            this.btnFind.Location = new System.Drawing.Point(108, 75);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(133, 53);
            this.btnFind.TabIndex = 13;
            this.btnFind.Text = "Find and Play CD";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Magneto", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(388, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Welcome To The Jukebox";
            // 
            // gbSpindle1
            // 
            this.gbSpindle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbSpindle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSpindle1.Location = new System.Drawing.Point(306, 61);
            this.gbSpindle1.Name = "gbSpindle1";
            this.gbSpindle1.Size = new System.Drawing.Size(536, 237);
            this.gbSpindle1.TabIndex = 20;
            this.gbSpindle1.TabStop = false;
            this.gbSpindle1.Text = "Spindle 1:";
            // 
            // gbAddCD
            // 
            this.gbAddCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbAddCD.Controls.Add(this.lblName);
            this.gbAddCD.Controls.Add(this.txtName);
            this.gbAddCD.Controls.Add(this.btnList);
            this.gbAddCD.Controls.Add(this.lblArtist);
            this.gbAddCD.Controls.Add(this.txtArtist);
            this.gbAddCD.Controls.Add(this.lblTracks);
            this.gbAddCD.Controls.Add(this.txtTracks);
            this.gbAddCD.Controls.Add(this.btnPeek);
            this.gbAddCD.Controls.Add(this.lblDuration);
            this.gbAddCD.Controls.Add(this.txtDuration);
            this.gbAddCD.Controls.Add(this.btnPush);
            this.gbAddCD.Controls.Add(this.btnPop);
            this.gbAddCD.Location = new System.Drawing.Point(12, 61);
            this.gbAddCD.Name = "gbAddCD";
            this.gbAddCD.Size = new System.Drawing.Size(288, 378);
            this.gbAddCD.TabIndex = 21;
            this.gbAddCD.TabStop = false;
            this.gbAddCD.Text = "ADD CD";
            // 
            // gbRemoveCD
            // 
            this.gbRemoveCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbRemoveCD.Controls.Add(this.btnRemoveCD);
            this.gbRemoveCD.Controls.Add(this.txtRemove);
            this.gbRemoveCD.Location = new System.Drawing.Point(306, 304);
            this.gbRemoveCD.Name = "gbRemoveCD";
            this.gbRemoveCD.Size = new System.Drawing.Size(271, 135);
            this.gbRemoveCD.TabIndex = 22;
            this.gbRemoveCD.TabStop = false;
            this.gbRemoveCD.Text = "Remove Specific CD at position:";
            // 
            // btnRemoveCD
            // 
            this.btnRemoveCD.BackColor = System.Drawing.Color.White;
            this.btnRemoveCD.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCD.Location = new System.Drawing.Point(18, 59);
            this.btnRemoveCD.Name = "btnRemoveCD";
            this.btnRemoveCD.Size = new System.Drawing.Size(148, 43);
            this.btnRemoveCD.TabIndex = 1;
            this.btnRemoveCD.Text = "Remove";
            this.btnRemoveCD.UseVisualStyleBackColor = false;
            this.btnRemoveCD.Click += new System.EventHandler(this.btnRemoveCD_Click);
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(18, 33);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(204, 20);
            this.txtRemove.TabIndex = 0;
            // 
            // gbRequest
            // 
            this.gbRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbRequest.Controls.Add(this.label2);
            this.gbRequest.Controls.Add(this.txtRequest);
            this.gbRequest.Controls.Add(this.btnFind);
            this.gbRequest.Location = new System.Drawing.Point(585, 304);
            this.gbRequest.Name = "gbRequest";
            this.gbRequest.Size = new System.Drawing.Size(256, 134);
            this.gbRequest.TabIndex = 23;
            this.gbRequest.TabStop = false;
            this.gbRequest.Text = "Request CD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "CD Name:";
            // 
            // txtRequest
            // 
            this.txtRequest.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRequest.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequest.Location = new System.Drawing.Point(18, 38);
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Size = new System.Drawing.Size(202, 20);
            this.txtRequest.TabIndex = 14;
            // 
            // frmJukeBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1164, 452);
            this.Controls.Add(this.gbRequest);
            this.Controls.Add(this.gbRemoveCD);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.gbSpindle1);
            this.Controls.Add(this.gbAddCD);
            this.Controls.Add(this.label1);
            this.Name = "frmJukeBox";
            this.Text = "frmJukeBox";
            this.Load += new System.EventHandler(this.frmJukeBox_Load);
            this.gbAddCD.ResumeLayout(false);
            this.gbAddCD.PerformLayout();
            this.gbRemoveCD.ResumeLayout(false);
            this.gbRemoveCD.PerformLayout();
            this.gbRequest.ResumeLayout(false);
            this.gbRequest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtTracks;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblTracks;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSpindle1;
        private System.Windows.Forms.GroupBox gbAddCD;
        private System.Windows.Forms.GroupBox gbRemoveCD;
        private System.Windows.Forms.Button btnRemoveCD;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.GroupBox gbRequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRequest;
    }
}

