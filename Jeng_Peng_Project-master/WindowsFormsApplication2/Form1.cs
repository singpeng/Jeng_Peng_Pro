using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int i, T1, T2, EndL1, EndR1, EndL2, EndR2, EndL3, EndR3, EndL4, EndR4, EndL5, EndR5, EndL6, EndR6, EndL7, EndR7, EndL8, EndR8, LTB;
        int i1,i2,i3,ii4;
        
        public Form1(int ii4)
            
        {
            InitializeComponent();
            this.ii4 = ii4;
        }

        public Form1()
        {
            // TODO: Complete member initialization
            InitializeComponent();
        }

       


        private void Button1_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    TextBox1.Text = Button1.Text;
                    i = i + 1;
                    Button1.Visible = false;
                    EndL1 = 1;
                    ch();
                    break;
                case 1:
                    TextBox2.Text = Button1.Text;
                    i = i + 1;
                    Button1.Visible = false;
                    EndL2 = 1;
                    break;
                case 2:
                    TextBox3.Text = Button1.Text;
                    i = i + 1;
                    Button1.Visible = false;
                    EndL3 = 1;
                    break;
                case 3:
                    TextBox4.Text = Button1.Text;
                    i = i + 1;
                    Button1.Visible = false;
                    EndL4 = 1;
                    break;
                case 4:
                    TextBox5.Text = Button1.Text;
                    i = i + 1;
                    Button1.Visible = false;
                    EndL5 = 1;
                    break;
                case 5:
                    TextBox6.Text = Button1.Text;
                    i = i + 1;
                    Button1.Visible = false;
                    EndL6 = 1;
                    break;
                case 6:
                    TextBox7.Text = Button1.Text;
                    i = i + 1;
                    Button1.Visible = false;
                    EndL7 = 1;
                    break;
                case 7:
                    TextBox8.Text = Button1.Text;
                    i = i + 1;
                    Button1.Visible = false;
                    EndL8 = 1;
                    break;
                case 8:
                    ch2();
                    break;

            }
            if (T2 == i)
            {
                ch2();
                i = 8;
            }
        }

        private void ch()
        {
            if (T2 == 1)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = false;
                TextBox3.Visible = false;
                TextBox4.Visible = false;
                TextBox5.Visible = false;
                TextBox6.Visible = false;
                TextBox7.Visible = false;
                TextBox8.Visible = false;
            }
            else if (T2 == 2)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = false;
                TextBox4.Visible = false;
                TextBox5.Visible = false;
                TextBox6.Visible = false;
                TextBox7.Visible = false;
                TextBox8.Visible = false;
            }
            else if (T2 == 3)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = false;
                TextBox5.Visible = false;
                TextBox6.Visible = false;
                TextBox7.Visible = false;
                TextBox8.Visible = false;
            }
            else if (T2 == 4)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = false;
                TextBox6.Visible = false;
                TextBox7.Visible = false;
                TextBox8.Visible = false;
            }
            else if (T2 == 5)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = false;
                TextBox7.Visible = false;
                TextBox8.Visible = false;
            }
            else if (T2 == 6)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = false;
                TextBox8.Visible = false;
            }
            else if (T2 == 7)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = false;
            }
            else if (T2 == 8)
            {
                TextBox1.Visible = true;
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox8.Visible = true;
            }
        }
        private void ch2()
        {
            if (i == 8)
            {
                if (EndL1 == EndR1)
                {
                    if (EndL2 == EndR2)
                    {
                        if (EndL3 == EndR3)
                        {
                            if (EndL4 == EndR4)
                            {
                                if (EndL5 == EndR5)
                                {
                                    if (EndL6 == EndR6)
                                    {
                                        if (EndL7 == EndR7)
                                        {
                                            if (EndL8 == EndR8)
                                            {
                                                MessageBox.Show("ถูกแล้วครับ");
                                                LTB = LTB + 1;
                                                label1.Text = LTB.ToString();
                                                i = 0;
                                                T1 = T1 + 1;
                                                Datach();
                                                Level();
                                                Clea();
                                                //T();
                                                return;
                                                
                                            }
                                            else
                                            {
                                                MessageBox.Show("ผิดครับ");
                                                   // T();
                                                Clea();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("ผิดครับ");
                                           // T();
                                            Clea();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("ผิดครับ");
                                      //  T();
                                        Clea();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("ผิดครับ");
                                   // T();
                                    Clea();
                                }
                            }
                            else
                            {
                                MessageBox.Show("ผิดครับ");
                               // T();
                                Clea();
                            }
                        }
                        else
                        {
                            MessageBox.Show("ผิดครับ");
                            //T();
                            Clea();
                        }
                    }
                    else
                    {
                        MessageBox.Show("ผิดครับ");
                        //T();
                        Clea();
                    }
                }
                else
                {
                    MessageBox.Show("ผิดครับ");
                    //T();
                    Clea();
                }
            }
            else
            {
                MessageBox.Show("ผิดครับ");
              //  T();
                Clea();
            }
        }
        private void Datach()
        {
            switch (T1)
            {
                case 0:
                    EndR1 = 1;
                    EndR2 = 3;
                    EndR3 = 0;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 2;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._1;
                    Button1.Text = "ลึก";
                    Button2.Text = "สุดๆ";
                    Button3.Text = "ลับ";
                    Button4.Text = "แ";
                    Button5.Text = "มาก";
                    Button6.Text = "ค๋ะ";
                    Button7.Text = "ก";
                    Button8.Text = "กระ";
                    Button9.Text = "ทะ";
                    Button10.Text = "น้ำ";
                    Button11.Text = "ดำ";
                    Button12.Text = "ปลา";
                    break;
                case 1:
                    EndR1 = 7;
                    EndR2 = 11;
                    EndR3 = 0;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 2;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._11;
                    Button1.Text = "มี";
                    Button2.Text = "หา";
                    Button3.Text = "ลับ";
                    Button4.Text = "แ";
                    Button5.Text = "มาก";
                    Button6.Text = "ค๋ะ";
                    Button7.Text = "แม่";
                    Button8.Text = "กระ";
                    Button9.Text = "ทะ";
                    Button10.Text = "น้ำ";
                    Button11.Text = "ทับ";
                    Button12.Text = "นั้ง";
                    break;
                case 2:
                    EndR1 = 1;
                    EndR2 = 10;
                    EndR3 = 7;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 3;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._12;
                    Button1.Text = "เดือ";
                    Button2.Text = "หา";
                    Button3.Text = "ลับ";
                    Button4.Text = "แ";
                    Button5.Text = "มาก";
                    Button6.Text = "ค๋ะ";
                    Button7.Text = "หงาย";
                    Button8.Text = "กระ";
                    Button9.Text = "ทะ";
                    Button10.Text = "น";
                    Button11.Text = "ทับ";
                    Button12.Text = "นั้ง";
                    break;
                case 3:
                    EndR1 = 1;
                    EndR2 = 12;
                    EndR3 = 0;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 2;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._13;
                    Button1.Text = "คลุม";
                    Button2.Text = "กล้วย";
                    Button3.Text = "ลับ";
                    Button4.Text = "หมู";
                    Button5.Text = "คน";
                    Button6.Text = "ค๋ะ";
                    Button7.Text = "หงาย";
                    Button8.Text = "กระ";
                    Button9.Text = "เล่น";
                    Button10.Text = "หญิง";
                    Button11.Text = "ชาย";
                    Button12.Text = "เครือ";
                    break;
                case 4:
                    EndR1 = 8;
                    EndR2 = 2;
                    EndR3 = 0;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 2;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._14;
                    Button1.Text = "คลุม";
                    Button2.Text = "คัน";
                    Button3.Text = "ลับ";
                    Button4.Text = "หมู";
                    Button5.Text = "คน";
                    Button6.Text = "ค๋ะ";
                    Button7.Text = "หงาย";
                    Button8.Text = "กลาง";
                    Button9.Text = "เล่น";
                    Button10.Text = "หญิง";
                    Button11.Text = "ชาย";
                    Button12.Text = "เครือ";
                    break;
                case 5:
                    EndR1 = 6;
                    EndR2 = 12;
                    EndR3 = 0;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 2;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._15;
                    Button1.Text = "คลุม";
                    Button2.Text = "คัน";
                    Button3.Text = "ลับ";
                    Button4.Text = "หมู";
                    Button5.Text = "คน";
                    Button6.Text = "แอ";
                    Button7.Text = "หงาย";
                    Button8.Text = "กลาง";
                    Button9.Text = "เล่น";
                    Button10.Text = "หญิง";
                    Button11.Text = "ชาย";
                    Button12.Text = "อัด";
                    break;
                case 6:
                    EndR1 = 5;
                    EndR2 = 9;
                    EndR3 = 0;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 2;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._16;
                    Button1.Text = "คลุม";
                    Button2.Text = "คัน";
                    Button3.Text = "ลับ";
                    Button4.Text = "หมู";
                    Button5.Text = "แลก";
                    Button6.Text = "แอ";
                    Button7.Text = "หงาย";
                    Button8.Text = "กลาง";
                    Button9.Text = "หมัด";
                    Button10.Text = "หญิง";
                    Button11.Text = "ชาย";
                    Button12.Text = "อัด";
                    break;
                case 7:
                    EndR1 = 1;
                    EndR2 = 7;
                    EndR3 = 0;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 2;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._17;
                    Button1.Text = "โก";
                    Button2.Text = "คัน";
                    Button3.Text = "ลับ";
                    Button4.Text = "หมู";
                    Button5.Text = "แลก";
                    Button6.Text = "แอ";
                    Button7.Text = "หก";
                    Button8.Text = "กลาง";
                    Button9.Text = "หมัด";
                    Button10.Text = "หญิง";
                    Button11.Text = "ชาย";
                    Button12.Text = "อัด";
                    break;
                case 8:
                    EndR1 = 7;
                    EndR2 = 11;
                    EndR3 = 0;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 2;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._18;
                    Button1.Text = "โก";
                    Button2.Text = "คัน";
                    Button3.Text = "ลับ";
                    Button4.Text = "หมู";
                    Button5.Text = "แลก";
                    Button6.Text = "แอ";
                    Button7.Text = "อิด";
                    Button8.Text = "กลาง";
                    Button9.Text = "หมัด";
                    Button10.Text = "หญิง";
                    Button11.Text = "โรย";
                    Button12.Text = "อัด";
                    break;
                case 9:
                    EndR1 = 4;
                    EndR2 = 10;
                    EndR3 = 0;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 2;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._19;
                    Button1.Text = "โก";
                    Button2.Text = "คัน";
                    Button3.Text = "ลับ";
                    Button4.Text = "กับ";
                    Button5.Text = "แลก";
                    Button6.Text = "แอ";
                    Button7.Text = "อิด";
                    Button8.Text = "กลาง";
                    Button9.Text = "หมัด";
                    Button10.Text = "ดัก";
                    Button11.Text = "โรย";
                    Button12.Text = "อัด";
                    break;
                case 10:
                    EndR1 = 1;
                    EndR2 = 6;
                    EndR3 = 9;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 3;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._21;
                    Button1.Text = "วง";
                    Button2.Text = "คัน";
                    Button3.Text = "ลับ";
                    Button4.Text = "กับ";
                    Button5.Text = "แลก";
                    Button6.Text = "ดน";
                    Button7.Text = "อิด";
                    Button8.Text = "กลาง";
                    Button9.Text = "ตรี";
                    Button10.Text = "ดัก";
                    Button11.Text = "กัน";
                    Button12.Text = "อัด";
                    break;
                case 11:
                    EndR1 = 2;
                    EndR2 = 4;
                    EndR3 = 8;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 3;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._22;
                    Button1.Text = "ตรี";
                    Button2.Text = "ใหม่";
                    Button3.Text = "ลับ";
                    Button4.Text = "แกะ";
                    Button5.Text = "แลก";
                    Button6.Text = "วง";
                    Button7.Text = "อิด";
                    Button8.Text = "กล่อง";
                    Button9.Text = "ดน";
                    Button10.Text = "ดัก";
                    Button11.Text = "โรย";
                    Button12.Text = "อัด";
                    break;
                case 12:
                    EndR1 = 8;
                    EndR2 = 5;
                    EndR3 = 3;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 3;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._23;
                    Button1.Text = "ตรี";
                    Button2.Text = "คัน";
                    Button3.Text = "ชู้";
                    Button4.Text = "กับ";
                    Button5.Text = "เจ้า";
                    Button6.Text = "วง";
                    Button7.Text = "อิด";
                    Button8.Text = "หญ้า";
                    Button9.Text = "ดน";
                    Button10.Text = "ดัก";
                    Button11.Text = "โรย";
                    Button12.Text = "อัด";
                    break;
                case 13:
                    EndR1 = 3;
                    EndR2 = 6;
                    EndR3 = 9;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 3;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._24;
                    Button1.Text = "ตรี";
                    Button2.Text = "คัน";
                    Button3.Text = "สัง";
                    Button4.Text = "กับ";
                    Button5.Text = "แลก";
                    Button6.Text = "กะ";
                    Button7.Text = "อิด";
                    Button8.Text = "กลาง";
                    Button9.Text = "สี";
                    Button10.Text = "ดัก";
                    Button11.Text = "โรย";
                    Button12.Text = "อัด";
                    break;
                case 14:
                    EndR1 = 2;
                    EndR2 = 3;
                    EndR3 = 6;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 3;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._25;
                    Button1.Text = "ตรี";
                    Button2.Text = "บัง";
                    Button3.Text = "กะ";
                    Button4.Text = "กับ";
                    Button5.Text = "แลก";
                    Button6.Text = "โล";
                    Button7.Text = "บัง";
                    Button8.Text = "กลาง";
                    Button9.Text = "สี";
                    Button10.Text = "ดัก";
                    Button11.Text = "โรย";
                    Button12.Text = "อัด";
                    break;
                case 15:
                    EndR1 = 5;
                    EndR2 = 7;
                    EndR3 = 12;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 3;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._26;
                    Button1.Text = "ตรี";
                    Button2.Text = "บัง";
                    Button3.Text = "กะ";
                    Button4.Text = "กับ";
                    Button5.Text = "ดัช";
                    Button6.Text = "โล";
                    Button7.Text = "ช";
                    Button8.Text = "กลาง";
                    Button9.Text = "สี";
                    Button10.Text = "ดัก";
                    Button11.Text = "โรย";
                    Button12.Text = "นี";
                    break;
                case 16:
                    EndR1 = 3;
                    EndR2 = 5;
                    EndR3 = 8;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 3;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._27;
                    Button1.Text = "ตรี";
                    Button2.Text = "บัง";
                    Button3.Text = "ลอย";
                    Button4.Text = "กับ";
                    Button5.Text = "อัง";
                    Button6.Text = "โล";
                    Button7.Text = "ช";
                    Button8.Text = "คาร";
                    Button9.Text = "สี";
                    Button10.Text = "ดัก";
                    Button11.Text = "โรย";
                    Button12.Text = "นี";
                    break;
                case 17:
                    EndR1 = 9;
                    EndR2 = 4;
                    EndR3 = 6;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 3;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._28;
                    Button1.Text = "ตรี";
                    Button2.Text = "บัง";
                    Button3.Text = "ลอย";
                    Button4.Text = "สอง";
                    Button5.Text = "อัง";
                    Button6.Text = "แถว";
                    Button7.Text = "ช";
                    Button8.Text = "คาร";
                    Button9.Text = "รถ";
                    Button10.Text = "ดัก";
                    Button11.Text = "โรย";
                    Button12.Text = "นี";
                    break;
                case 18:
                    EndR1 = 10;
                    EndR2 = 7;
                    EndR3 = 4;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 3;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._29;
                    Button1.Text = "ตรี";
                    Button2.Text = "บัง";
                    Button3.Text = "ลอย";
                    Button4.Text = "นก";
                    Button5.Text = "อัง";
                    Button6.Text = "แถว";
                    Button7.Text = "หวัด";
                    Button8.Text = "คาร";
                    Button9.Text = "รถ";
                    Button10.Text = "ไข้";
                    Button11.Text = "โรย";
                    Button12.Text = "นี";
                    break;
                case 19:
                    EndR1 = 3;
                    EndR2 = 6;
                    EndR3 = 9;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 3;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._30;
                    Button1.Text = "ตรี";
                    Button2.Text = "บัง";
                    Button3.Text = "บ";
                    Button4.Text = "นก";
                    Button5.Text = "อัง";
                    Button6.Text = "ข";
                    Button7.Text = "หวัด";
                    Button8.Text = "คาร";
                    Button9.Text = "ส";
                    Button10.Text = "ไข้";
                    Button11.Text = "โรย";
                    Button12.Text = "นี";
                    break;
                case 20:
                    EndR1 = 8;
                    EndR2 = 5;
                    EndR3 = 3;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 3;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._31;
                    Button1.Text = "ตรี";
                    Button2.Text = "บัง";
                    Button3.Text = "ไทย";
                    Button4.Text = "นก";
                    Button5.Text = "เทศ";
                    Button6.Text = "ข";
                    Button7.Text = "หวัด";
                    Button8.Text = "ประ";
                    Button9.Text = "ส";
                    Button10.Text = "ไข้";
                    Button11.Text = "โรย";
                    Button12.Text = "นี";
                    break;
                case 21:
                    EndR1 = 1;
                    EndR2 = 2;
                    EndR3 = 5;
                    EndR4 = 4;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 4;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._32;
                    Button1.Text = "ตั๊ก";
                    Button2.Text = "แตน";
                    Button3.Text = "ไทย";
                    Button4.Text = "โบว์";
                    Button5.Text = "ผูก";
                    Button6.Text = "ข";
                    Button7.Text = "ผูก";
                    Button8.Text = "ประ";
                    Button9.Text = "โบว์";
                    Button10.Text = "ไข้";
                    Button11.Text = "โรย";
                    Button12.Text = "นี";
                    break;
                case 22:
                    EndR1 = 5;
                    EndR2 = 7;
                    EndR3 = 9;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 3;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._33;
                    Button1.Text = "ตรี";
                    Button2.Text = "บัง";
                    Button3.Text = "ไทย";
                    Button4.Text = "ตั๊ก";
                    Button5.Text = "แอน";
                    Button6.Text = "ข";
                    Button7.Text = "ตา";
                    Button8.Text = "ประ";
                    Button9.Text = "ซิน";
                    Button10.Text = "ไข้";
                    Button11.Text = "โรย";
                    Button12.Text = "นี";
                    break;
                case 23:
                    EndR1 = 5;
                    EndR2 = 7;
                    EndR3 = 3;
                    EndR4 = 9;
                    EndR5 = 11;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 5;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._34;
                    Button1.Text = "ตรี";
                    Button2.Text = "บัง";
                    Button3.Text = "แม่";
                    Button4.Text = "ตั๊ก";
                    Button5.Text = "ไก่";
                    Button6.Text = "ข";
                    Button7.Text = "แก่";
                    Button8.Text = "ประ";
                    Button9.Text = "ปลา";
                    Button10.Text = "ไข้";
                    Button11.Text = "ช่อน";
                    Button12.Text = "นี";
                    break;
                case 24:
                    EndR1 = 3;
                    EndR2 = 5;
                    EndR3 = 7;
                    EndR4 = 9;
                    EndR5 = 11;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 5;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._35;
                    Button1.Text = "ตรี";
                    Button2.Text = "บัง";
                    Button3.Text = "ขนม";
                    Button4.Text = "ตั๊ก";
                    Button5.Text = "จีบ";
                    Button6.Text = "ข";
                    Button7.Text = "ซา";
                    Button8.Text = "ประ";
                    Button9.Text = "ลา";
                    Button10.Text = "ไข้";
                    Button11.Text = "เปา";
                    Button12.Text = "นี";
                    break;
                case 25:
                    EndR1 = 1;
                    EndR2 = 3;
                    EndR3 = 5;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 3;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._36;
                    Button1.Text = "หน่อ";
                    Button2.Text = "บัง";
                    Button3.Text = "ไม้";
                    Button4.Text = "ตั๊ก";
                    Button5.Text = "ฝรั่ง";
                    Button6.Text = "ข";
                    Button7.Text = "ซา";
                    Button8.Text = "ประ";
                    Button9.Text = "ลา";
                    Button10.Text = "ไข้";
                    Button11.Text = "เปา";
                    Button12.Text = "นี";
                    break;
                case 26:
                    EndR1 = 3;
                    EndR2 = 6;
                    EndR3 = 0;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 2;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._37;
                    Button1.Text = "หน่อ";
                    Button2.Text = "บัง";
                    Button3.Text = "มหา";
                    Button4.Text = "ตั๊ก";
                    Button5.Text = "ฝรั่ง";
                    Button6.Text = "สนุก";
                    Button7.Text = "ซา";
                    Button8.Text = "ประ";
                    Button9.Text = "ลา";
                    Button10.Text = "ไข้";
                    Button11.Text = "เปา";
                    Button12.Text = "นี";
                    break;
                case 27:
                    EndR1 = 6;
                    EndR2 = 8;
                    EndR3 = 0;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 2;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._38;
                    Button1.Text = "หน่อ";
                    Button2.Text = "บัง";
                    Button3.Text = "มหา";
                    Button4.Text = "ตั๊ก";
                    Button5.Text = "ฝรั่ง";
                    Button6.Text = "ลาย";
                    Button7.Text = "ซา";
                    Button8.Text = "ลักษ์";
                    Button9.Text = "ลา";
                    Button10.Text = "ไข้";
                    Button11.Text = "เปา";
                    Button12.Text = "นี";
                    break;
                case 28:
                    EndR1 = 1;
                    EndR2 = 2;
                    EndR3 = 3;
                    EndR4 = 4;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 4;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._39;
                    Button1.Text = "คาบ";
                    Button2.Text = "ลูก";
                    Button3.Text = "คาบ";
                    Button4.Text = "ดอก";
                    Button5.Text = "ฝรั่ง";
                    Button6.Text = "ลาย";
                    Button7.Text = "ซา";
                    Button8.Text = "ลักษ์";
                    Button9.Text = "ลา";
                    Button10.Text = "ไข้";
                    Button11.Text = "เปา";
                    Button12.Text = "นี";
                    break;
                case 29:
                    EndR1 = 5;
                    EndR2 = 8;
                    EndR3 = 0;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 2;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._40;
                    Button1.Text = "คาบ";
                    Button2.Text = "ลูก";
                    Button3.Text = "คาบ";
                    Button4.Text = "ดอก";
                    Button5.Text = "เหล็ก";
                    Button6.Text = "ลาย";
                    Button7.Text = "ซา";
                    Button8.Text = "กล้า";
                    Button9.Text = "ลา";
                    Button10.Text = "ไข้";
                    Button11.Text = "เปา";
                    Button12.Text = "นี";
                    break;
                case 30:
                    EndR1 = 3;
                    EndR2 = 4;
                    EndR3 = 5;
                    EndR4 = 6;
                    EndR5 = 8;
                    EndR6 = 7;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 6;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._41;
                    Button1.Text = "คาบ";
                    Button2.Text = "ลูก";
                    Button3.Text = "แปด";
                    Button4.Text = "เหลี่";
                    Button5.Text = "ยม";
                    Button6.Text = "สิบ";
                    Button7.Text = "คม";
                    Button8.Text = "สอง";
                    Button9.Text = "ลา";
                    Button10.Text = "ไข้";
                    Button11.Text = "เปา";
                    Button12.Text = "นี";
                    break;
                case 31:
                    EndR1 = 3;
                    EndR2 = 5;
                    EndR3 = 7;
                    EndR4 = 0;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 3;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._42;
                    Button1.Text = "คาบ";
                    Button2.Text = "ลูก";
                    Button3.Text = "เขต";
                    Button4.Text = "เหลี่";
                    Button5.Text = "หลัก";
                    Button6.Text = "สิบ";
                    Button7.Text = "สี่";
                    Button8.Text = "สอง";
                    Button9.Text = "ลา";
                    Button10.Text = "ไข้";
                    Button11.Text = "เปา";
                    Button12.Text = "นี";
                    break;
                case 32:
                    EndR1 = 5;
                    EndR2 = 7;
                    EndR3 = 2;
                    EndR4 = 8;
                    EndR5 = 0;
                    EndR6 = 0;
                    EndR7 = 0;
                    EndR8 = 0;
                    T2 = 4;
                    ch();
                    PictureBox1.BackgroundImage = WindowsFormsApplication1.Properties.Resources._43;
                    Button1.Text = "คาบ";
                    Button2.Text = "ขอ";
                    Button3.Text = "เขต";
                    Button4.Text = "เหลี่";
                    Button5.Text = "คุณ";
                    Button6.Text = "สิบ";
                    Button7.Text = "แม่";
                    Button8.Text = "ร้อง";
                    Button9.Text = "ลา";
                    Button10.Text = "ไข้";
                    Button11.Text = "เปา";
                    Button12.Text = "นี";
                    break;
            }
            if (T1 > 32)
            {
                send();
            }
        }





        private void Button13_Click(object sender, EventArgs e)
        {
            Clea();
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {
          // T1 = 33;
            Datach();
            T1 = 0;
            timer1.Enabled = true;
            if (ii4 == 1)
            {
                Close();
            }
            else
            {
                Refresh();
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    TextBox1.Text = Button3.Text;
                    i = i + 1;
                    Button3.Visible = false;
                    EndL1 = 3;
                    ch();
                    break;
                case 1:
                    TextBox2.Text = Button3.Text;
                    i = i + 1;
                    Button3.Visible = false;
                    EndL2 = 3;
                    break;
                case 2:
                    TextBox3.Text = Button3.Text;
                    i = i + 1;
                    Button3.Visible = false;
                    EndL3 = 3;
                    break;
                case 3:
                    TextBox4.Text = Button3.Text;
                    i = i + 1;
                    Button3.Visible = false;
                    EndL4 = 3;
                    break;
                case 4:
                    TextBox5.Text = Button3.Text;
                    i = i + 1;
                    Button3.Visible = false;
                    EndL5 = 3;
                    break;
                case 5:
                    TextBox6.Text = Button3.Text;
                    i = i + 1;
                    Button3.Visible = false;
                    EndL6 = 3;
                    break;
                case 6:
                    TextBox7.Text = Button3.Text;
                    i = i + 1;
                    Button3.Visible = false;
                    EndL7 = 3;
                    break;
                case 7:
                    TextBox8.Text = Button3.Text;
                    i = i + 1;
                    Button3.Visible = false;
                    EndL8 = 3;
                    break;
                case 8:
                    ch2();
                    break;

            }
            if (T2 == i)
            {
                i = 8;
                ch2();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    TextBox1.Text = Button2.Text;
                    i = i + 1;
                    Button2.Visible = false;
                    EndL1 = 2;
                    ch();
                    break;
                case 1:
                    TextBox2.Text = Button2.Text;
                    i = i + 1;
                    Button2.Visible = false;
                    EndL2 = 2;
                    break;
                case 2:
                    TextBox3.Text = Button2.Text;
                    i = i + 1;
                    Button2.Visible = false;
                    EndL3 = 2;
                    break;
                case 3:
                    TextBox4.Text = Button2.Text;
                    i = i + 1;
                    Button2.Visible = false;
                    EndL4 = 2;
                    break;
                case 4:
                    TextBox5.Text = Button2.Text;
                    i = i + 1;
                    Button2.Visible = false;
                    EndL5 = 2;
                    break;
                case 5:
                    TextBox6.Text = Button2.Text;
                    i = i + 1;
                    Button2.Visible = false;
                    EndL6 = 2;
                    break;
                case 6:
                    TextBox7.Text = Button2.Text;
                    i = i + 1;
                    Button2.Visible = false;
                    EndL7 = 2;
                    break;
                case 7:
                    TextBox8.Text = Button2.Text;
                    i = i + 1;
                    Button2.Visible = false;
                    EndL8 = 2;
                    break;
                case 8:
                    ch2();
                    break;

            }
            if (T2 == i)
            {
                i = 8;
                ch2();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    TextBox1.Text = Button4.Text;
                    i = i + 1;
                    Button4.Visible = false;
                    EndL1 = 4;
                    ch();
                    break;
                case 1:
                    TextBox2.Text = Button4.Text;
                    i = i + 1;
                    Button4.Visible = false;
                    EndL2 = 4;
                    break;
                case 2:
                    TextBox3.Text = Button4.Text;
                    i = i + 1;
                    Button4.Visible = false;
                    EndL3 = 4;
                    break;
                case 3:
                    TextBox4.Text = Button4.Text;
                    i = i + 1;
                    Button4.Visible = false;
                    EndL4 = 4;
                    break;
                case 4:
                    TextBox5.Text = Button4.Text;
                    i = i + 1;
                    Button4.Visible = false;
                    EndL5 = 4;
                    break;
                case 5:
                    TextBox6.Text = Button4.Text;
                    i = i + 1;
                    Button4.Visible = false;
                    EndL6 = 4;
                    break;
                case 6:
                    TextBox7.Text = Button4.Text;
                    i = i + 1;
                    Button4.Visible = false;
                    EndL7 = 4;
                    break;
                case 7:
                    TextBox8.Text = Button4.Text;
                    i = i + 1;
                    Button4.Visible = false;
                    EndL8 = 4;
                    break;
                case 8:
                    ch2();
                    break;

            }
            if (T2 == i)
            {
                i = 8;
                ch2();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    TextBox1.Text = Button5.Text;
                    i = i + 1;
                    Button5.Visible = false;
                    EndL1 = 5;
                    ch();
                    break;
                case 1:
                    TextBox2.Text = Button5.Text;
                    i = i + 1;
                    Button5.Visible = false;
                    EndL2 = 5;
                    break;
                case 2:
                    TextBox3.Text = Button5.Text;
                    i = i + 1;
                    Button5.Visible = false;
                    EndL3 = 5;
                    break;
                case 3:
                    TextBox4.Text = Button5.Text;
                    i = i + 1;
                    Button5.Visible = false;
                    EndL4 = 5;
                    break;
                case 4:
                    TextBox5.Text = Button5.Text;
                    i = i + 1;
                    Button5.Visible = false;
                    EndL5 = 5;
                    break;
                case 5:
                    TextBox6.Text = Button5.Text;
                    i = i + 1;
                    Button5.Visible = false;
                    EndL6 = 5;
                    break;
                case 6:
                    TextBox7.Text = Button5.Text;
                    i = i + 1;
                    Button5.Visible = false;
                    EndL7 = 5;
                    break;
                case 7:
                    TextBox8.Text = Button5.Text;
                    i = i + 1;
                    Button5.Visible = false;
                    EndL8 = 5;
                    break;
                case 8:
                    ch2();
                    break;

            }
            if (T2 == i)
            {
                i = 8;
                ch2();
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    TextBox1.Text = Button6.Text;
                    i = i + 1;
                    Button6.Visible = false;
                    EndL1 = 6;
                    ch();
                    break;
                case 1:
                    TextBox2.Text = Button6.Text;
                    i = i + 1;
                    Button6.Visible = false;
                    EndL2 = 6;
                    break;
                case 2:
                    TextBox3.Text = Button6.Text;
                    i = i + 1;
                    Button6.Visible = false;
                    EndL3 = 6;
                    break;
                case 3:
                    TextBox4.Text = Button6.Text;
                    i = i + 1;
                    Button6.Visible = false;
                    EndL4 = 6;
                    break;
                case 4:
                    TextBox5.Text = Button6.Text;
                    i = i + 1;
                    Button6.Visible = false;
                    EndL5 = 6;
                    break;
                case 5:
                    TextBox6.Text = Button6.Text;
                    i = i + 1;
                    Button6.Visible = false;
                    EndL6 = 6;
                    break;
                case 6:
                    TextBox7.Text = Button6.Text;
                    i = i + 1;
                    Button6.Visible = false;
                    EndL7 = 6;
                    break;
                case 7:
                    TextBox8.Text = Button6.Text;
                    i = i + 1;
                    Button6.Visible = false;
                    EndL8 = 6;
                    break;
                case 8:
                    ch2();
                    break;

            }
            if (T2 == i)
            {
                i = 8;
                ch2();
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    TextBox1.Text = Button7.Text;
                    i = i + 1;
                    Button7.Visible = false;
                    EndL1 = 7;
                    ch();
                    break;
                case 1:
                    TextBox2.Text = Button7.Text;
                    i = i + 1;
                    Button7.Visible = false;
                    EndL2 = 7;
                    break;
                case 2:
                    TextBox3.Text = Button7.Text;
                    i = i + 1;
                    Button7.Visible = false;
                    EndL3 = 7;
                    break;
                case 3:
                    TextBox4.Text = Button7.Text;
                    i = i + 1;
                    Button7.Visible = false;
                    EndL4 = 7;
                    break;
                case 4:
                    TextBox5.Text = Button7.Text;
                    i = i + 1;
                    Button7.Visible = false;
                    EndL5 = 7;
                    break;
                case 5:
                    TextBox6.Text = Button7.Text;
                    i = i + 1;
                    Button7.Visible = false;
                    EndL6 = 7;
                    break;
                case 6:
                    TextBox7.Text = Button7.Text;
                    i = i + 1;
                    Button7.Visible = false;
                    EndL7 = 7;
                    break;
                case 7:
                    TextBox8.Text = Button7.Text;
                    i = i + 1;
                    Button7.Visible = false;
                    EndL8 = 7;
                    break;
                case 8:
                    ch2();
                    break;

            }
            if (T2 == i)
            {
                i = 8;
                ch2();
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    TextBox1.Text = Button8.Text;
                    i = i + 1;
                    Button8.Visible = false;
                    EndL1 = 8;
                    ch();
                    break;
                case 1:
                    TextBox2.Text = Button8.Text;
                    i = i + 1;
                    Button8.Visible = false;
                    EndL2 = 8;
                    break;
                case 2:
                    TextBox3.Text = Button8.Text;
                    i = i + 1;
                    Button8.Visible = false;
                    EndL3 = 8;
                    break;
                case 3:
                    TextBox4.Text = Button8.Text;
                    i = i + 1;
                    Button8.Visible = false;
                    EndL4 = 8;
                    break;
                case 4:
                    TextBox5.Text = Button8.Text;
                    i = i + 1;
                    Button8.Visible = false;
                    EndL5 = 8;
                    break;
                case 5:
                    TextBox6.Text = Button8.Text;
                    i = i + 1;
                    Button8.Visible = false;
                    EndL6 = 8;
                    break;
                case 6:
                    TextBox7.Text = Button8.Text;
                    i = i + 1;
                    Button8.Visible = false;
                    EndL7 = 8;
                    break;
                case 7:
                    TextBox8.Text = Button8.Text;
                    i = i + 1;
                    Button8.Visible = false;
                    EndL8 = 8;
                    break;
                case 8:
                    ch2();
                    break;

            }
            if (T2 == i)
            {
                i = 8;
                ch2();
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    TextBox1.Text = Button9.Text;
                    i = i + 1;
                    Button9.Visible = false;
                    EndL1 = 9;
                    ch();
                    break;
                case 1:
                    TextBox2.Text = Button9.Text;
                    i = i + 1;
                    Button9.Visible = false;
                    EndL2 = 9;
                    break;
                case 2:
                    TextBox3.Text = Button9.Text;
                    i = i + 1;
                    Button9.Visible = false;
                    EndL3 = 9;
                    break;
                case 3:
                    TextBox4.Text = Button9.Text;
                    i = i + 1;
                    Button9.Visible = false;
                    EndL4 = 9;
                    break;
                case 4:
                    TextBox5.Text = Button9.Text;
                    i = i + 1;
                    Button9.Visible = false;
                    EndL5 = 9;
                    break;
                case 5:
                    TextBox6.Text = Button9.Text;
                    i = i + 1;
                    Button9.Visible = false;
                    EndL6 = 9;
                    break;
                case 6:
                    TextBox7.Text = Button9.Text;
                    i = i + 1;
                    Button9.Visible = false;
                    EndL7 = 9;
                    break;
                case 7:
                    TextBox8.Text = Button9.Text;
                    i = i + 1;
                    Button9.Visible = false;
                    EndL8 = 9;
                    break;
                case 8:
                    ch2();
                    break;

            }
            if (T2 == i)
            {
                i = 8;
                ch2();
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    TextBox1.Text = Button10.Text;
                    i = i + 1;
                    Button10.Visible = false;
                    EndL1 = 10;
                    ch();
                    break;
                case 1:
                    TextBox2.Text = Button10.Text;
                    i = i + 1;
                    Button10.Visible = false;
                    EndL2 = 10;
                    break;
                case 2:
                    TextBox3.Text = Button10.Text;
                    i = i + 1;
                    Button10.Visible = false;
                    EndL3 = 10;
                    break;
                case 3:
                    TextBox4.Text = Button10.Text;
                    i = i + 1;
                    Button10.Visible = false;
                    EndL4 = 10;
                    break;
                case 4:
                    TextBox5.Text = Button10.Text;
                    i = i + 1;
                    Button10.Visible = false;
                    EndL5 = 10;
                    break;
                case 5:
                    TextBox6.Text = Button10.Text;
                    i = i + 1;
                    Button10.Visible = false;
                    EndL6 = 10;
                    break;
                case 6:
                    TextBox7.Text = Button10.Text;
                    i = i + 1;
                    Button10.Visible = false;
                    EndL7 = 10;
                    break;
                case 7:
                    TextBox8.Text = Button10.Text;
                    i = i + 1;
                    Button10.Visible = false;
                    EndL8 = 10;
                    break;
                case 8:
                    ch2();
                    break;

            }
            if (T2 == i)
            {
                i = 8;
                ch2();
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    TextBox1.Text = Button11.Text;
                    i = i + 1;
                    Button11.Visible = false;
                    EndL1 = 11;
                    ch();
                    break;
                case 1:
                    TextBox2.Text = Button11.Text;
                    i = i + 1;
                    Button11.Visible = false;
                    EndL2 = 11;
                    break;
                case 2:
                    TextBox3.Text = Button11.Text;
                    i = i + 1;
                    Button11.Visible = false;
                    EndL3 = 11;
                    break;
                case 3:
                    TextBox4.Text = Button11.Text;
                    i = i + 1;
                    Button11.Visible = false;
                    EndL4 = 11;
                    break;
                case 4:
                    TextBox5.Text = Button11.Text;
                    i = i + 1;
                    Button11.Visible = false;
                    EndL5 = 11;
                    break;
                case 5:
                    TextBox6.Text = Button11.Text;
                    i = i + 1;
                    Button11.Visible = false;
                    EndL6 = 11;
                    break;
                case 6:
                    TextBox7.Text = Button11.Text;
                    i = i + 1;
                    Button11.Visible = false;
                    EndL7 = 11;
                    break;
                case 7:
                    TextBox8.Text = Button11.Text;
                    i = i + 1;
                    Button11.Visible = false;
                    EndL8 = 11;
                    break;
                case 8:
                    ch2();
                    break;

            }
            if (T2 == i)
            {
                i = 8;
                ch2();
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    TextBox1.Text = Button12.Text;
                    i = i + 1;
                    Button12.Visible = false;
                    EndL1 = 12;
                    ch();
                    break;
                case 1:
                    TextBox2.Text = Button12.Text;
                    i = i + 1;
                    Button12.Visible = false;
                    EndL2 = 12;
                    break;
                case 2:
                    TextBox3.Text = Button12.Text;
                    i = i + 1;
                    Button12.Visible = false;
                    EndL3 = 12;
                    break;
                case 3:
                    TextBox4.Text = Button12.Text;
                    i = i + 1;
                    Button12.Visible = false;
                    EndL4 = 12;
                    break;
                case 4:
                    TextBox5.Text = Button12.Text;
                    i = i + 1;
                    Button12.Visible = false;
                    EndL5 = 12;
                    break;
                case 5:
                    TextBox6.Text = Button12.Text;
                    i = i + 1;
                    Button12.Visible = false;
                    EndL6 = 12;
                    break;
                case 6:
                    TextBox7.Text = Button12.Text;
                    i = i + 1;
                    Button12.Visible = false;
                    EndL7 = 12;
                    break;
                case 7:
                    TextBox8.Text = Button12.Text;
                    i = i + 1;
                    Button12.Visible = false;
                    EndL8 = 12;
                    break;
                case 8:
                    ch2();
                    break;

            }
            if (T2 == i)
            {
                i = 8;
                ch2();
            }
        }
        private void Clea()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            Button1.Visible = true;
            Button2.Visible = true;
            Button3.Visible = true;
            Button4.Visible = true;
            Button5.Visible = true;
            Button6.Visible = true;
            Button7.Visible = true;
            Button8.Visible = true;
            Button9.Visible = true;
            Button10.Visible = true;
            Button11.Visible = true;
            Button12.Visible = true;
            i = 0;
            EndL1 = 0;
            EndL2 = 0;
            EndL3 = 0;
            EndL4 = 0;
            EndL5 = 0;
            EndL6 = 0;
            EndL7 = 0;
            EndL8 = 0;
        }
        private void Level()
        {
            if (T1 <= 9)
            {
                label3.Text = "1";
            }
            else if (T1 <= 19)
            {
                label3.Text = "2";
            }
            else if (T1 <= 29)
            {
                label3.Text = "3";
            }
            else
            {
                label3.Text = "4";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (timer1.Interval == 1000)
            {
                i1 = i1+ 1;
                label4.Text = i1.ToString();
                
            }
             if (i1 == 60)
            {
                i2 = i2 + 1;
                label6.Text = i2.ToString();
                i1 = 00;
            }
             if (i2 == 60)
             {
                 i3 = i3 + 1;
                 label7.Text = i3.ToString();
                 i2 = 00;
             }
        }
        private void send ()
        {
            timer1.Enabled = false;
            Button1.Enabled = false;
            Button2.Enabled = false;
            Button3.Enabled = false;
            Button4.Enabled = false;
            Button5.Enabled = false;
            Button6.Enabled = false;
            Button7.Enabled = false;
            Button8.Enabled = false;
            Button9.Enabled = false;
            Button10.Enabled = false;
            Button11.Enabled = false;
            Button12.Enabled = false;

            
            Form2 frm2 = new Form2(this.label1.Text, this.label4.Text, this.label6.Text, this.label7.Text);
     
            frm2.ShowDialog();
            Close();
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
           
            send();
        }
        private void T()
        {
            label11.Text = EndR1.ToString();
            label12.Text = EndR2.ToString();
            label13.Text = EndR3.ToString();
            label14.Text = EndR4.ToString();
            label15.Text = EndR5.ToString();
            label16.Text = EndR6.ToString();
            label17.Text = EndR7.ToString();
            label18.Text = EndR8.ToString();
            label26.Text = EndL1.ToString();
            label25.Text = EndL2.ToString();
            label24.Text = EndL3.ToString();
            label23.Text = EndL4.ToString();
            label22.Text = EndL5.ToString();
            label21.Text = EndL6.ToString();
            label20.Text = EndL7.ToString();
            label19.Text = EndL8.ToString();
        }
    }
  
}
