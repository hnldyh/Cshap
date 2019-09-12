using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace 检测网关不通就关机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //窗体隐藏，任务栏显示图标
            if (button1.Text == "停止运行")
                this.Close();
            this.button1.Text = "停止运行";
            this.Hide();
            this.notifyIcon1.Visible = true;

            Ping ping = new Ping();
            PingReply pingReply;
            string status;
            int time = Convert.ToInt32(TimeBox.Text)*1000;

            for (int i=1; i!=0; i++)
            {
                i = 1;
                pingReply = ping.Send(IPBox.Text);
                status = Convert.ToString(pingReply.Status);
                //MessageBox.Show(status);
                if (status == "Success")
                {
                     void Delay(int Millisecond) //延迟系统时间，但系统又能同时能执行其它任务；
                    {
                        DateTime current = DateTime.Now;
                        //MessageBox.Show(Convert.ToString(current));
                        while (current.AddMilliseconds(Millisecond) > DateTime.Now)
                        {
                            //MessageBox.Show(Convert.ToString(current.AddMilliseconds(Millisecond)));
                            Application.DoEvents();//转让控制权            
                        }
                        return;
                    }
                    //MessageBox.Show(time/1000+"秒后开始下次扫描");
                    Delay(time);
                    

                }
                else
                {

                    System.Diagnostics.Process.Start("shutdown.exe", " -s -t 60");
                    MessageBox.Show("网关找不到，一分钟后关机");


                    if (MessageBox.Show("是否取消关机", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                       System.Diagnostics.Process.Start("shutdown.exe", " -a");
                        MessageBox.Show("取消关机");
                        this.Visible = true;                        //窗体可见  
                        this.WindowState = FormWindowState.Normal;  //窗体默认大小  
                        this.notifyIcon1.Visible = true;            //设置图标可见  
                        break;
                    }
                    else
                    {
                        MessageBox.Show("继续关机");
                        this.Visible = true;                        //窗体可见  
                        this.WindowState = FormWindowState.Normal;  //窗体默认大小  
                        this.notifyIcon1.Visible = true;            //设置图标可见  
                        break;
                        
                    }

                }

                

            }
            
        }

        private void NotifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;                        //窗体可见  
            this.WindowState = FormWindowState.Normal;  //窗体默认大小  
            this.notifyIcon1.Visible = true;            //设置图标可见  
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;                        //窗体可见  
            this.WindowState = FormWindowState.Normal;  //窗体默认大小  
            this.notifyIcon1.Visible = true;            //设置图标可见  
        }

        private void 显示程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;                        //窗体可见  
            this.WindowState = FormWindowState.Normal;  //窗体默认大小  
            this.notifyIcon1.Visible = true;            //设置图标可见  
        }

        private void 隐藏程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.notifyIcon1.Visible = true;
        }

        private void 关闭程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
