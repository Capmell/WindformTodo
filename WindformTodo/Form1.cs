using System.Linq;
using System.Net.Security;

namespace WindformTodo
{
    public partial class TodoApp : Form
    {
        private List<Todo> TaskList { get; set; }

       
        public TodoApp()
        {
            InitializeComponent();
            TaskList = new List<Todo>();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            ClearForm();
            MessageBox.Show("form cleared");
        }

        private void ClearForm()
        {
            txtTaskdescription.Clear();
            txtDuedate.Clear();
        }

        public void SubmitForm(object sender, EventArgs e)
        {
            if (Validators.IsEmpyText(txtTaskdescription))
            { 
                MessageBox.Show("desctription is empty please try again");
                return;
            } 
            if (Validators.IsEmpyText(txtDuedate))
            {
                MessageBox.Show("missing a correct due date format"); 
                return;
            }
            if (!Validators.IsValidData(txtDuedate))
            {
                MessageBox.Show("date is incorrectly formatted please try again");
            }

            Todo myTodo = new Todo(txtTaskdescription.Text, DateTime.Parse(txtDuedate.Text));

            TaskList.Add(myTodo);

            UpdateListBox();

            

           

            ClearForm();
        }

        public void UpdateListBox()
        {
            lbTasksLists.Items.Clear();

            var list = TaskList
            //.Where(t => t.IsDone == false)
            .OrderBy(t => t.DueDate)
            .ToList();

            for (int i = 0; i < list.Count; i++)
            {
                lbTasksLists.Items.Add(list[i].ToString());
            }
        }

        private void txtTaskdescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDuedate_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvTasklist_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show($"selected index is: {lbTasksLists.SelectedIndex}"); 

            int selectedIndex = lbTasksLists.SelectedIndex;
            string selectedItem = (string)lbTasksLists.SelectedItem; 

            if (selectedIndex == -1)
            {
                return;
            }

            if (selectedItem == null)
            {
                MessageBox.Show("no item selected at the index");
                return;
            }
            

            int id = Int32.Parse(selectedItem.Split(" - ")[0]);
            
            var todo = TaskList.Find(t => t.Id == id);

            if (todo != null)
            {
                todo.IsDone = !todo.IsDone;
                MessageBox.Show("task status changed");

                UpdateListBox();
            }
            
            

            
        }

        private void TodoApp_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnAdd_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTaskdescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SubmitForm(sender, e);
            }
        }

        private void txtDuedate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SubmitForm(sender, e);
            }
        }
    }
}
