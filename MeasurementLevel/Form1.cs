/***************************************************************
 * @Author:Ahmiao
 * @date:2018/6/10
 * Describe:
 * A simple leveling measurement promgram
 *In the surveying and mapping,
 * we ofen use level data to caculation.
 * in this promgram,I use table to storage  data
 *  
 ****************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeasurementLevel
{
    public partial class Form1 : Form
    {
        public int id = 0;//input the unkown poit numble as global variable
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// table
        /// </summary>
        /// <returns></returns>
        private DataTable ShowTable()
        {
            //init table
            DataTable mydt = new DataTable();
            mydt.Columns.Add("id", Type.GetType("System.String"));
            mydt.Columns.Add("点号", Type.GetType("System.String"));
            mydt.Columns.Add("距离（km）", Type.GetType("System.String"));
            mydt.Columns.Add("测得高差（m）", Type.GetType("System.String"));
            mydt.Columns.Add("高差改正（mm）", Type.GetType("System.String"));
            mydt.Columns.Add("改正后高差（m）", Type.GetType("System.String"));
            mydt.Columns.Add("高程（m）", Type.GetType("System.String"));
            for (int myr = 0; myr <= id+1 ; myr++)
            {
                mydt.Rows.Add(myr + 1);
            }
            return mydt;

        }
        /// <summary>
        /// input the numble and display the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Input_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt16(pointNum.Text);
                if (id <= 0)
                    return;//if point num <=0,Jump out function
                dtView.DataSource = ShowTable();
                dtView.Rows[0].Cells[6].Style.BackColor = Color.LightCyan;
                dtView.Rows[id+1].Cells[6].Style.BackColor = Color.LightCyan;
                for(int i=1;i<=id+1;i++)
               {
                    dtView.Rows[i].Cells[2].Style.BackColor = Color.LightCyan;
                    dtView.Rows[i].Cells[3].Style.BackColor = Color.LightCyan;
                    dtView.Rows[i].Cells[4].Style.BackColor = Color.DeepPink;
                    dtView.Rows[i].Cells[5].Style.BackColor = Color.DeepPink;
                }
                for (int i = 0; i <= id + 1; i++)
                {
                    dtView.Rows[i].Cells[1].Style.BackColor = Color.LightCyan;
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show("请输入正确的未知点个数");
            }
           
        }
        /// <summary>
        /// caculate data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cal_Click(object sender, EventArgs e)
        {
            double Ha, Hb;
            Ha = Convert.ToDouble(dtView.Rows[0].Cells[6].Value);//Starting elevation
            Hb = Convert.ToDouble(dtView.Rows[id].Cells[6].Value);//Ending elevation
            double[] dis = new double[id+1];

        }
    }
}
