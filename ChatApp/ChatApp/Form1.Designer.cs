namespace ChatApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Client1groupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LocalPortTextBox = new System.Windows.Forms.TextBox();
            this.LocalIpTextBox = new System.Windows.Forms.TextBox();
            this.Client2groupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FriendsPortTextBox = new System.Windows.Forms.TextBox();
            this.FriendsIpTextBox = new System.Windows.Forms.TextBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.ListMessage = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Client1groupBox.SuspendLayout();
            this.Client2groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Client1groupBox
            // 
            this.Client1groupBox.Controls.Add(this.label1);
            this.Client1groupBox.Controls.Add(this.label2);
            this.Client1groupBox.Controls.Add(this.LocalPortTextBox);
            this.Client1groupBox.Controls.Add(this.LocalIpTextBox);
            this.Client1groupBox.Location = new System.Drawing.Point(21, 39);
            this.Client1groupBox.Name = "Client1groupBox";
            this.Client1groupBox.Size = new System.Drawing.Size(230, 125);
            this.Client1groupBox.TabIndex = 0;
            this.Client1groupBox.TabStop = false;
            this.Client1groupBox.Text = "Client1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PORT";
            // 
            // LocalPortTextBox
            // 
            this.LocalPortTextBox.Location = new System.Drawing.Point(95, 82);
            this.LocalPortTextBox.Name = "LocalPortTextBox";
            this.LocalPortTextBox.Size = new System.Drawing.Size(117, 20);
            this.LocalPortTextBox.TabIndex = 1;
            // 
            // LocalIpTextBox
            // 
            this.LocalIpTextBox.Location = new System.Drawing.Point(95, 32);
            this.LocalIpTextBox.Name = "LocalIpTextBox";
            this.LocalIpTextBox.Size = new System.Drawing.Size(117, 20);
            this.LocalIpTextBox.TabIndex = 0;
            // 
            // Client2groupBox
            // 
            this.Client2groupBox.Controls.Add(this.label4);
            this.Client2groupBox.Controls.Add(this.label3);
            this.Client2groupBox.Controls.Add(this.FriendsPortTextBox);
            this.Client2groupBox.Controls.Add(this.FriendsIpTextBox);
            this.Client2groupBox.Location = new System.Drawing.Point(271, 39);
            this.Client2groupBox.Name = "Client2groupBox";
            this.Client2groupBox.Size = new System.Drawing.Size(223, 125);
            this.Client2groupBox.TabIndex = 1;
            this.Client2groupBox.TabStop = false;
            this.Client2groupBox.Text = "Client2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "IP";
            // 
            // FriendsPortTextBox
            // 
            this.FriendsPortTextBox.Location = new System.Drawing.Point(87, 82);
            this.FriendsPortTextBox.Name = "FriendsPortTextBox";
            this.FriendsPortTextBox.Size = new System.Drawing.Size(117, 20);
            this.FriendsPortTextBox.TabIndex = 2;
            // 
            // FriendsIpTextBox
            // 
            this.FriendsIpTextBox.Location = new System.Drawing.Point(87, 32);
            this.FriendsIpTextBox.Name = "FriendsIpTextBox";
            this.FriendsIpTextBox.Size = new System.Drawing.Size(117, 20);
            this.FriendsIpTextBox.TabIndex = 1;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(21, 393);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(365, 20);
            this.MessageTextBox.TabIndex = 2;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(419, 186);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(419, 391);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ListMessage
            // 
            this.ListMessage.FormattingEnabled = true;
            this.ListMessage.Location = new System.Drawing.Point(21, 221);
            this.ListMessage.Name = "ListMessage";
            this.ListMessage.Size = new System.Drawing.Size(472, 134);
            this.ListMessage.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.ListMessage);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.Client2groupBox);
            this.Controls.Add(this.Client1groupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Client1groupBox.ResumeLayout(false);
            this.Client1groupBox.PerformLayout();
            this.Client2groupBox.ResumeLayout(false);
            this.Client2groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Client1groupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LocalPortTextBox;
        private System.Windows.Forms.TextBox LocalIpTextBox;
        private System.Windows.Forms.GroupBox Client2groupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FriendsPortTextBox;
        private System.Windows.Forms.TextBox FriendsIpTextBox;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.ListBox ListMessage;
        private System.Windows.Forms.Label label1;
    }
}

