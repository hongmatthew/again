using System;
using System.Collections;
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
                Load += Form1_Load; // Form 실행 시 기본적으로 실행될 내용 호출
        }

        private Button btn;
        private Label lb;

        private void Form1_Load(object sender, EventArgs e)
        {
            // 가상 데이터 생성
            ArrayList arrList = new ArrayList();
            arrList.Add(new Item("button", 30, 30, "btn_1"));
            arrList.Add(new Item("label", 30, 110, "lb_1"));
            arrList.Add(new Item("button", 30, 190, "btn_2"));

            for (int i = 0; i < arrList.Count; i++) // 가상 데이터를 이용한 화면 구성하기
            {
                Control ctr = Control_Create((Item)arrList[i]); // 구성될 각 화면 내용 받아오기
                Controls.Add(ctr); // 받아온 Control 정보를 이용하여 화면 구성하기
            }

            /* 1차원 배열로 화면 구성하기
            string[] ctrList = {"button","label","button"};

            for (int i = 0; i < ctrList.Length; i++)
            {
                if (ctrList[i] == "button")
                {
                    Controls.Add(btn_create(i));
                }
                else if (ctrList[i] == "label")
                {
                    Controls.Add(lb_create(i));
                }
            }
            */
        }

        private Control Control_Create(Item item)
        {
            Control ctr = new Control(); // 리턴 객체 만들기

            switch (item.getType())
            {
                case "button": // button 부분 정의 하기
                    Button btn = new Button();
                    btn.DialogResult = DialogResult.OK;
                    btn.Cursor = Cursors.Hand;
                    btn.Click += btn_click;
                    ctr = btn; // button 객체를 리턴 객체에 변경하기
                    break;
                case "label":
                    Label lb = new Label();
                    ctr = lb; // label 객체를 리턴 객체에 변경하기
                    break;
                default:
                    break;
            }
            // 리턴 객체에 공동으로 적용할 속성 정의하기
            ctr.Name = item.getTxt();
            ctr.Text = item.getTxt();
            ctr.Size = new Size(100, 50);
            ctr.Location = new Point(item.getX(), item.getY());

            return ctr; // 정의 한 Control 보내기
        }

        private Button btn_create(int i) // button 객체 정의하기
        {
            btn = new Button();
            btn.DialogResult = DialogResult.OK;
            btn.Name = string.Format("btn_{0}", (i + 1));
            btn.Text = string.Format("확인 : {0}", (i + 1));
            btn.Size = new Size(100, 50);
            btn.Location = new Point((100 * i) + 30, 30);
            btn.Cursor = Cursors.Hand;
            btn.Click += btn_click;
            return btn;
        }

        private Label lb_create(int i) // label 객체 정의하기
        {
            lb = new Label();
            lb.Name = string.Format("lb_{0}", (i + 1));
            lb.Text = string.Format("확인 : {0}", (i + 1));
            lb.Size = new Size(100, 50);
            lb.Location = new Point((100 * i) + 30, 30);
            return lb;
        }

        private void btn_click(object o, EventArgs a)
        {

            // string names = "";
            foreach (Control ct in Controls)
            {
                // names += ct.Name + " ";
                if (ct.Name != "btn_3") ct.BackColor = Color.Silver;
            }
            // MessageBox.Show(names);

            btn = (Button)o;
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
            */
        }
    }

    public class Item // Control 객체 생성 시 필요한 속성 정보 담을 객체 생성
    {
        private string type;
        private int x;
        private int y;
        private string txt;
        public Item(string type, int x, int y, string txt)
        {
            this.type = type;
            this.x = x;
            this.y = y;
            this.txt = txt;
        }
        public string getType()
        {
            return type;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public string getTxt()
        {
            return txt;
        }
        }
 }
