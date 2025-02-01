namespace WindformTodo
{
    partial class TodoApp
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
            gbTasks = new GroupBox();
            gbDuedate = new GroupBox();
            btnClear = new Button();
            btnAdd = new Button();
            lblDuedate = new Label();
            txtDuedate = new TextBox();
            lblTaskboxlabel = new Label();
            txtTaskdescription = new TextBox();
            gbTasklist = new GroupBox();
            lbTasksLists = new ListBox();
            gbTasks.SuspendLayout();
            gbDuedate.SuspendLayout();
            gbTasklist.SuspendLayout();
            SuspendLayout();
            // 
            // gbTasks
            // 
            gbTasks.Controls.Add(gbDuedate);
            gbTasks.Controls.Add(lblTaskboxlabel);
            gbTasks.Controls.Add(txtTaskdescription);
            gbTasks.Location = new Point(0, -1);
            gbTasks.Name = "gbTasks";
            gbTasks.Size = new Size(299, 100);
            gbTasks.TabIndex = 0;
            gbTasks.TabStop = false;
            gbTasks.Text = "Task form";
            gbTasks.Enter += groupBox1_Enter;
            // 
            // gbDuedate
            // 
            gbDuedate.Controls.Add(btnClear);
            gbDuedate.Controls.Add(btnAdd);
            gbDuedate.Controls.Add(lblDuedate);
            gbDuedate.Controls.Add(txtDuedate);
            gbDuedate.Location = new Point(0, 34);
            gbDuedate.Name = "gbDuedate";
            gbDuedate.Size = new Size(299, 60);
            gbDuedate.TabIndex = 4;
            gbDuedate.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(126, 37);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 2;
            btnClear.Text = "clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(207, 37);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add todo";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += SubmitForm;
            // 
            // lblDuedate
            // 
            lblDuedate.AutoSize = true;
            lblDuedate.Location = new Point(12, 19);
            lblDuedate.Name = "lblDuedate";
            lblDuedate.Size = new Size(54, 15);
            lblDuedate.TabIndex = 1;
            lblDuedate.Text = "Due date";
            // 
            // txtDuedate
            // 
            txtDuedate.Location = new Point(72, 11);
            txtDuedate.Name = "txtDuedate";
            txtDuedate.Size = new Size(221, 23);
            txtDuedate.TabIndex = 0;
            txtDuedate.Text = "2025-2-25";
            txtDuedate.TextChanged += txtDuedate_TextChanged;
            txtDuedate.KeyPress += txtDuedate_KeyPress;
            // 
            // lblTaskboxlabel
            // 
            lblTaskboxlabel.AutoSize = true;
            lblTaskboxlabel.Location = new Point(12, 19);
            lblTaskboxlabel.Name = "lblTaskboxlabel";
            lblTaskboxlabel.Size = new Size(28, 15);
            lblTaskboxlabel.TabIndex = 1;
            lblTaskboxlabel.Text = "task";
            // 
            // txtTaskdescription
            // 
            txtTaskdescription.Location = new Point(72, 11);
            txtTaskdescription.Name = "txtTaskdescription";
            txtTaskdescription.Size = new Size(221, 23);
            txtTaskdescription.TabIndex = 0;
            txtTaskdescription.TextChanged += txtTaskdescription_TextChanged;
            txtTaskdescription.KeyPress += txtTaskdescription_KeyPress;
            // 
            // gbTasklist
            // 
            gbTasklist.Controls.Add(lbTasksLists);
            gbTasklist.Location = new Point(12, 99);
            gbTasklist.Name = "gbTasklist";
            gbTasklist.Size = new Size(320, 311);
            gbTasklist.TabIndex = 2;
            gbTasklist.TabStop = false;
            gbTasklist.Text = "task list";
            // 
            // lbTasksLists
            // 
            lbTasksLists.FormattingEnabled = true;
            lbTasksLists.ItemHeight = 15;
            lbTasksLists.Location = new Point(0, 22);
            lbTasksLists.Name = "lbTasksLists";
            lbTasksLists.Size = new Size(320, 304);
            lbTasksLists.TabIndex = 0;
            lbTasksLists.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // TodoApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 422);
            Controls.Add(gbTasklist);
            Controls.Add(gbTasks);
            Name = "TodoApp";
            Text = "TodoApp";
            Load += Form1_Load;
            KeyPress += TodoApp_KeyPress;
            gbTasks.ResumeLayout(false);
            gbTasks.PerformLayout();
            gbDuedate.ResumeLayout(false);
            gbDuedate.PerformLayout();
            gbTasklist.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbTasks;
        private Label lblTaskboxlabel;
        private TextBox txtTaskdescription;
        private GroupBox gbDuedate;
        private Button btnAdd;
        private Label lblDuedate;
        private TextBox txtDuedate;
        private Button btnClear;
        private GroupBox gbTasklist;
        private ListBox lbTasksLists;
    }
}
