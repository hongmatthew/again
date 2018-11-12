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

        private Button btn;

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                Button btn = new Button();

                btn.DialogResult = DialogResult.OK;//설정
                btn.Text = string.Format("확인: {0}",(i+1));
                btn.Size = new Size(100, 50);//(x,y)
                btn.Location = new Point((100 * i) + 30, 30);//시작점 위치이동
                btn.Cursor = Cursors.Hand;//커서모양 변경 cursor - 속성부분을 알수록 활용 넓어짐 MSDN싸이트 참고

                Controls.Add(btn);
                btn.Click += btn_click;  //넣다 / 클릭했을때의 이벤트를
            }
        }

        private  void btn_click(object o, EventArgs a)//버튼에 대한 정보를 받아온다 boject
        {
            btn = (Button) o;
            btn.BackColor = (btn.BackColor == Color.Green) ? btn.BackColor = Color.Silver : btn.BackColor = Color.Green;

            /*
            if (btn.BackColor == Color.Green)
            {
                btn.BackColor = Color.Silver;
            }
            else
            {
                btn.BackColor = Color.Green;
            }
            btn.BackColor = Color.Green;
            */
        }
    }
}
