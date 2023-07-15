namespace GtaosSql
{
    partial class NewForm
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
            label_name = new Label();
            textBox_name = new TextBox();
            textBox_server = new TextBox();
            label_server = new Label();
            textBox_port = new TextBox();
            label_port = new Label();
            textBox_user = new TextBox();
            label_user = new Label();
            textBox_password = new TextBox();
            label_password = new Label();
            button_new = new Button();
            SuspendLayout();
            // 
            // label_name
            // 
            label_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_name.AutoSize = true;
            label_name.Location = new Point(12, 9);
            label_name.Name = "label_name";
            label_name.Size = new Size(40, 17);
            label_name.TabIndex = 0;
            label_name.Text = "name";
            // 
            // textBox_name
            // 
            textBox_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_name.Location = new Point(12, 29);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(149, 23);
            textBox_name.TabIndex = 1;
            // 
            // textBox_server
            // 
            textBox_server.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_server.Location = new Point(12, 75);
            textBox_server.Name = "textBox_server";
            textBox_server.Size = new Size(149, 23);
            textBox_server.TabIndex = 3;
            // 
            // label_server
            // 
            label_server.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_server.AutoSize = true;
            label_server.Location = new Point(12, 55);
            label_server.Name = "label_server";
            label_server.Size = new Size(44, 17);
            label_server.TabIndex = 2;
            label_server.Text = "server";
            // 
            // textBox_port
            // 
            textBox_port.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_port.Location = new Point(12, 121);
            textBox_port.Name = "textBox_port";
            textBox_port.Size = new Size(149, 23);
            textBox_port.TabIndex = 5;
            // 
            // label_port
            // 
            label_port.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_port.AutoSize = true;
            label_port.Location = new Point(12, 101);
            label_port.Name = "label_port";
            label_port.Size = new Size(33, 17);
            label_port.TabIndex = 4;
            label_port.Text = "port";
            // 
            // textBox_user
            // 
            textBox_user.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_user.Location = new Point(12, 167);
            textBox_user.Name = "textBox_user";
            textBox_user.Size = new Size(149, 23);
            textBox_user.TabIndex = 7;
            // 
            // label_user
            // 
            label_user.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_user.AutoSize = true;
            label_user.Location = new Point(12, 147);
            label_user.Name = "label_user";
            label_user.Size = new Size(33, 17);
            label_user.TabIndex = 6;
            label_user.Text = "user";
            // 
            // textBox_password
            // 
            textBox_password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_password.Location = new Point(12, 213);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(149, 23);
            textBox_password.TabIndex = 9;
            // 
            // label_password
            // 
            label_password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_password.AutoSize = true;
            label_password.Location = new Point(12, 193);
            label_password.Name = "label_password";
            label_password.Size = new Size(65, 17);
            label_password.TabIndex = 8;
            label_password.Text = "password";
            // 
            // button_new
            // 
            button_new.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_new.Location = new Point(138, 265);
            button_new.Name = "button_new";
            button_new.Size = new Size(134, 34);
            button_new.TabIndex = 10;
            button_new.Text = "new";
            button_new.UseVisualStyleBackColor = true;
            button_new.Click += Button_new_Click;
            // 
            // NewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 311);
            Controls.Add(button_new);
            Controls.Add(textBox_password);
            Controls.Add(label_password);
            Controls.Add(textBox_user);
            Controls.Add(label_user);
            Controls.Add(textBox_port);
            Controls.Add(label_port);
            Controls.Add(textBox_server);
            Controls.Add(label_server);
            Controls.Add(textBox_name);
            Controls.Add(label_name);
            Name = "NewForm";
            Text = "New";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_name;
        private TextBox textBox_name;
        private TextBox textBox_server;
        private Label label_server;
        private TextBox textBox_port;
        private Label label_port;
        private TextBox textBox_user;
        private Label label_user;
        private TextBox textBox_password;
        private Label label_password;
        private Button button_new;
    }
}