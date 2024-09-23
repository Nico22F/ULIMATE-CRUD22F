namespace ULIMATE_CRUD22F
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
            CREATE = new Button();
            READ = new Button();
            UPDATE = new Button();
            DELETE = new Button();
            LISTBOX = new ListBox();
            label1 = new Label();
            label2 = new Label();
            textbox_name = new TextBox();
            textbox_cognome = new TextBox();
            update_label = new Label();
            textboxudateCOGNOME = new TextBox();
            labelcognomeupdate = new Label();
            textBoxupdateNOME = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // CREATE
            // 
            CREATE.Location = new Point(12, 12);
            CREATE.Name = "CREATE";
            CREATE.Size = new Size(213, 102);
            CREATE.TabIndex = 0;
            CREATE.Text = "CREATE";
            CREATE.UseVisualStyleBackColor = true;
            CREATE.Click += CREATE_Click;
            // 
            // READ
            // 
            READ.Location = new Point(12, 120);
            READ.Name = "READ";
            READ.Size = new Size(213, 102);
            READ.TabIndex = 1;
            READ.Text = "READ";
            READ.UseVisualStyleBackColor = true;
            READ.Click += READ_Click;
            // 
            // UPDATE
            // 
            UPDATE.Location = new Point(12, 228);
            UPDATE.Name = "UPDATE";
            UPDATE.Size = new Size(213, 102);
            UPDATE.TabIndex = 2;
            UPDATE.Text = "UPDATE";
            UPDATE.UseVisualStyleBackColor = true;
            UPDATE.Click += UPDATE_Click;
            // 
            // DELETE
            // 
            DELETE.Location = new Point(12, 336);
            DELETE.Name = "DELETE";
            DELETE.Size = new Size(213, 102);
            DELETE.TabIndex = 3;
            DELETE.Text = "DELETE";
            DELETE.UseVisualStyleBackColor = true;
            DELETE.Click += DELETE_Click;
            // 
            // LISTBOX
            // 
            LISTBOX.FormattingEnabled = true;
            LISTBOX.ItemHeight = 15;
            LISTBOX.Location = new Point(411, 14);
            LISTBOX.Name = "LISTBOX";
            LISTBOX.Size = new Size(377, 424);
            LISTBOX.TabIndex = 4;
            LISTBOX.SelectedIndexChanged += LISTBOX_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 25);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 303);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 6;
            label2.Text = "Cognome";
            // 
            // textbox_name
            // 
            textbox_name.Location = new Point(246, 43);
            textbox_name.Name = "textbox_name";
            textbox_name.Size = new Size(130, 23);
            textbox_name.TabIndex = 7;
            // 
            // textbox_cognome
            // 
            textbox_cognome.Location = new Point(243, 336);
            textbox_cognome.Name = "textbox_cognome";
            textbox_cognome.Size = new Size(130, 23);
            textbox_cognome.TabIndex = 8;
            // 
            // update_label
            // 
            update_label.AutoSize = true;
            update_label.Location = new Point(180, 210);
            update_label.Name = "update_label";
            update_label.Size = new Size(274, 15);
            update_label.TabIndex = 9;
            update_label.Text = "INSERISCI IL NOME  E COGNOME DA MODIFICARE";
            // 
            // textboxudateCOGNOME
            // 
            textboxudateCOGNOME.Location = new Point(243, 400);
            textboxudateCOGNOME.Name = "textboxudateCOGNOME";
            textboxudateCOGNOME.Size = new Size(130, 23);
            textboxudateCOGNOME.TabIndex = 10;
            // 
            // labelcognomeupdate
            // 
            labelcognomeupdate.AutoSize = true;
            labelcognomeupdate.Location = new Point(243, 382);
            labelcognomeupdate.Name = "labelcognomeupdate";
            labelcognomeupdate.Size = new Size(136, 15);
            labelcognomeupdate.TabIndex = 11;
            labelcognomeupdate.Text = "Cognome da modficare ";
            // 
            // textBoxupdateNOME
            // 
            textBoxupdateNOME.Location = new Point(243, 111);
            textBoxupdateNOME.Name = "textBoxupdateNOME";
            textBoxupdateNOME.Size = new Size(130, 23);
            textBoxupdateNOME.TabIndex = 12;
            textBoxupdateNOME.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 82);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 13;
            label3.Text = "Nome da modificare";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBoxupdateNOME);
            Controls.Add(labelcognomeupdate);
            Controls.Add(textboxudateCOGNOME);
            Controls.Add(update_label);
            Controls.Add(textbox_cognome);
            Controls.Add(textbox_name);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LISTBOX);
            Controls.Add(DELETE);
            Controls.Add(UPDATE);
            Controls.Add(READ);
            Controls.Add(CREATE);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CREATE;
        private Button READ;
        private Button UPDATE;
        private Button DELETE;
        private ListBox LISTBOX;
        private Label label1;
        private Label label2;
        private TextBox textbox_name;
        private TextBox textbox_cognome;
        private Label update_label;
        private TextBox textboxudateCOGNOME;
        private Label labelcognomeupdate;
        private TextBox textBoxupdateNOME;
        private Label label3;
    }
}