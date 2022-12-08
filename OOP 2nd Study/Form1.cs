using OOP_2nd_Study.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_2nd_Study
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee[] employees = new Employee[0];
        public void Add(Employee e)
        {
            listBox1.Items.Add(e.ReflectInfo());
        }
        public Employee Add(string name,string lastName)
        {
            Employee e = new Employee();
            e.Name = name;
            e.LastName = lastName;
            return e;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add(new Employee
            {
                Name=textBox1.Text,
                LastName=textBox2.Text
            });
         
        }
        private void btAddToArray_Click(object sender, EventArgs e)
        {
            if(employees.Length==5)
            {
                MessageBox.Show("Not allow to add more than 5");
                    return;
            }
            Array.Resize(ref employees, employees.Length + 1);
            employees[employees.Length - 1] = Add(textBox1.Text, textBox2.Text);
        }
        private void btnShowArray_Click(object sender, EventArgs e)
        {
            foreach(Employee item in employees)
            {
                Add(item);
            }
        }
    }
}
