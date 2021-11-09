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

namespace Homework_UI
{
    public partial class Form1 : Form
    {
        List<Homework> HomeworkList = new List<Homework>();
        int a;
        int b;
        int c;
        public Form1()
        {
            InitializeComponent();
            GetAssignemtns();
            CreateAssignments();
        }

        private void CreateAssignments()
        {
            for (int i = 0; i < HomeworkList.Count(); i++)
            {
                Homework H = HomeworkList[i];
                Assignment one = new Assignment(H);
                if (H.DueDate1 < DateTime.Today )
                {
                    one.BackColor = Color.DarkRed;
                    one.Parent = tabPage3;
                    one.Location = new Point(10, 120 * c + 10);
                    c++;
                }
                if (H.Completed1 == true)
                {
                    one.BackColor = Color.DarkOrange;
                    one.Parent = tabPage2;
                    one.Location = new Point(10, 120 * b + 10);
                    b++;
                }
                if (H.DueDate1 > DateTime.Today)
                {
                    one.BackColor = Color.DarkGreen;
                    one.Parent = tabPage1;
                    one.Location = new Point(10, 120 * a + 10);
                    a++;
                }
            }
        }
        private void GetAssignemtns()
        {
            StreamReader R = new StreamReader("HomeworkList.txt");
            while (R.EndOfStream != true)
            {
                string temp1 = R.ReadLine();
                string[] temparray = temp1.Split(',');
                Homework X = new Homework(temparray[0], temparray[1], Convert.ToBoolean(temparray[2]), Convert.ToDateTime(temparray[3]), temparray[4]);
                HomeworkList.Add(X);
            }
            R.Close();
        }

        private void BTNCreateTask_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void Save()
        {
            System.IO.File.WriteAllText("HomeworkList.txt", string.Empty);
            try
            {
                DateTime.Parse(TBXDueDate.Text);
                HomeworkList.Add(new Homework(TBXSubject.Text, TBXTitle.Text, false, DateTime.Parse(TBXDueDate.Text), TBXDesc.Text));
                StreamWriter SW = new StreamWriter("HomeworkList.txt");
                int i = 0;
                foreach (Homework item in HomeworkList)
                {
                    SW.Write(HomeworkList[i].Subject1 + ",");
                    SW.Write(HomeworkList[i].Name1 + ",");
                    SW.Write(HomeworkList[i].Completed1 + ",");
                    SW.Write(HomeworkList[i].DueDate1 + ",");
                    SW.WriteLine(HomeworkList[i].Despcription1);
                    i++;
                }
                SW.Close();
                Application.Restart();
            }
            catch
            {
                TBXDueDate.Text = "Error";
            }
        }
    }
}