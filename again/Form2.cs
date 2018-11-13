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
    public partial class Form2 : Form
    {
        public Form2()
        {               //객체 사용방법!
            InitializeComponent();
            Load += Form2_Load1;
        }

        private void Form2_Load1(object sender, EventArgs e)
        {
       
            ListView listView1 = new ListView();

            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            // listView1.Columns.AddRange(new ColumnHeader[] {columnHeader1,columnHeader2,columnHeader3});
            listView1.Columns.Add(columnHeader1);
            listView1.Columns.Add(columnHeader3);
            listView1.Columns.Add(columnHeader2);

            columnHeader1.Text = "Column 1";
            columnHeader1.Width = 100;
            columnHeader1.TextAlign = HorizontalAlignment.Center;

            columnHeader2.Text = "Column 2";
            columnHeader2.Width = 150;
            columnHeader2.TextAlign = HorizontalAlignment.Left;

            columnHeader3.Text = "Column 3";
            columnHeader3.Width = 200;
            columnHeader3.TextAlign = HorizontalAlignment.Right;

            /*
            listView1.Columns.Add("Column 1", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Column 2", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 3", 200, HorizontalAlignment.Right);
            */

            listView1.GridLines = true;
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 426);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;

            Controls.Add(listView1);

            /*
            ListViewItem item1 = new ListViewItem("item1");
            item1.SubItems.Add("1");
            item1.SubItems.Add("2");
            ListViewItem item2 = new ListViewItem("item2");
            item2.SubItems.Add("4");
            item2.SubItems.Add("5");
            ListViewItem item3 = new ListViewItem("item3");
            item3.SubItems.Add("7");
            item3.SubItems.Add("8");

            // listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });
            listView1.Items.Add(item1);
            listView1.Items.Add(item2);
            listView1.Items.Add(item3);
            */

            // 가상 데이터 생성
            ArrayList arry = new ArrayList();
            arry.Add(new Items(new string[] { "item1", "1", "2" }));
            arry.Add(new Items(new string[] { "item2", "4", "5" }));
            arry.Add(new Items(new string[] { "item3", "7", "8" }));

            // 리스트뷰 데이터 넣기
            ListViewItem item;
            for (int i = 0; i < arry.Count; i++)
            {
                Items row = (Items) arry[i];
                item = new ListViewItem(row.Col1);
                item.SubItems.Add(row.Col2);
                item.SubItems.Add(row.Col3);
                listView1.Items.Add(item);
            }

            string txts = "";
            foreach(ColumnHeader ch in listView1.Columns)
            {
                txts += ch.Text + " ";
            }
            MessageBox.Show(txts);
            
        }
    }

    public class Items
    {
        string col1;
        string col2;
        string col3;
        public Items(string[] a)
        {
            col1 = a[0];
            col2 = a[1];
            col3 = a[2];
        }
        public string Col1
        {
            get
            {
                return col1;
            }
        }
        public string Col2
        {
            get
            {
                return col2;
            }
        }
        public string Col3
        {
            get
            {
                return col3;
            }
        }
        /*
        public string getCol1()
        {
            return col1;
        }
        public string getCol2()
        {
            return col2;
        }
        public string getCol3()
        {
            return col3;
        }
        */
    }
}
