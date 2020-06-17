using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //treeView1.ExpandAll();  // 모든 트리 노드 확장(펼쳐져있음)
            treeView1.CollapseAll();  // 모든 트리 노드를 축소
            // 두개를 동시에 쓰는건 의미없는 짓이다.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Nodes.Add(new TreeNode(textBox1.Text, 2, 2));
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("노드추가할 이름을 넣고, 추가할 위치의 폴더를 선택하세요.");
                // 아무것도 안넣고 추가버튼누르면 출력
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && treeView1.SelectedNode != null)
            {
                treeView1.Nodes.Add(new TreeNode(textBox1.Text, 0, 1));
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("노드추가할 이름을 입력");
            }
        }
    }
}
