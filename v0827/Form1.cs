﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0827
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Left += vx;
            label1.Top += vx;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // 2次元クラスPoint型の変数mpを宣言
            Point mp = MousePosition;

            // mpに、マウスのフォーム座標を取り出す。
            //// MousePositionにマウス座標のスクリーン左上からのX、Yが入っている。
            //// PointToClient()を使うと、スクリーン座標を、フォーム座標に変換できる。
            mp = PointToClient(mp);

            // ラベルに座標を表示
            //// 変換したフォーム座標は、mp.X、mp.Yで取り出せる。
            label2.Text = "" + mp.X + "," + mp.Y;
        }
    }
}
