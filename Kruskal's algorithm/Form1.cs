using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Kruskal_s_algorithm
{
    public partial class Form1 : Form
    {
        //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        public int[,] Arcs = new int[,]
           {
            //{2,3,3,0 },
            //{3,4,5,0 },
            //{2,4,11,0 },
            //{2,1,20,0 },
            //{1,4,1,0 },
            //{2,5,23,0 },
            //{5,3,13,0 },
            //{3,8,8,0 },
            //{4,8,2,0 },
            //{4,7,7,0 },
            //{7,8,5,0 },
            //{7,1,3,0 },
            //{7,9,11,0 },
            //{1,9,45,0 },
            //{1,6,16,0 },
            //{9,6,3,0 },
            //{2,6,8,0 },


               {1,6,65,0 },
            {1,19,10 ,0},
            {19,17,35,0},
            {17,15,5,0},
            {15,9,65,0},
            {19,10,70 ,0},
            {17,20,50 ,0},
            {15,16,15 ,0},
            {9,5,45 ,0},
            {6,10,15 ,0},
            {10,20,10,0 },
            {20,16,20 ,0},
            {16,5,15,0 },
            {6,8,70,0 },
            {10,18,50 ,0 },
            {20,2,75,0 },
            {16,7,27,0 },
            {5,11,75 ,0},
            {8,18,5,0 },
            {18,2,15 ,0},
            {2,7,50 ,0},
            {7,11,65 ,0 },
            {8,3,46 ,0},
            {18,13,76 ,0},
            {2,4,34,0},
            {7,12,19,0 },
            {11,14,13,0 },
            {3,13,23,0 },
            {13,4,54,0 },
            {4,12,12 ,0},
            {12,14,67 ,0},
            {3,21,37,0},
            {21,22,97 ,0},
            {13,22,19 ,0},
            {22,23,27,0},
            {4,23,22 ,0},
            {23,24,54 ,0 },
            {12,24,34,0},
            {24,25,76,0},
            {25,14,57,0},
            {7,5,100,0},
            {1,10,100,0},
           };

        public int[,] SortArcs = new int[,]
             {

            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0 ,0},
            {0,0,0,0 ,0},
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0 ,0},
            {0,0,0,0 ,0},
            {0,0,0,0 ,0},
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0 ,0},
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0,0 },
            {0,0,0,0 ,0},
           };

        public int[,] Nodes = new int[,]
        {
            {1,0,0},
            {2,0,0},
            {3,0,0 },
            { 4,0,0},
            { 5,0,0},
            { 6,0,0},
            { 7,0,0},
            { 8,0,0},
            { 9,0,0},
            { 10,0,0},
            { 11,0,0},
            { 12,0,0},
            { 13,0,0},
            { 14,0,0},
            { 15,0,0},
            { 16,0,0},
            { 17,0,0},
            { 18,0,0},
            { 19,0,0},
            { 20,0,0},
            { 21,0,0},
            { 22,0,0},
            { 23,0,0},
            { 24,0,0},
            { 25,0,0},
};
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Vivaldi.wav");
            player.Play();

            ForSorting.Visible = false;
            ForDecision.Visible = false;
            ForArcs.Visible = false;
            pictureBox1.Visible = false;

            ForArcs.RowCount = 42;
            ForArcs.ColumnCount = 4;

            ForArcs.Columns[0].Width = 50;
            ForArcs.Columns[1].Width = 50;
            ForArcs.Columns[2].Width = 50;
            ForArcs.Columns[3].Width = 50;

            ForArcs.Columns[0].HeaderCell.Value = "From";
            ForArcs.Columns[1].HeaderCell.Value = "To";
            ForArcs.Columns[2].HeaderCell.Value = "Length";
            ForArcs.Columns[3].HeaderCell.Value = "Flag";

            for (int i = 0; i < 42; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    ForArcs.Rows[i].Cells[j].Value = Arcs[i, j];
                }
            }

            ForDecision.RowCount = 25;
            ForDecision.ColumnCount = 2;

            ForDecision.Columns[0].Width = 50;
            ForDecision.Columns[1].Width = 50;

            for (int i = 1; i <= 25; i++)
            {
                ForDecision.Rows[i - 1].Cells[0].Value = i;
            }

            ForDecision.Columns[0].HeaderCell.Value = "Node";
            ForDecision.Columns[1].HeaderCell.Value = "Tree";
        }
        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            withoutSorting.Visible = false;
            withSorting.Visible = false;
            showPicture.Visible = false;
            ExecuteButton.Visible = false;

            if (withoutSorting.Checked)
            {
                int nU = 25, nD = 42, treescount = 0, treesnumber = 0, usednodes = 0, From = 0, To = 0, FromTree = 0, ToTree = 0;
                ForDecision.Visible = true;
                ForArcs.Visible = true;

                while (true)
                {
                    int minelement = 10000, minelementposition = 0;
                    for (int i = 0; i < nD; i++)
                    {
                        int flag = Convert.ToInt32(ForArcs.Rows[i].Cells[3].Value);
                        if (flag == 0)
                        {
                            int tekL = Convert.ToInt32(ForArcs.Rows[i].Cells[2].Value);
                            if (tekL < minelement)
                            {
                                minelement = tekL;
                                minelementposition = i;
                            }
                            From = Convert.ToInt32(ForArcs.Rows[minelementposition].Cells[0].Value);
                            To = Convert.ToInt32(ForArcs.Rows[minelementposition].Cells[1].Value);
                            FromTree = Convert.ToInt32(ForDecision.Rows[From - 1].Cells[1].Value);
                            ToTree = Convert.ToInt32(ForDecision.Rows[To - 1].Cells[1].Value);
                        }
                    }


                    if (FromTree == 0 && ToTree == 0)
                    {
                        treescount++;
                        treesnumber++;
                        usednodes = usednodes + 2;
                        ForDecision.Rows[To - 1].Cells[1].Value = treescount;
                        ForDecision.Rows[From - 1].Cells[1].Value = treescount;
                        ForArcs.Rows[minelementposition].Cells[3].Value = 1;
                    }
                    else if ((FromTree != 0 && ToTree == 0) || (FromTree == 0 && ToTree != 0))
                    {
                        usednodes++;
                        if (FromTree == 0)
                        {
                            ForDecision.Rows[From - 1].Cells[1].Value = ToTree;
                        }
                        else if (ToTree == 0)
                        {
                            ForDecision.Rows[To - 1].Cells[1].Value = FromTree;
                        }

                        ForArcs.Rows[minelementposition].Cells[3].Value = 1;
                    }
                    else if (FromTree != 0 && ToTree != 0 && FromTree != ToTree)
                    {
                        treescount--;
                        for (int i = 0; i < nU; i++)
                        {
                            int treenum = Convert.ToInt32(ForDecision.Rows[i].Cells[1].Value);
                            if (treenum == ToTree)
                            {
                                ForDecision.Rows[i].Cells[1].Value = FromTree;
                            }
                        }
                        ForArcs.Rows[minelementposition].Cells[3].Value = 1;
                    }
                    else if (FromTree == ToTree)
                    {
                        ForArcs.Rows[minelementposition].Cells[3].Value = 2;
                    }
                    if (treescount == 1 && usednodes == nU)
                    {
                        break;
                    }
                }
                for (int i = 0; i < nD; i++)
                {
                    int flag = Convert.ToInt32(ForArcs.Rows[i].Cells[3].Value);
                    if (flag == 1)
                    {
                        ForArcs.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }
                    if (flag == 2)
                    {
                        ForArcs.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }

                Button exitToTheMenu = new Button();
                exitToTheMenu.Text = "Exit to the menu";
                exitToTheMenu.Size = new Size(88, 40);
                exitToTheMenu.Location = new Point(12, 81);
                this.Controls.Add(exitToTheMenu);
                exitToTheMenu.Click += new System.EventHandler(this.exitToTheMenu_Click);
            }

            else if (withSorting.Checked)
            {
                int nU = 25, treescount = 0, treesnumber = 0, usednodes = 0, From = 0, To = 0, FromTree = 0, ToTree = 0, minposition = 0;
                ForSorting.Visible = true;
                ForDecision.Visible = true;
                int min = 10000, nD = 42, count = 0, minIndex = 0;
                while (count != nD)
                {
                    for (int i = 0; i < nD; i++)
                    {

                        if (Arcs[i, 2] <= min)
                        {

                            if (Arcs[i, 3] == 0)
                            {
                                min = Arcs[i, 2];
                                minIndex = i;
                                for (int k = 0; k < 4; k++)
                                {
                                    SortArcs[count, k] = Arcs[minIndex, k];
                                }
                            }


                        }
                    }
                    Arcs[minIndex, 3] = 1;
                    min = 10000;
                    count++;

                }
                ForSorting.RowCount = nD;
                ForSorting.ColumnCount = 5;
                ForSorting.Columns[0].HeaderCell.Value = "Begin";
                ForSorting.Columns[1].HeaderCell.Value = "End";
                ForSorting.Columns[2].HeaderCell.Value = "Length";
                ForSorting.Columns[3].HeaderCell.Value = "Flag";
                ForSorting.Columns[0].Width = 50;
                ForSorting.Columns[1].Width = 50;
                ForSorting.Columns[2].Width = 50;
                ForSorting.Columns[3].Width = 50;
                for (int i = 0; i < nD; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        ForSorting.Rows[i].Cells[j].Value = SortArcs[i, j];
                    }

                }
                bool check = true;
                while (check == true)
                {
                    for (int i = 0; i < nD; i++)
                    {
                        int flag = Convert.ToInt32(ForSorting.Rows[i].Cells[3].Value);
                        if (flag == 0)
                        {
                            minposition = i;
                            From = Convert.ToInt32(ForSorting.Rows[i].Cells[0].Value);
                            To = Convert.ToInt32(ForSorting.Rows[i].Cells[1].Value);
                            FromTree = Convert.ToInt32(ForDecision.Rows[From - 1].Cells[1].Value);
                            ToTree = Convert.ToInt32(ForDecision.Rows[To - 1].Cells[1].Value);
                            break;
                        }
                    }


                    if (FromTree == 0
                        && ToTree == 0)
                    {
                        treescount++; treesnumber++;
                        usednodes = usednodes + 2;

                        ForDecision.Rows[To - 1].Cells[1].Value = treescount;
                        ForDecision.Rows[From - 1].Cells[1].Value = treescount;

                        ForSorting.Rows[minposition].Cells[3].Value = 1;
                    }
                    else if ((FromTree != 0 && ToTree == 0)
                        || (FromTree == 0 && ToTree != 0))
                    {
                        usednodes++;

                        if (FromTree == 0)
                        {
                            ForDecision.Rows[From - 1].Cells[1].Value = ToTree;
                        }

                        else if (ToTree == 0)
                        {
                            ForDecision.Rows[To - 1].Cells[1].Value = FromTree;
                        }

                        ForSorting.Rows[minposition].Cells[3].Value = 1;
                    }
                    else if (FromTree != 0 && ToTree != 0 && FromTree != ToTree)
                    {
                        treescount--;
                        for (int i = 0; i < nU; i++)
                        {
                            int treenum = Convert.ToInt32(ForDecision.Rows[i].Cells[1].Value);
                            if (treenum == ToTree)
                            {
                                ForDecision.Rows[i].Cells[1].Value = FromTree;
                            }
                        }

                        ForSorting.Rows[minposition].Cells[3].Value = 1;
                    }
                    else if (FromTree == ToTree)
                    {
                        ForSorting.Rows[minposition].Cells[3].Value = 2;
                    }

                    if (treescount == 1 && usednodes == nU)
                    {
                        check = false;
                    }
                }
                for (int i = 0; i < nD; i++)
                {
                    int flag = Convert.ToInt32(ForSorting.Rows[i].Cells[4].Value);
                    if (flag == 1)
                    {
                        ForSorting.Rows[i].Cells[0].Style.BackColor = Color.Green;
                    }
                    if (flag == 2)
                    {
                        ForSorting.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }

                Button exitToTheMenu = new Button();
                exitToTheMenu.Text = "Exit to the menu";
                exitToTheMenu.Size = new Size(88, 40);
                exitToTheMenu.Location = new Point(12, 81);
                this.Controls.Add(exitToTheMenu);
                exitToTheMenu.Click += new System.EventHandler(this.exitToTheMenu_Click);
            }

            else if (showPicture.Checked)
            {
                pictureBox1.Visible = true;

                Button exitToTheMenu = new Button();
                exitToTheMenu.Text = "Exit to the menu";
                exitToTheMenu.Size = new Size(88, 40);
                exitToTheMenu.Location = new Point(12, 81);
                this.Controls.Add(exitToTheMenu);
                exitToTheMenu.Click += new System.EventHandler(this.exitToTheMenu_Click);
            } 
        }
        private void exitToTheMenu_Click(object sender, EventArgs e)
        {
            withoutSorting.Visible = true;
            withSorting.Visible = true;
            showPicture.Visible = true;
            ExecuteButton.Visible = true;

            ForSorting.Visible = false;
            ForDecision.Visible = false;
            ForArcs.Visible = false;
            pictureBox1.Visible = false;

            ForArcs.RowCount = 42;
            ForArcs.ColumnCount = 4;

            ForArcs.Columns[0].Width = 50;
            ForArcs.Columns[1].Width = 50;
            ForArcs.Columns[2].Width = 50;
            ForArcs.Columns[3].Width = 50;

            ForArcs.Columns[0].HeaderCell.Value = "From";
            ForArcs.Columns[1].HeaderCell.Value = "To";
            ForArcs.Columns[2].HeaderCell.Value = "Length";
            ForArcs.Columns[3].HeaderCell.Value = "Flag";

            for (int i = 0; i < 42; i++)
            {
                Arcs[i, 3] = 0;
            }

            for (int i = 0; i < 42; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    ForArcs.Rows[i].Cells[j].Value = Arcs[i, j];
                }
            }
            
            ForDecision.RowCount = 25;
            ForDecision.ColumnCount = 2;

            ForDecision.Columns[0].Width = 50;
            ForDecision.Columns[1].Width = 50;

            for (int i = 0; i < 25; i++)
            {
                ForDecision.Rows[i].Cells[1].Value = 0;
            }

            for (int i = 1; i <= 25; i++)
            {
                ForDecision.Rows[i - 1].Cells[0].Value = i;
            }

            ForDecision.Columns[0].HeaderCell.Value = "Node";
            ForDecision.Columns[1].HeaderCell.Value = "Tree";
        }
    }
}


