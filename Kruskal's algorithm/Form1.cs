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
        public DataGridView Grid1 = new DataGridView();
        public DataGridView Grid2 = new DataGridView();
        public DataGridView Output = new DataGridView();

        public int count = 0;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        
        public Form1()
        {
            InitializeComponent();
        }

        
        public int[,] Arcs = new int[,]
           {
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
            { 1,0,0},
            { 2,0,0},
            { 3,0,0 },
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

        
        public int[,] NodesForDijkstra = new int[,]
        {
            {1,0,0,0},
            {2,0,0,0},
            {3,0,0,0},
            { 4,0,0,0},
            { 5,0,0,0},
            { 6,0,0,0},
            { 7,0,0,0},
            { 8,0,0,0},
            { 9,0,0,0},
            { 10,0,0,0},
            { 11,0,0,0},
            { 12,0,0,0},
            { 13,0,0,0},
            { 14,0,0,0},
            { 15,0,0,0},
            { 16,0,0,0},
            { 17,0,0,0},
            { 18,0,0,0},
            { 19,0,0,0},
            { 20,0,0,0},
            { 21,0,0,0},
            { 22,0,0,0},
            { 23,0,0,0},
            { 24,0,0,0},
            { 25,0,0,0},
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Vivaldi.wav");
            //player.Play();

            showIm.Visible = false;
            goToMenu.Visible = false;
            showTrees.Visible = false;
            showArcs.Visible = false;
            Graph.Visible = false;

            Grid1.Location = new Point(200, 12);
            Grid1.Width = 260;
            Grid1.Height = 210;
            Grid1.DataMember = "Adv_table";
            this.Controls.Add(Grid1);

            Grid2.Location = new Point(465, 12);
            Grid2.Width = 260;
            Grid2.Height = 210;
            Grid2.DataMember = "Adv_table";
            this.Controls.Add(Grid2);

            Output.Location = new Point(730, 12);
            Output.Width = 170;
            Output.Height = 210;
            Output.DataMember = "Adv_table";
            this.Controls.Add(Output);

            ForSorting.Visible = false;
            ForDecision.Visible = false;
            ForArcs.Visible = false;
            pictureBox1.Visible = false;
            Grid1.Visible = false;
            Grid2.Visible = false;
            Output.Visible = false;

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
            ForDecision.ColumnCount = 3;

            ForDecision.Columns[0].Width = 50;
            ForDecision.Columns[1].Width = 50;

            for (int i = 1; i <= 25; i++)
            {
                ForDecision.Rows[i - 1].Cells[0].Value = i;
            }

            ForDecision.Columns[0].HeaderCell.Value = "Node";
            ForDecision.Columns[1].HeaderCell.Value = "Tree";

            int n = 40;
            int m = 3;

            Grid1.RowCount = n;
            Grid1.ColumnCount = m;
            Grid1.Columns[0].HeaderCell.Value = "От";
            Grid1.Columns[1].HeaderCell.Value = "До";
            Grid1.Columns[2].HeaderCell.Value = "Расстояние";
            Grid1.Columns[0].Width = 30;
            Grid1.Columns[1].Width = 30;
            Grid1.Columns[2].Width = 70;

            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Grid1.Rows[i].Cells[j].Value = Arcs[i, j];
                }
            }

            int x = 25;
            int y = 4;

            Grid2.RowCount = x;
            Grid2.ColumnCount = y;
            Grid2.Columns[0].Width = 50;
            Grid2.Columns[1].Width = 50;
            Grid2.Columns[2].Width = 50;
            Grid2.Columns[3].Width = 50;
            Grid2.Columns[0].HeaderCell.Value = "№ узла";
            Grid2.Columns[1].HeaderCell.Value = "Откуда";
            Grid2.Columns[2].HeaderCell.Value = "Суммарный путь";
            Grid2.Columns[3].HeaderCell.Value = "Флаг";

            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Grid2.Rows[i].Cells[j].Value = NodesForDijkstra[i, j];
                }
            }
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
            withPrim.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            Dijkstra.Visible = false;
            BeginPointBox.Visible = false;
            showPicture.Visible = false;
            ExecuteButton.Visible = false;
            CloseForm.Visible = false;

            showIm.Visible = true;
            goToMenu.Visible = true;

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
                            int currentWeight = Convert.ToInt32(ForArcs.Rows[i].Cells[2].Value);

                            if (currentWeight < minelement)
                            {
                                minelement = currentWeight;
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

                showIm.Click += new EventHandler(showIm_Click);
                showTrees.Visible = true;
            }

            else if (withSorting.Checked)
            {
                int nU = 25, treescount = 0, treesnumber = 0, usednodes = 0, From = 0, To = 0, FromTree = 0, ToTree = 0, minposition = 0;
                int min = 10000, nD = 42, count = 0, minIndex = 0;

                ForSorting.Visible = true;
                ForDecision.Visible = true;

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

                showIm.Click += new EventHandler(showIm_Click);
                showTrees.Visible = true;
                showArcs.Visible = true;
            }

            else if (showPicture.Checked)
            {
                pictureBox1.Visible = true;
            }

            else if (withPrim.Checked)
            {
                ForDecision.RowCount = 25;
                ForDecision.ColumnCount = 3;

                ForDecision.Visible = true;
                ForArcs.Visible = true;
                
                int Current = int.Parse(BeginPointBox.Text), nU = 25, nD = 40, count = 1;

                ForDecision.Rows[Current - 1].Cells[1].Value = 1;
                ForDecision.Rows[Current - 1].Cells[2].Value = 2;

                while (count != nU)
                {
                    for (int i = 0; i < nD; i++)
                    {
                        int FirstCity = Convert.ToInt32(ForArcs.Rows[i].Cells[0].Value);
                        int SecondCity = Convert.ToInt32(ForArcs.Rows[i].Cells[1].Value);

                        int NewCity = 0;

                        int FirstCheck = Convert.ToInt32(ForDecision.Rows[FirstCity - 1].Cells[2].Value);
                        int SecondCheck = Convert.ToInt32(ForDecision.Rows[SecondCity - 1].Cells[2].Value);

                        if (FirstCity == Current && SecondCheck != 2)
                        {
                            NewCity = SecondCity;

                            ForDecision.Rows[NewCity - 1].Cells[1].Value = 1;
                        }

                        if (SecondCity == Current && FirstCheck != 2)
                        {
                            NewCity = FirstCity;

                            ForDecision.Rows[NewCity - 1].Cells[1].Value = 1;
                        }
                    }

                    int MinLength = int.MaxValue, Length;
                    int SecondFlag, FirstFlag;
                    int Position = 0, MinPosition = 0;

                    for (int i = 0; i < nU; i++)
                    {
                        SecondFlag = Convert.ToInt32(ForDecision.Rows[i].Cells[2].Value);
                        FirstFlag = Convert.ToInt32(ForDecision.Rows[i].Cells[1].Value);

                        if (SecondFlag != 2 && FirstFlag == 1)
                        {
                            for (int j = 0; j < nD; j++)
                            {
                                int FirstCity = Convert.ToInt32(ForArcs.Rows[j].Cells[0].Value);
                                int SecondCity = Convert.ToInt32(ForArcs.Rows[j].Cells[1].Value);

                                Length = Convert.ToInt32(ForArcs.Rows[j].Cells[2].Value);

                                if (FirstCity == i + 1)
                                {
                                    if (Convert.ToInt32(ForDecision.Rows[FirstCity - 1].Cells[2].Value) != 2)
                                    {
                                        if (Convert.ToInt32(ForDecision.Rows[SecondCity - 1].Cells[2].Value) == 2)
                                        {
                                            Length = Convert.ToInt32(ForArcs.Rows[j].Cells[2].Value);

                                            if (Length < MinLength)
                                            {
                                                MinLength = Length;
                                                Position = i;
                                                MinPosition = j;
                                            }
                                        }
                                    }
                                }
                                if (SecondCity == i + 1)
                                {
                                    if (Convert.ToInt32(ForDecision.Rows[SecondCity - 1].Cells[2].Value) != 2)
                                    {
                                        if (Convert.ToInt32(ForDecision.Rows[FirstCity - 1].Cells[2].Value) == 2)
                                        {
                                            Length = Convert.ToInt32(ForArcs.Rows[j].Cells[2].Value);

                                            if (Length < MinLength)
                                            {
                                                MinLength = Length;
                                                Position = i;
                                                MinPosition = j;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    int DecisionFirst = Convert.ToInt32(ForArcs.Rows[MinPosition].Cells[0].Value);
                    int DecisionSecond = Convert.ToInt32(ForArcs.Rows[MinPosition].Cells[1].Value);

                    for (int i = 0; i < nD; i++)
                    {
                        if (Arcs[i, 0] == DecisionFirst && Arcs[i, 1] == DecisionSecond)
                        {
                            ForArcs.Rows[i].Cells[0].Style.BackColor = System.Drawing.Color.Green;
                            ForArcs.Rows[i].Cells[1].Style.BackColor = System.Drawing.Color.Green;
                            ForArcs.Rows[i].Cells[2].Style.BackColor = System.Drawing.Color.Green;
                        }
                    }

                    Current = Convert.ToInt32(ForDecision.Rows[Position].Cells[0].Value);

                    ForDecision.Rows[Position].Cells[2].Value = 2;

                    count++;
                }

                showIm.Click += new EventHandler(showIm_Click);
            }

            else if (Dijkstra.Checked)
            {
                int nD = 40, nU = 25, current = int.Parse(textBox1.Text), end = int.Parse(textBox2.Text), currentS = 0, length = 0, newcity = 0, minimumS = 0;
                NodesForDijkstra[current - 1, 3] = 1;

                Grid1.Visible = true;
                Grid2.Visible = true;
                Output.Visible = true;

                while (current != end)
                {
                    for (int i = 0; i < nD; i++)
                    {
                        int city = 0;
                        if (Arcs[i, 0] == current)
                        {
                            city = Arcs[i, 1];
                            length = Arcs[i, 2];
                        }
                        else if (Arcs[i, 1] == current)
                        {
                            city = Arcs[i, 0];
                            length = Arcs[i, 2];
                        }
                        if (city > 0)
                        {
                            int flag = NodesForDijkstra[city - 1, 3];

                            if (flag == 0)
                            {
                                int current_s = Convert.ToInt32(Grid2.Rows[city - 1].Cells[2].Value);
                                int from = Convert.ToInt32(Grid2.Rows[city - 1].Cells[1].Value);

                                if (current_s == 0 || length + currentS < current_s)
                                {
                                    current_s = length + currentS;
                                    from = current;
                                    Grid2.Rows[city - 1].Cells[2].Value = current_s;
                                    Grid2.Rows[city - 1].Cells[1].Value = from;
                                }

                            }
                        }
                    }

                    for (int j = 0; j < nU; j++)
                    {
                        int t_flag = Convert.ToInt32(Grid2.Rows[j].Cells[3].Value);
                        int current_s = Convert.ToInt32(Grid2.Rows[j].Cells[2].Value);

                        if (t_flag == 0 && current_s > 0)
                        {
                            newcity = j;
                            minimumS = current_s;
                            break;
                        }
                    }
                    for (int j = newcity + 1; j < nU; j++)
                    {
                        int t_flag = Convert.ToInt32(Grid2.Rows[j].Cells[3].Value);
                        int current_s = Convert.ToInt32(Grid2.Rows[j].Cells[2].Value);

                        if (t_flag == 0 && current_s > 0)
                        {
                            if (current_s < minimumS)
                            {
                                newcity = j;
                                minimumS = current_s;
                            }
                        }
                    }

                    Grid2.Rows[newcity].Cells[3].Value = 1;
                    current = newcity + 1;
                    currentS = Convert.ToInt32(Grid2.Rows[newcity].Cells[2].Value);
                }
                int current1 = int.Parse(textBox2.Text);
                int beginPoint = int.Parse(textBox1.Text);
                int way;

                Grid2.Rows[beginPoint - 1].Cells[0].Style.BackColor = System.Drawing.Color.Gray;
                Output.ColumnCount = 1;
                Output.RowCount = 24;
                Output.Rows[0].Cells[0].Value = current1;

                int p = 1;

                while (current1 != beginPoint)
                {
                    for (int i = 24; i >= 0; i--)
                    {
                        int c = 0;

                        if (Convert.ToInt32(Grid2.Rows[i].Cells[0].Value) == current1)
                        {
                            c = i;
                        }

                        if (c > 0)
                        {
                            Grid2.Rows[c].Cells[0].Style.BackColor = System.Drawing.Color.Gray;

                            way = Convert.ToInt32(Grid2.Rows[c].Cells[1].Value);

                            for (int q = 0; q < nD; q++)
                            {
                                if (Arcs[q, 0] == current1 && Arcs[q, 1] == way
                                    || Arcs[q, 1] == current1 && Arcs[q, 0] == way)
                                {
                                    Grid1.Rows[q].Cells[0].Style.BackColor = System.Drawing.Color.Green;
                                    Grid1.Rows[q].Cells[1].Style.BackColor = System.Drawing.Color.Green;
                                    Grid1.Rows[q].Cells[2].Style.BackColor = System.Drawing.Color.Green;
                                }
                            }
                            current1 = way;
                            Output.Rows[p].Cells[0].Value = current1;

                            p++;
                        }
                    }
                }

                Graph.Visible = true;
                showIm.Click += new EventHandler(showIm_Click);
            }
        }
        
        private void showIm_Click(object sender, EventArgs e)
        {
            if (count%2!=0)
            {
                pictureBox1.Visible = true;
            }

            else
            {
                pictureBox1.Visible = false;

            }

            count++;
        }
        
        private void ForArcs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void goToMenu_Click(object sender, EventArgs e)
        {
            withoutSorting.Visible = true;
            withSorting.Visible = true;
            showPicture.Visible = true;
            ExecuteButton.Visible = true;
            withPrim.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            Dijkstra.Visible = true;
            BeginPointBox.Visible = true;
            CloseForm.Visible = true;

            Grid1.Visible = false;
            Grid2.Visible = false;
            Output.Visible = false;
            ForSorting.Visible = false;
            ForDecision.Visible = false;
            ForArcs.Visible = false;
            pictureBox1.Visible = false;
            showIm.Visible = false;
            goToMenu.Visible = false;
            showTrees.Visible = false;
            showArcs.Visible = false;
            Graph.Visible = false;

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


            for (int i = 1; i <= 25; i++)
            {
                ForDecision.Rows[i - 1].Cells[0].Value = i;
            }

            ForDecision.Columns[0].HeaderCell.Value = "Node";
            ForDecision.Columns[1].HeaderCell.Value = "Tree";

            for (int i=0;i<25;i++)
            {
                ForDecision.Rows[i].Cells[1].Value = 0;
                ForDecision.Rows[i].Cells[1].Style.BackColor = System.Drawing.Color.White;
            }

            for (int i = 0; i < 42; i++)
            {
                ForArcs.Rows[i].Cells[3].Value = 0;
            }

            showIm.Click += new EventHandler(showIm_Click);
        }

        private void showTrees_Click(object sender, EventArgs e)
        {
            int tree = Convert.ToInt32(ForDecision.Rows[0].Cells[1].Value);

            if (count%2!=0)
            {
                for (int i = 0; i < 25; i++)
                {
                    if (Convert.ToInt32(ForDecision.Rows[i].Cells[1].Value) == tree)
                    {
                        ////ForDecision.Rows[i].Cells[0].Style.BackColor = System.Drawing.Color.Green;
                        ForDecision.Rows[i].Cells[1].Style.BackColor = System.Drawing.Color.Green;
                    }
                }
            }
            
            else
            {
                for (int i = 0; i < 25; i++)
                {
                    if (Convert.ToInt32(ForDecision.Rows[i].Cells[1].Value) == tree)
                    {
                        ////ForDecision.Rows[i].Cells[0].Style.BackColor = System.Drawing.Color.Green;
                        ForDecision.Rows[i].Cells[1].Style.BackColor = System.Drawing.Color.White;
                    }
                }
            }
            

        }

        private void showArcs_Click(object sender, EventArgs e)
        {

            if (count%2==1)
            {
                for (int i = 0; i < 42; i++)
                {
                    if (Convert.ToInt32(ForSorting.Rows[i].Cells[3].Value) == 1)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            ForSorting.Rows[i].Cells[j].Style.BackColor = Color.Green;
                        }
                    }

                    else if (Convert.ToInt32(ForSorting.Rows[i].Cells[3].Value) == 2)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            ForSorting.Rows[i].Cells[j].Style.BackColor = Color.Red;
                        }
                    }
                }
            }

            else
            {
                for (int i = 0; i < 42; i++)
                {
                    if (Convert.ToInt32(ForSorting.Rows[i].Cells[3].Value) == 1)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            ForSorting.Rows[i].Cells[j].Style.BackColor = Color.White;
                        }
                    }

                    else if (Convert.ToInt32(ForSorting.Rows[i].Cells[3].Value) == 2)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            ForSorting.Rows[i].Cells[j].Style.BackColor = Color.White;
                        }
                    }
                }
            }

            count++;
        }
    }
}


