namespace WinForms_Controls___Pointers1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pointersLbl = new Label();
            imagePointerBtn = new Button();
            helpPointerBtn = new Button();
            customPointerBtn = new Button();
            defaultPointerBtn = new Button();
            handPointerBtn = new Button();
            changingMousePointerLbl = new Label();
            switchPointerPosition1 = new Button();
            switchPointerPosition2 = new Button();
            controllingPointerLbl = new Label();
            hidePointerBtn = new Button();
            pointerAccessLbl = new Label();
            SuspendLayout();
            // 
            // pointersLbl
            // 
            pointersLbl.AutoSize = true;
            pointersLbl.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pointersLbl.ForeColor = SystemColors.ControlText;
            pointersLbl.Location = new Point(473, 38);
            pointersLbl.Name = "pointersLbl";
            pointersLbl.Size = new Size(123, 30);
            pointersLbl.TabIndex = 36;
            pointersLbl.Text = "POINTERS";
            // 
            // imagePointerBtn
            // 
            imagePointerBtn.BackColor = SystemColors.Info;
            imagePointerBtn.FlatAppearance.BorderColor = Color.Black;
            imagePointerBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            imagePointerBtn.Location = new Point(761, 465);
            imagePointerBtn.Name = "imagePointerBtn";
            imagePointerBtn.Size = new Size(195, 74);
            imagePointerBtn.TabIndex = 35;
            imagePointerBtn.Text = "CHANGE TO IMAGE POINTER";
            imagePointerBtn.UseVisualStyleBackColor = false;
            imagePointerBtn.Click += imagePointerBtn_Click;
            // 
            // helpPointerBtn
            // 
            helpPointerBtn.BackColor = SystemColors.Info;
            helpPointerBtn.FlatAppearance.BorderColor = Color.Black;
            helpPointerBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            helpPointerBtn.Location = new Point(761, 305);
            helpPointerBtn.Name = "helpPointerBtn";
            helpPointerBtn.Size = new Size(195, 74);
            helpPointerBtn.TabIndex = 34;
            helpPointerBtn.Text = "CHANGE TO HELP POINTER";
            helpPointerBtn.UseVisualStyleBackColor = false;
            helpPointerBtn.Click += helpPointerBtn_Click_1;
            // 
            // customPointerBtn
            // 
            customPointerBtn.BackColor = SystemColors.Info;
            customPointerBtn.FlatAppearance.BorderColor = Color.Black;
            customPointerBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customPointerBtn.Location = new Point(761, 385);
            customPointerBtn.Name = "customPointerBtn";
            customPointerBtn.Size = new Size(195, 74);
            customPointerBtn.TabIndex = 33;
            customPointerBtn.Text = "CHANGE TO CUSTOM POINTER";
            customPointerBtn.UseVisualStyleBackColor = false;
            customPointerBtn.Click += customPointerBtn_Click_1;
            // 
            // defaultPointerBtn
            // 
            defaultPointerBtn.BackColor = SystemColors.Info;
            defaultPointerBtn.FlatAppearance.BorderColor = Color.Black;
            defaultPointerBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            defaultPointerBtn.Location = new Point(761, 159);
            defaultPointerBtn.Name = "defaultPointerBtn";
            defaultPointerBtn.Size = new Size(195, 60);
            defaultPointerBtn.TabIndex = 32;
            defaultPointerBtn.Text = "CHANGE TO DEFAULT";
            defaultPointerBtn.UseVisualStyleBackColor = false;
            defaultPointerBtn.Click += defaultPointerBtn_Click;
            // 
            // handPointerBtn
            // 
            handPointerBtn.BackColor = SystemColors.Info;
            handPointerBtn.FlatAppearance.BorderColor = Color.Black;
            handPointerBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            handPointerBtn.Location = new Point(761, 225);
            handPointerBtn.Name = "handPointerBtn";
            handPointerBtn.Size = new Size(195, 74);
            handPointerBtn.TabIndex = 31;
            handPointerBtn.Text = "CHANGE TO HAND POINTER";
            handPointerBtn.UseVisualStyleBackColor = false;
            handPointerBtn.Click += handPointerBtn_Click_1;
            // 
            // changingMousePointerLbl
            // 
            changingMousePointerLbl.AutoSize = true;
            changingMousePointerLbl.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            changingMousePointerLbl.Location = new Point(738, 105);
            changingMousePointerLbl.Name = "changingMousePointerLbl";
            changingMousePointerLbl.Size = new Size(238, 22);
            changingMousePointerLbl.TabIndex = 30;
            changingMousePointerLbl.Text = "CHANGING THE POINTER";
            // 
            // switchPointerPosition1
            // 
            switchPointerPosition1.BackColor = SystemColors.Info;
            switchPointerPosition1.FlatAppearance.BorderColor = Color.Black;
            switchPointerPosition1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            switchPointerPosition1.Location = new Point(433, 175);
            switchPointerPosition1.Name = "switchPointerPosition1";
            switchPointerPosition1.Size = new Size(195, 60);
            switchPointerPosition1.TabIndex = 29;
            switchPointerPosition1.Text = "SWITCH POINTER POSITION (1)";
            switchPointerPosition1.UseVisualStyleBackColor = false;
            switchPointerPosition1.Click += switchPointerPosition1_Click_1;
            // 
            // switchPointerPosition2
            // 
            switchPointerPosition2.BackColor = SystemColors.Info;
            switchPointerPosition2.FlatAppearance.BorderColor = Color.Black;
            switchPointerPosition2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            switchPointerPosition2.Location = new Point(433, 273);
            switchPointerPosition2.Name = "switchPointerPosition2";
            switchPointerPosition2.Size = new Size(195, 74);
            switchPointerPosition2.TabIndex = 28;
            switchPointerPosition2.Text = "SWITCH POINTER POSITION (2)\r\n";
            switchPointerPosition2.UseVisualStyleBackColor = false;
            switchPointerPosition2.Click += switchPointerPosition2_Click_1;
            // 
            // controllingPointerLbl
            // 
            controllingPointerLbl.AutoSize = true;
            controllingPointerLbl.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            controllingPointerLbl.Location = new Point(400, 105);
            controllingPointerLbl.Name = "controllingPointerLbl";
            controllingPointerLbl.Size = new Size(265, 22);
            controllingPointerLbl.TabIndex = 27;
            controllingPointerLbl.Text = "CONTROLLING THE POINTER";
            // 
            // hidePointerBtn
            // 
            hidePointerBtn.BackColor = SystemColors.Info;
            hidePointerBtn.FlatAppearance.BorderColor = Color.Black;
            hidePointerBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hidePointerBtn.Location = new Point(92, 175);
            hidePointerBtn.Name = "hidePointerBtn";
            hidePointerBtn.Size = new Size(219, 89);
            hidePointerBtn.TabIndex = 26;
            hidePointerBtn.Text = "HIDE POINTER";
            hidePointerBtn.UseVisualStyleBackColor = false;
            hidePointerBtn.MouseEnter += hidePointerBtn_MouseEnter;
            hidePointerBtn.MouseLeave += hidePointerBtn_MouseLeave;
            // 
            // pointerAccessLbl
            // 
            pointerAccessLbl.AutoSize = true;
            pointerAccessLbl.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pointerAccessLbl.Location = new Point(115, 105);
            pointerAccessLbl.Name = "pointerAccessLbl";
            pointerAccessLbl.Size = new Size(165, 22);
            pointerAccessLbl.TabIndex = 25;
            pointerAccessLbl.Text = "POINTER ACCESS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 577);
            Controls.Add(pointersLbl);
            Controls.Add(imagePointerBtn);
            Controls.Add(helpPointerBtn);
            Controls.Add(customPointerBtn);
            Controls.Add(defaultPointerBtn);
            Controls.Add(handPointerBtn);
            Controls.Add(changingMousePointerLbl);
            Controls.Add(switchPointerPosition1);
            Controls.Add(switchPointerPosition2);
            Controls.Add(controllingPointerLbl);
            Controls.Add(hidePointerBtn);
            Controls.Add(pointerAccessLbl);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinForms Controls - Pointers";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pointersLbl;
        private Button imagePointerBtn;
        private Button helpPointerBtn;
        private Button customPointerBtn;
        private Button defaultPointerBtn;
        private Button handPointerBtn;
        private Label changingMousePointerLbl;
        private Button switchPointerPosition1;
        private Button switchPointerPosition2;
        private Label controllingPointerLbl;
        private Button hidePointerBtn;
        private Label pointerAccessLbl;
    }
}
