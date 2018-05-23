using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuCracker
{
    public class Sudoku
    {
        int triescount = 0;

        //int二维数组作为实参转入构造， 以生成带谜题的数独
        //声明整形数组和布尔数组，以存放数组各方格的数值以及标记方格可填性
        public int[,] GridNumber = new int[9, 9];
        private bool[,] GridLocked = new bool[9, 9];
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

        //重写ToString方法
        public override string ToString()
        {
            return ArrayToString(GridNumber);
        }

        //二维整形数组转换成带制表符的字符串
        private static string ArrayToString(int[,] integerarray)
        {
            string ToReturn = "";
            for (int rowindex = 0; rowindex < 19; rowindex++)
            {
                if (rowindex % 2 == 0)
                {
                    if (rowindex % 6 == 0)
                    {
                        if (rowindex == 0)
                        {
                            ToReturn += "┏━┯━┯━┳━┯━┯━┳━┯━┯━┓";
                        }
                        else if (rowindex == 18)
                        {
                            ToReturn += "┗━┷━┷━┻━┷━┷━┻━┷━┷━┛";
                        }
                        else
                        {
                            ToReturn += "┣━┿━┿━╋━┿━┿━╋━┿━┿━┫";
                        }
                    }
                    else
                    {
                        ToReturn += "┠─┼─┼─╂─┼─┼─╂─┼─┼─┨";
                    }
                    ToReturn += "\r\n";
                }
                else
                {
                    for (int columnindex = 0; columnindex < 19; columnindex++)
                    {
                        if (columnindex % 2 == 0)
                        {
                            if (columnindex % 6 == 0)
                            {
                                ToReturn += "┃";
                                if (columnindex == 18)
                                {
                                    ToReturn += "\r\n";
                                }
                            }
                            else
                            {
                                ToReturn += "│";
                            }
                        }
                        else
                        {
                            if (integerarray[(rowindex - 1) / 2, (columnindex - 1) / 2] == 0)
                            {
                                ToReturn += "  ";
                            }
                            else
                            {
                                ToReturn += (integerarray[(rowindex - 1) / 2, (columnindex - 1) / 2] + " ");
                            }
                        }
                    }
                }
            }
            return ToReturn;
        }

        //重载ArrayToString方法的短整型版本
        public static string ArrayToString(short[,] shortarray)
        {
            int[,] tointeger = new int[9, 9];
            for (int rowindex = 0; rowindex < 9; rowindex++)
            {
                for (int columnindex = 0; columnindex < 9; columnindex++)
                {
                    tointeger[rowindex, columnindex] = shortarray[rowindex, columnindex];
                }
            }

            return ArrayToString(tointeger);
        }

        //行列坐标转换成宫格坐标
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
        
        //宫格坐标转换成行列坐标
        public static void BoxToGrid(int boxindex, int boxgridindex, out int rowindex, out int columnindex)
        {
            switch (boxindex)
            {
                case 0:
                case 1:
                case 2:
                    switch (boxgridindex)
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

        //不带UI的检查方格合理性
        private bool CheckRule(int rowindex, int columnindex, int value, out int stuckrow, out int stuckcolumn)
        {
            //传入value为零时，标记冲突坐标为(-1,-1)，返回false
            if (value == 0)
            {
                stuckrow = stuckcolumn = -1;
                return false;
            }

            //传入的行列坐标转换成宫格坐标
            GridToBox(rowindex, columnindex, out int boxindex, out int boxgridindex);

            //同一行、列、宫中对另外八个方格的检查，存在相同值时，标记冲突坐标并且返回false
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

            //不存在相同值时，标记冲突坐标为(-1,-1)，返回true
            stuckrow = stuckcolumn = -1;
            return true;
        }

        //带UI的检查方格合理性
        public bool CheckRule(int rowindex, int columnindex, int value, FunctionForm userinterface)
        {
            //将不带UI同名方法返回值赋到ToReturn中，获取冲突的行列坐标
            bool ToReturn = CheckRule(rowindex, columnindex, value, out int stuckrow, out int stuckcolumn);

            //存在冲突坐标时在UI上显示冲突详情
            if (stuckrow >= 0)
            {
                userinterface.SudokuGridLabel[rowindex, columnindex].ForeColor 
                    = userinterface.SudokuGridLabel[stuckrow, stuckcolumn].ForeColor = System.Drawing.Color.DarkRed;
                userinterface.SetDialogText("方格(" + (rowindex + 1) + "," + (columnindex + 1) + ")填入数值" + value + "失败，" +
                    "方格(" + (stuckrow + 1) + "," + (stuckcolumn + 1) + ")含有相同值。\n" +
                    "Fill(" + (rowindex + 1) + "," + (columnindex + 1) + ") with value " + value + " failed. " +
                    "Same value found in(" + (stuckrow + 1) + "," + (stuckcolumn + 1) + ").");
            }
            //返回ToReturn
            return ToReturn;
        }

        //检查方格是否存在答案值
        private bool CheckExist(int rowindex, int columnindex)
        {
            //对方格中检查9个可能的数值，存在数值可以填入时返回true
            for (int value = 1; value <= 9; value++)
            {
                if (CheckRule(rowindex, columnindex, value, out int sr, out int sc))
                {
                    return true;
                }
            }

            //9个数值都无法成为合理值则返回false
            return false;
        }

        //生成一个提示
        public void GenerateOneHint(out int rowindex, out int columnindex, out int value, FunctionForm userinterface)
        {
            //声明所需数值和类
            Random random = new Random();
            bool toregenerate = false;
            rowindex = columnindex = 0;
            
            //清空可填方格、清零答案数
            AnswerCount = 0;
            ClearGrid(false);

            do
            {
                //如果因答案不存在而进入本循环，则清除方格数值和取消锁定标记
                if (toregenerate)
                {
                    GridNumber[rowindex, columnindex] = 0;
                    GridLocked[rowindex, columnindex] = false;
                    toregenerate = false;
                }

                //生成可填的坐标位置
                do
                {
                    rowindex = random.Next(0, 9);
                    columnindex = random.Next(0, 9);
                } while (GridLocked[rowindex, columnindex]);

                //生成可填的值
                do
                {
                    value = random.Next(1, 10);
                } while (!CheckRule(rowindex, columnindex, value, out int sr, out int sc));

                //赋值并标记为锁定
                GridNumber[rowindex, columnindex] = value;
                GridLocked[rowindex, columnindex] = true;

                //执行一次解谜查看答案是否存在
                int answer = GetAnswer(userinterface);

                //不存在则重新进入本循环
                if (answer == 0)
                {
                    toregenerate = true;
                }

            } while (toregenerate);
        }

        //带UI的生成一个提示
        private static void GenerateOneHint(Sudoku toreturn, FunctionForm userinterface)
        {
            toreturn.GenerateOneHint(out int rowindex, out int columnindex, out int value, userinterface);
            userinterface.puzzlearray[rowindex, columnindex] = value;
            userinterface.puzzlerecord.Add(new short[9, 9]);
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    userinterface.puzzlerecord[userinterface.puzzlestepindex][row, column] = (short)userinterface.puzzlearray[row, column];
                }
            }
            userinterface.puzzlestepindex++;
        }

        //生成谜题
        public static void GeneratePuzzle(FunctionForm userinterface)
        {
            Sudoku Toreturn = new Sudoku();
            if (userinterface.CurrentAuto == AutoMode.SemiAuto)
            {
                Toreturn.AnswerCountToStop = 1;
                for (int hintscount = 0; hintscount < userinterface.targethints; hintscount++)
                {
                    GenerateOneHint(Toreturn, userinterface);
                    userinterface.SetDialogText("数独谜题生成中...（" + (hintscount + 1) + "） /" +
                        "\nSudoku puzzle generating...(" + (hintscount + 1) + ")");
                }
            }
            else
            {
                Toreturn.AnswerCountToStop = 2;
                int hintscount = 1;
                while (Toreturn.AnswerCount != 1)
                {
                    GenerateOneHint(Toreturn, userinterface);
                    userinterface.SetDialogText("数独谜题生成中...（" + hintscount + "） /" +
                        "\nSudoku puzzle generating...(" + hintscount + ")");
                    hintscount++;
                }
            }

            //触发完成按钮事件
            userinterface.ManualDoneButton_Click(userinterface.ManualDoneButton, new EventArgs());
        }

        //计算首个可填方格的坐标
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

        //计算最后可填方格的坐标
        private void FindLastFillable(out int lastrow, out int lastcolumn)
        {
            int currentrow = 8, currentcolumn = 8;
            while (GridLocked[currentrow, currentcolumn])
            {
                currentcolumn--;
                if (currentcolumn < 0)
                {
                    currentcolumn = 8;
                    currentrow--;
                }
            }
            lastrow = currentrow;
            lastcolumn = currentcolumn;

        }

        //计算下个可填方格的坐标
        private void FindNextFillable(int currentrow, int currentcolumn, out int nextrow, out int nextcolumn)
        {
            do
            {
                currentcolumn++;
                if (currentcolumn >= 9)
                {
                    currentcolumn = 0;
                    currentrow++;
                    if (currentrow >= 9)
                    {
                        currentrow = currentcolumn = -1;
                        break;
                    }
                }
            } while (GridLocked[currentrow, currentcolumn]);
            nextrow = currentrow;
            nextcolumn = currentcolumn;
        }

        //从头计算答案
        //声明二维数组List和整形变量以存放答案和答案数量
        public int AnswerCount = 0;
        public int AnswerCountToStop = -1;
        public int GetAnswer(FunctionForm userinterface)
        {
            triescount = 0;

            //清空可填方格、清零答案数、将新答案提示模式标记为询问
            if (userinterface.CurrentManual == ManualMode.Generate)
            {
                ClearGrid(false);
            }
            else
            {
                AnswerCountToStop = -1;
            }
            AnswerCount = 0;

            //寻找是否存在无答案方格，存在则直接返回无答案
            for (int rowindex = 0; rowindex < 9; rowindex++)
            {
                for (int columnindex = 0; columnindex < 9; columnindex++)
                {
                    if (!CheckExist(rowindex, columnindex))
                    {
                        return 0;
                    }
                }
            }

            //计算首个可填方格的坐标
            FindFirstFillable(out int firstrow, out int firstcolumn);

            //执行递归计算答案
            GetAnswer(firstrow, firstcolumn, userinterface);

            //递归结束
            if (triescount >= 20000000 && userinterface.CurrentManual == ManualMode.Generate)
            {
                AnswerCount = 0;
            }

            //UI显示报告

            //返回答案数
            int ToReturn = AnswerCount;
            return ToReturn;
        }

        //递归计算答案
        private void GetAnswer(int currentrow, int currentcolumn, FunctionForm userinterface)
        {
            //坐标超出数独范围则返回上一方格
            if (currentrow == -1 || currentcolumn == -1)
            {
                return;
            }

            //递归次数超时返回
            if (triescount >= 20000000 && userinterface.CurrentManual == ManualMode.Generate)
            {
                return;
            }

            //计算下个和最后可填方格的坐标
            FindNextFillable(currentrow, currentcolumn, out int nextrow, out int nextcolumn);
            FindLastFillable(out int lastrow, out int lastcolumn);

            for (int tryvalue = 1; tryvalue <= 9; tryvalue++)
            {
                triescount++;

                //跳过非法赋值，尝试下一数值
                if (!CheckRule(currentrow, currentcolumn, tryvalue, out int stuckrow, out int stuckcolumn))
                {
                    continue;
                }

                //记录下合法赋值
                GridNumber[currentrow, currentcolumn] = tryvalue;

                //尝试下一方格
                GetAnswer(nextrow, nextcolumn, userinterface);

                //最后可填方格合法赋值完成即谜题存在答案
                //UI显示答案
                if (currentrow == lastrow && currentcolumn == lastcolumn)
                {
                    //答案数自加
                    AnswerCount++;

                    //记录当前答案
                    if (userinterface.CurrentManual == ManualMode.Solve)
                    {
                        //在之前撤销过则重新作为最新步骤记录
                        if (userinterface.solvingrecord.Count > userinterface.solvingstepindex + 1)
                        {
                            userinterface.solvingrecord.RemoveRange(userinterface.solvingstepindex + 1, 
                                userinterface.solvingrecord.Count - userinterface.solvingstepindex - 1);
                            userinterface.solvingrecord.TrimExcess();
                        }

                        //答案写进UI的短整型数组中
                        userinterface.solvingrecord.Add(new short[9, 9]);
                        for (int rowindex = 0; rowindex < 9; rowindex++)
                        {
                            for (int columnindex = 0; columnindex < 9; columnindex++)
                            {
                                userinterface.solvingarray[rowindex, columnindex] = GridNumber[rowindex, columnindex];
                                userinterface.solvingrecord[userinterface.solvingstepindex][rowindex, columnindex]
                                    = (short)GridNumber[rowindex, columnindex];
                            }
                        }

                        //步骤计数器自加
                        userinterface.solvingstepindex++;
                    }

                    //检测指定的答案数是否为-2，是则计算整个谜题所有答案
                    if (AnswerCountToStop == -2)
                    {
                        //提示目前答案数
                        userinterface.SetDialogText("计算谜题答案中...（" + AnswerCount + "） /" +
                            "\nAnswers generating...(" + AnswerCount + ")");

                        //答案数过多时（超过100000），提示答案过多，继续计算会消耗大量系统资源和时间，询问是否继续
                        if (AnswerCount == 100000)
                        {
                            userinterface.SetAnswerButtonVisibility("WithoutYes");
                            userinterface.SetDialogText("答案数已超过100000，仍然继续？"
                                + "\nOver 100,000 answers. Still continue?");

                            //获取目前用户点击按钮
                            string buttonpress = userinterface.WaitAnswerButtonPressed();

                            //如果点击“×”按钮则终止目前谜题计算，并返回答案数
                            if (buttonpress == "No")
                            {
                                AnswerCountToStop = AnswerCount;
                                return;
                            }
                        }
                        continue;
                    }

                    //指定的答案数为-1时，每发现一个新答案询问用户是否继续
                    else if (AnswerCountToStop == -1)
                    {
                        //UI提示目前有新答案
                        userinterface.DisplayAnswer(this);

                        //UI询问用户
                        userinterface.SetAnswerButtonVisibility("WithYes");
                        userinterface.SetDialogText("有新答案，是否继续？" + "\nNew answer found. Continue?");

                        //获取目前用户点击按钮
                        string buttonpressed = userinterface.WaitAnswerButtonPressed();

                        //如果点击“×”按钮则终止目前谜题计算，并返回答案数
                        if (buttonpressed == "No")
                        {
                            AnswerCountToStop = AnswerCount;
                            return;
                        }

                        //如果点击“√√”按钮则一直计算到遍历所有可能，不再询问用户
                        else if (buttonpressed == "Endless")
                        {
                            AnswerCountToStop = -2;
                            continue;
                        }

                        //如果点击“√”按钮则继续计算，发现下一个新答案时仍然询问用户
                        else
                        {
                            userinterface.SetDialogText("计算谜题答案中...（" + AnswerCount + "） /" +
                                "\nAnswers generating...(" + AnswerCount + ")");
                        }
                    }

                    //检测答案数是否到达指定的答案数，是则退出返回
                    else if (AnswerCount == AnswerCountToStop)
                    {
                        return;
                    }
                }

                //答案数达到指定答案数直接返回
                if (AnswerCount == AnswerCountToStop)
                {
                    return;
                }
            }

            //尝试完9个数值，此方格不存在数值
            //清除此方格数字后返回上一方格
            GridNumber[currentrow, currentcolumn] = 0;
        }

        public void ClearGrid(bool isclearlocked)
        {
            for (int rowindex = 0; rowindex < 9; rowindex++)
            {
                for (int columnindex = 0; columnindex < 9; columnindex++)
                {
                    if(GridLocked[rowindex, columnindex] && !isclearlocked)
                    {
                        continue;
                    }
                    GridNumber[rowindex, columnindex] = 0;
                }
            }
        }
    }

    public enum ManualMode { Generate, Solve };
    public enum AutoMode { SemiAuto, Auto }
}
