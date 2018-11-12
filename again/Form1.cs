using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace again
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btn = new Button();

        btn.DialogResult = DialogResult.OK;//설정
            btn.Text = "확인";
            btn.Size = new Size(50, 50);//(x,y)
        btn.Location = new Point(30,30);//시작점 위치이동

        Controls.Add(btn);
            btn.Click += btn_click;  //넣다 / 클릭했을때의 이벤트를
        }

        private  void btn_click(object o, EventArgs a)
        {
            MessageBox.Show("확인");
        }
    }
}
