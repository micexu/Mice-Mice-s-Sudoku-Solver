using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuCracker
{
    public class Sudoku
    {
        //声明整形数组和布尔数组，以存放数组各方格的数值以及标记方格可填性
        public int[,] GridNumber = new int[9, 9];
        private bool[,] GridLocked = new bool[9, 9];

        //声明二维数组List和整形变量以存放答案和答案数量
        public List<int[,]> Answer = new List<int[,]>();
        public int AnswerCount = 0;

        //int二维数组作为实参转入构造， 以生成带谜题的数独
        public Sudoku(int[,] integerarray)
        {

            //将实参数组上的各元素赋值到数组GridNumber
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    GridNumber[row, column] = integerarray[row, column];

                    //将非零的数组元素，对应相同索引的Gridlocked元素设为true，以标记数独中该方格
                    if (GridNumber[row, column] != 0)
                    {
                        GridLocked[row, column] = true;
                    }
                }
            }
        }

        //重载一个无参构造，以生成空白的数独
        public Sudoku()
        {

            //声明一个空白int数组
            int[,] emptyarray = new int[9, 9];
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    emptyarray[row, column] = 0;
                }
            }

            //数组作为参数传入构造
            new Sudoku(emptyarray);
        }

        public static void GridToBox(int rowindex, int columnindex, out int boxindex, out int boxgridindex)
        {
            switch (rowindex)
            {
                case 0:
                case 1:
                case 2:
                    switch (columnindex)
                    {
                        case 0:
                        case 1:
                        case 2:
                            boxindex = 0;
                            boxgridindex = rowindex * 3 + columnindex;
                            break;
                        case 3:
                        case 4:
                        case 5:
                            boxindex = 1;
                            boxgridindex = rowindex * 3 + columnindex - 3;
                            break;
                        case 6:
                        case 7:
                        case 8:
                            boxindex = 2;
                            boxgridindex = rowindex * 3 + columnindex - 6;
                            break;
                        default:
                            boxindex = boxgridindex = -1;
                            break;
                    }
                    break;
                case 3:
                case 4:
                case 5:
                    switch (columnindex)
                    {
                        case 0:
                        case 1:
                        case 2:
                            boxindex = 3;
                            boxgridindex = (rowindex - 3) * 3 + columnindex;
                            break;
                        case 3:
                        case 4:
                        case 5:
                            boxindex = 4;
                            boxgridindex = (rowindex - 3) * 3 + columnindex - 3;
                            break;
                        case 6:
                        case 7:
                        case 8:
                            boxindex = 5;
                            boxgridindex = (rowindex - 3) * 3 + columnindex - 6;
                            break;
                        default:
                            boxindex = boxgridindex = -1;
                            break;
                    }
                    break;
                case 6:
                case 7:
                case 8:
                    switch (columnindex)
                    {
                        case 0:
                        case 1:
                        case 2:
                            boxindex = 6;
                            boxgridindex = (rowindex - 6) * 3 + columnindex;
                            break;
                        case 3:
                        case 4:
                        case 5:
                            boxindex = 7;
                            boxgridindex = (rowindex - 6) * 3 + columnindex - 3;
                            break;
                        case 6:
                        case 7:
                        case 8:
                            boxindex = 8;
                            boxgridindex = (rowindex - 6) * 3 + columnindex - 6;
                            break;
                        default:
                            boxindex = boxgridindex = -1;
                            break;
                    }
                    break;
                default:
                    boxindex = boxgridindex = -1;
                    break;
            }
        }

        public static void BoxToGrid(int boxindex, int boxgridindex, out int rowindex, out int columnindex)
        {
            switch (boxindex)
            {
                case 0:
                case 1:
                case 2:
                    switch(boxgridindex)
                    {
                        case 0:
                        case 1:
                        case 2:
                            rowindex = 0;
                            columnindex = boxindex * 3 + boxgridindex;
                            break;
                        case 3:
                        case 4:
                        case 5:
                            rowindex = 1;
                            columnindex = (boxindex - 1) * 3 + boxgridindex;
                            break;
                        case 6:
                        case 7:
                        case 8:
                            rowindex = 2;
                            columnindex = (boxindex - 2) * 3 + boxgridindex;
                            break;
                        default:
                            rowindex = columnindex = -1;
                            break;
                    }
                    break;
                case 3:
                case 4:
                case 5:
                    switch (boxgridindex)
                    {
                        case 0:
                        case 1:
                        case 2:
                            rowindex = 3;
                            columnindex = (boxindex - 3) * 3 + boxgridindex;
                            break;
                        case 3:
                        case 4:
                        case 5:
                            rowindex = 4;
                            columnindex = (boxindex - 4) * 3 + boxgridindex;
                            break;
                        case 6:
                        case 7:
                        case 8:
                            rowindex = 5;
                            columnindex = (boxindex - 5) * 3 + boxgridindex;
                            break;
                        default:
                            rowindex = columnindex = -1;
                            break;
                    }
                    break;
                case 6:
                case 7:
                case 8:
                    switch (boxgridindex)
                    {
                        case 0:
                        case 1:
                        case 2:
                            rowindex = 6;
                            columnindex = (boxindex - 6) * 3 + boxgridindex;
                            break;
                        case 3:
                        case 4:
                        case 5:
                            rowindex = 7;
                            columnindex = (boxindex - 7) * 3 + boxgridindex;
                            break;
                        case 6:
                        case 7:
                        case 8:
                            rowindex = 8;
                            columnindex = (boxindex - 8) * 3 + boxgridindex;
                            break;
                        default:
                            rowindex = columnindex = -1;
                            break;
                    }
                    break;
                default:
                    rowindex = columnindex = -1;
                    break;
            }
        }

        private bool CheckRule(int rowindex, int columnindex, int value, out int stuckrow, out int stuckcolumn)
        {
            if (value == 0)
            {
                stuckrow = stuckcolumn = -1;
                return false;
            }
            int boxindex, boxgridindex;
            GridToBox(rowindex, columnindex, out boxindex, out boxgridindex);
            for (int i = 0; i < 9; i++)
            {
                int row, column;
                BoxToGrid(boxindex, i, out row, out column);
                if (i != rowindex && GridNumber[i, columnindex] == value)
                {
                    stuckrow = i;
                    stuckcolumn = columnindex;
                    return false;
                }
                else if (i != columnindex && GridNumber[rowindex, i] == value)
                {
                    stuckrow = rowindex;
                    stuckcolumn = i;
                    return false;
                }
                else if (i != boxgridindex && GridNumber[row, column] == value)
                {
                    stuckrow = row;
                    stuckcolumn = column;
                    return false;
                }
            }
            stuckrow = stuckcolumn = -1;
            return true;
        }

        public static bool CheckRule(int[,] givenpuzzle, int rowindex, int columnindex, int value, Label[,] gridlabel, Label dialoglabel)
        {
            int stuckrow, stuckcolumn;
            Sudoku givensudoku = new Sudoku(givenpuzzle);
            bool ToReturn = givensudoku.CheckRule(rowindex, columnindex, value, out stuckrow, out stuckcolumn);
            if (stuckrow >= 0)
            {
                gridlabel[rowindex, columnindex].ForeColor = gridlabel[stuckrow, stuckcolumn].ForeColor = System.Drawing.Color.DarkRed;
                dialoglabel.Text = "方格(" + (rowindex + 1) + "," + (columnindex + 1) + ")填入数值" + value + "失败，方格(" + (stuckrow + 1) + "," + (stuckcolumn + 1) + ")含有相同值。\n" +
                    "Fill(" + (rowindex + 1) + "," + (columnindex + 1) + ") with value " + value + " failed. Same value found in(" + (stuckrow + 1) + "," + (stuckcolumn + 1) + ").";

            }
            return ToReturn;
        }

        private bool CheckExist(int rowindex, int columnindex)
        {
            for (int value = 1; value <= 9; value++)
            {
                bool checkrule = CheckRule(rowindex, columnindex, value, out int sr, out int sc);
                if (checkrule)
                {
                    return true;
                }
            }
            return false;
        }

        public void GenerateOneHint(out int rowindex, out int columnindex, out int value)
        {
            Random random = new Random();
            //生成坐标位置
            do
            {
                rowindex = random.Next(0, 9);
                columnindex = random.Next(0, 9);
            } while (GridNumber[rowindex, columnindex] != 0 || !CheckExist(rowindex, columnindex));

            //生成值
            do
            {
                value = random.Next(1, 10);
            } while (!CheckRule(rowindex, columnindex, value, out int sr, out int sc));

            //赋值并标记为锁定
            GridNumber[rowindex, columnindex] = value;
            GridLocked[rowindex, columnindex] = true;
        }

        private void FindFirstFillable(out int firstrow, out int firstcolumn)
        {
            if (GridLocked[0, 0])
            {
                FindNextFillable(0, 0, out firstrow, out firstcolumn);
            }
            else
            {
                firstrow = firstcolumn = 0;
            }
        }

        private void FindNextFillable(int currentrow, int currentcolumn, out int nextrow, out int nextcolumn)
        {
            do
            {
                currentcolumn++;
                if (currentcolumn >= 9)
                {
                    currentrow++;
                    if (currentcolumn >= 9)
                    {
                        nextrow = nextcolumn = -1;
                        return;
                    }
                }
            } while (GridLocked[currentrow, currentcolumn]);
            nextrow = currentrow;
            nextcolumn = currentcolumn;
        }

        //计算答案
        public void GetAnswer(int currentrow, int currentcolumn, int answercountstostop, bool torecord, Label[,] gridlabel, Label dialoglabel)
        {
            //坐标超出数独范围则返回上一方格
            if (currentrow == -1 || currentcolumn == -1)
            {
                return;
            }

            //计算首个可填方格和下个可填方格的坐标
            FindFirstFillable(out int firstrow, out int firstcolumn);
            FindNextFillable(currentrow, currentcolumn, out int nextrow, out int nextcolumn);
            
            for (int tryvalue = 1; tryvalue <= 9; tryvalue++)
            {
                //跳过非法赋值
                if (!CheckRule(currentrow, currentcolumn, tryvalue, out int stuckrow, out int stuckcolumn))
                {
                    continue;
                }

                //记录下合法赋值
                GridNumber[currentrow, currentcolumn] = tryvalue;
                gridlabel[currentrow, currentcolumn].Text = tryvalue.ToString();
                gridlabel[currentrow, currentcolumn].ForeColor = System.Drawing.Color.DarkGreen;

                //尝试下一方格
                GetAnswer(nextrow, nextcolumn, answercountstostop, torecord, gridlabel, dialoglabel);

                //首个可填方格合法赋值完成即谜题存在答案
                if (currentrow == firstrow && currentcolumn == firstcolumn)
                {
                    //答案数自加
                    AnswerCount++;


                    if (AnswerCount == -1)
                    {
                        continue;
                    }
                    dialoglabel.Text = "得出答案，目前答案数：" + AnswerCount + "\nAnswer found, current amount of answers: " + AnswerCount;
                    

                    //按照torecord实参的真假性记录答案列表
                    if (torecord)
                    {
                        Answer.Add(new int[9, 9]);
                        for (int row = 0; row < 9; row++)
                        {
                            for (int column = 0; column < 9; column++)
                            {
                                Answer[AnswerCount - 1][row, column] = GridNumber[row, column];
                            }
                        }
                    }

                    //检测指定的答案数是否为-1，是则计算整个谜题所有答案
                    if (AnswerCount == -1)
                    {
                        continue;
                    }

                    //检测答案数是否到达指定的答案数，是则退出返回
                    if (AnswerCount >= answercountstostop)
                    {
                        return;
                    }
                }
            }

            //首个可填方格历遍所有值
            if (currentrow == firstrow && currentcolumn == firstcolumn)
            {
                //如果答案数不为0，则此谜题存在答案
                if (AnswerCount > 0)
                {

                }

                //否则此谜题没有答案
                else
                {

                }
            }

            //其余方格历遍所有值即目前方格尚无答案
            else
            {

            }

            //清除此方格数字            
            GridNumber[currentrow, currentcolumn] = 0;
        }
    }

    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WelcomeForm());
        }
    }
}
