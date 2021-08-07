
namespace TicTacToe
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.field1 = new System.Windows.Forms.Button();
            this.field2 = new System.Windows.Forms.Button();
            this.field3 = new System.Windows.Forms.Button();
            this.field6 = new System.Windows.Forms.Button();
            this.field5 = new System.Windows.Forms.Button();
            this.field4 = new System.Windows.Forms.Button();
            this.field9 = new System.Windows.Forms.Button();
            this.field8 = new System.Windows.Forms.Button();
            this.field7 = new System.Windows.Forms.Button();
            this.playerLabel1 = new System.Windows.Forms.Label();
            this.playerLabel2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // field1
            // 
            this.field1.BackColor = System.Drawing.Color.White;
            this.field1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field1.Location = new System.Drawing.Point(134, 108);
            this.field1.Margin = new System.Windows.Forms.Padding(2);
            this.field1.Name = "field1";
            this.field1.Size = new System.Drawing.Size(45, 49);
            this.field1.TabIndex = 0;
            this.field1.UseVisualStyleBackColor = false;
            this.field1.Click += new System.EventHandler(this.Field1_Click);
            // 
            // field2
            // 
            this.field2.BackColor = System.Drawing.Color.White;
            this.field2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field2.Location = new System.Drawing.Point(183, 108);
            this.field2.Margin = new System.Windows.Forms.Padding(2);
            this.field2.Name = "field2";
            this.field2.Size = new System.Drawing.Size(45, 49);
            this.field2.TabIndex = 1;
            this.field2.UseVisualStyleBackColor = false;
            this.field2.Click += new System.EventHandler(this.Field2_Click);
            // 
            // field3
            // 
            this.field3.BackColor = System.Drawing.Color.White;
            this.field3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field3.Location = new System.Drawing.Point(233, 108);
            this.field3.Margin = new System.Windows.Forms.Padding(2);
            this.field3.Name = "field3";
            this.field3.Size = new System.Drawing.Size(45, 49);
            this.field3.TabIndex = 2;
            this.field3.UseVisualStyleBackColor = false;
            this.field3.Click += new System.EventHandler(this.Field3_Click);
            // 
            // field6
            // 
            this.field6.BackColor = System.Drawing.Color.White;
            this.field6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field6.Location = new System.Drawing.Point(233, 162);
            this.field6.Margin = new System.Windows.Forms.Padding(2);
            this.field6.Name = "field6";
            this.field6.Size = new System.Drawing.Size(45, 49);
            this.field6.TabIndex = 5;
            this.field6.UseVisualStyleBackColor = false;
            this.field6.Click += new System.EventHandler(this.Field6_Click);
            // 
            // field5
            // 
            this.field5.BackColor = System.Drawing.Color.White;
            this.field5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field5.Location = new System.Drawing.Point(183, 162);
            this.field5.Margin = new System.Windows.Forms.Padding(2);
            this.field5.Name = "field5";
            this.field5.Size = new System.Drawing.Size(45, 49);
            this.field5.TabIndex = 4;
            this.field5.UseVisualStyleBackColor = false;
            this.field5.Click += new System.EventHandler(this.Field5_Click);
            // 
            // field4
            // 
            this.field4.BackColor = System.Drawing.Color.White;
            this.field4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field4.Location = new System.Drawing.Point(134, 162);
            this.field4.Margin = new System.Windows.Forms.Padding(2);
            this.field4.Name = "field4";
            this.field4.Size = new System.Drawing.Size(45, 49);
            this.field4.TabIndex = 3;
            this.field4.UseVisualStyleBackColor = false;
            this.field4.Click += new System.EventHandler(this.Field4_Click);
            // 
            // field9
            // 
            this.field9.BackColor = System.Drawing.Color.White;
            this.field9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field9.Location = new System.Drawing.Point(233, 215);
            this.field9.Margin = new System.Windows.Forms.Padding(2);
            this.field9.Name = "field9";
            this.field9.Size = new System.Drawing.Size(45, 49);
            this.field9.TabIndex = 8;
            this.field9.UseVisualStyleBackColor = false;
            this.field9.Click += new System.EventHandler(this.Field9_Click);
            // 
            // field8
            // 
            this.field8.BackColor = System.Drawing.Color.White;
            this.field8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field8.Location = new System.Drawing.Point(183, 215);
            this.field8.Margin = new System.Windows.Forms.Padding(2);
            this.field8.Name = "field8";
            this.field8.Size = new System.Drawing.Size(45, 49);
            this.field8.TabIndex = 7;
            this.field8.UseVisualStyleBackColor = false;
            this.field8.Click += new System.EventHandler(this.Field8_Click);
            // 
            // field7
            // 
            this.field7.BackColor = System.Drawing.Color.White;
            this.field7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field7.Location = new System.Drawing.Point(134, 215);
            this.field7.Margin = new System.Windows.Forms.Padding(2);
            this.field7.Name = "field7";
            this.field7.Size = new System.Drawing.Size(45, 49);
            this.field7.TabIndex = 6;
            this.field7.UseVisualStyleBackColor = false;
            this.field7.Click += new System.EventHandler(this.Field7_Click);
            // 
            // playerLabel1
            // 
            this.playerLabel1.AutoSize = true;
            this.playerLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerLabel1.ForeColor = System.Drawing.Color.Blue;
            this.playerLabel1.Location = new System.Drawing.Point(9, 7);
            this.playerLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerLabel1.Name = "playerLabel1";
            this.playerLabel1.Size = new System.Drawing.Size(77, 24);
            this.playerLabel1.TabIndex = 9;
            this.playerLabel1.Text = "Player 1";
            // 
            // playerLabel2
            // 
            this.playerLabel2.AutoSize = true;
            this.playerLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerLabel2.ForeColor = System.Drawing.Color.Red;
            this.playerLabel2.Location = new System.Drawing.Point(331, 7);
            this.playerLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerLabel2.Name = "playerLabel2";
            this.playerLabel2.Size = new System.Drawing.Size(77, 24);
            this.playerLabel2.TabIndex = 10;
            this.playerLabel2.Text = "Player 2";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Aquamarine;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(156, 308);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(102, 32);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(12, 378);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 15);
            this.errorLabel.TabIndex = 12;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.winLabel.Location = new System.Drawing.Point(141, 70);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(0, 20);
            this.winLabel.TabIndex = 13;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score.Location = new System.Drawing.Point(182, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(45, 24);
            this.score.TabIndex = 14;
            this.score.Text = "0 : 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(414, 402);
            this.Controls.Add(this.score);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.playerLabel2);
            this.Controls.Add(this.playerLabel1);
            this.Controls.Add(this.field9);
            this.Controls.Add(this.field8);
            this.Controls.Add(this.field7);
            this.Controls.Add(this.field6);
            this.Controls.Add(this.field5);
            this.Controls.Add(this.field4);
            this.Controls.Add(this.field3);
            this.Controls.Add(this.field2);
            this.Controls.Add(this.field1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button field1;
        private System.Windows.Forms.Button field2;
        private System.Windows.Forms.Button field3;
        private System.Windows.Forms.Button field6;
        private System.Windows.Forms.Button field5;
        private System.Windows.Forms.Button field4;
        private System.Windows.Forms.Button field9;
        private System.Windows.Forms.Button field8;
        private System.Windows.Forms.Button field7;
        private System.Windows.Forms.Label playerLabel1;
        private System.Windows.Forms.Label playerLabel2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label score;
    }
}

