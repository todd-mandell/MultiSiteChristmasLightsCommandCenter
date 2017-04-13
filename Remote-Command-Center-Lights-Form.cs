using System;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading;

namespace MultiSiteCommandModule
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

            RefreshRowOne.Click += new EventHandler(this.Refresh1_Click);
            Refresh2.Click += new EventHandler(this.Refresh2_Click);
            Refresh3.Click += new EventHandler(this.Refresh3_Click);
            Refresh4.Click += new EventHandler(this.Refresh4_Click);



            //new sh*t to refresh each button upon press
            button1.Click += new EventHandler(this.Refresh001_Click);
            button2.Click += new EventHandler(this.Refresh002_Click);
            button3.Click += new EventHandler(this.Refresh003_Click);
            button4.Click += new EventHandler(this.Refresh004_Click);
            button5.Click += new EventHandler(this.Refresh005_Click);
            button6.Click += new EventHandler(this.Refresh006_Click);
            button7.Click += new EventHandler(this.Refresh007_Click);
            button8.Click += new EventHandler(this.Refresh008_Click);
            button9.Click += new EventHandler(this.Refresh009_Click);
            button10.Click += new EventHandler(this.Refresh0010_Click);
            button11.Click += new EventHandler(this.Refresh0011_Click);
            button12.Click += new EventHandler(this.Refresh0012_Click);
            button13.Click += new EventHandler(this.Refresh0013_Click);
            button14.Click += new EventHandler(this.Refresh0014_Click);
            button15.Click += new EventHandler(this.Refresh0015_Click);
            button16.Click += new EventHandler(this.Refresh0016_Click);
            button17.Click += new EventHandler(this.Refresh0017_Click);
            button18.Click += new EventHandler(this.Refresh0018_Click);
            button19.Click += new EventHandler(this.Refresh0019_Click);
            button20.Click += new EventHandler(this.Refresh0020_Click);
            button21.Click += new EventHandler(this.Refresh0021_Click);
            button22.Click += new EventHandler(this.Refresh0022_Click);
            button23.Click += new EventHandler(this.Refresh0023_Click);
            button24.Click += new EventHandler(this.Refresh0024_Click);
            button25.Click += new EventHandler(this.Refresh0025_Click);
            button26.Click += new EventHandler(this.Refresh0026_Click);
            button27.Click += new EventHandler(this.Refresh0027_Click);
            button28.Click += new EventHandler(this.Refresh0028_Click);
            button29.Click += new EventHandler(this.Refresh0029_Click);
            button30.Click += new EventHandler(this.Refresh0030_Click);
            button31.Click += new EventHandler(this.Refresh0031_Click);
            button32.Click += new EventHandler(this.Refresh0032_Click);
            button33.Click += new EventHandler(this.Refresh0033_Click);
            button34.Click += new EventHandler(this.Refresh0034_Click);
            button35.Click += new EventHandler(this.Refresh0035_Click);
            button36.Click += new EventHandler(this.Refresh0036_Click);
            button37.Click += new EventHandler(this.Refresh0037_Click);
            button38.Click += new EventHandler(this.Refresh0038_Click);
            button39.Click += new EventHandler(this.Refresh0039_Click);
            button40.Click += new EventHandler(this.Refresh0040_Click);
            button41.Click += new EventHandler(this.Refresh0041_Click);
            button42.Click += new EventHandler(this.Refresh0042_Click);
            button43.Click += new EventHandler(this.Refresh0043_Click);
            button44.Click += new EventHandler(this.Refresh0044_Click);
            button45.Click += new EventHandler(this.Refresh0045_Click);
            button46.Click += new EventHandler(this.Refresh0046_Click);
            button47.Click += new EventHandler(this.Refresh0047_Click);
            button48.Click += new EventHandler(this.Refresh0048_Click);
            button49.Click += new EventHandler(this.Refresh0049_Click);
            button50.Click += new EventHandler(this.Refresh0050_Click);
            button51.Click += new EventHandler(this.Refresh0051_Click);
            button52.Click += new EventHandler(this.Refresh0052_Click);
            button53.Click += new EventHandler(this.Refresh0053_Click);
            button54.Click += new EventHandler(this.Refresh0054_Click);
            button55.Click += new EventHandler(this.Refresh0055_Click);
            button56.Click += new EventHandler(this.Refresh0056_Click);
            button57.Click += new EventHandler(this.Refresh0057_Click);
            button58.Click += new EventHandler(this.Refresh0058_Click);
            button59.Click += new EventHandler(this.Refresh0059_Click);
            button60.Click += new EventHandler(this.Refresh0060_Click);














        }

     
      
           
//parsamundo
        void Refresh1_Click(Object sender,
                       EventArgs e)
        {
            string FileName = "c:\\multisitelist.txt";
            string site1 = File.ReadLines(FileName).Skip(0).Take(1).First(); textBox1.Text = site1;
            string site2 = File.ReadLines(FileName).Skip(1).Take(1).First(); textBox2.Text = site2;
            string site3 = File.ReadLines(FileName).Skip(2).Take(1).First(); textBox3.Text = site3;
            string site4 = File.ReadLines(FileName).Skip(3).Take(1).First(); textBox4.Text = site4;
            string site5 = File.ReadLines(FileName).Skip(4).Take(1).First(); textBox5.Text = site5;
            string site6 = File.ReadLines(FileName).Skip(5).Take(1).First(); textBox6.Text = site6;
            string site7 = File.ReadLines(FileName).Skip(6).Take(1).First(); textBox7.Text = site7;
            string site8 = File.ReadLines(FileName).Skip(7).Take(1).First(); textBox8.Text = site8;
            string site9 = File.ReadLines(FileName).Skip(8).Take(1).First(); textBox9.Text = site9;
            string site10 = File.ReadLines(FileName).Skip(9).Take(1).First(); textBox10.Text = site10;
            string site11 = File.ReadLines(FileName).Skip(10).Take(1).First(); textBox11.Text = site11;
            string site12 = File.ReadLines(FileName).Skip(11).Take(1).First(); textBox12.Text = site12;
            string site13 = File.ReadLines(FileName).Skip(12).Take(1).First(); textBox13.Text = site13;
            string site14 = File.ReadLines(FileName).Skip(13).Take(1).First(); textBox14.Text = site14;
            string site15 = File.ReadLines(FileName).Skip(14).Take(1).First(); textBox15.Text = site15;
            try { TcpClient c1 = new TcpClient(); c1.Connect(site1, 1444); button1.BackColor = Color.Green; }
            catch { button1.BackColor = Color.Red; }
            try { TcpClient c2 = new TcpClient(); c2.Connect(site2, 1444); button2.BackColor = Color.Green; }
            catch { button2.BackColor = Color.Red; }
            try { TcpClient c3 = new TcpClient(); c3.Connect(site3, 1444); button3.BackColor = Color.Green; }
            catch { button3.BackColor = Color.Red; }
            try { TcpClient c4 = new TcpClient(); c4.Connect(site4, 1444); button4.BackColor = Color.Green; }
            catch { button4.BackColor = Color.Red; }
            try { TcpClient c5 = new TcpClient(); c5.Connect(site5, 1444); button5.BackColor = Color.Green; }
            catch { button5.BackColor = Color.Red; }
            try { TcpClient c6 = new TcpClient(); c6.Connect(site6, 1444); button6.BackColor = Color.Green; }
            catch { button6.BackColor = Color.Red; }
            try { TcpClient c7 = new TcpClient(); c7.Connect(site7, 1444); button7.BackColor = Color.Green; }
            catch { button7.BackColor = Color.Red; }
            try { TcpClient c8 = new TcpClient(); c8.Connect(site8, 1444); button8.BackColor = Color.Green; }
            catch { button8.BackColor = Color.Red; }
            try { TcpClient c9 = new TcpClient(); c9.Connect(site9, 1444); button9.BackColor = Color.Green; }
            catch { button9.BackColor = Color.Red; }
            try { TcpClient c10 = new TcpClient(); c10.Connect(site10, 1444); button10.BackColor = Color.Green; }
            catch { button10.BackColor = Color.Red; }
            try { TcpClient c11 = new TcpClient(); c11.Connect(site11, 1444); button11.BackColor = Color.Green; }
            catch { button11.BackColor = Color.Red; }
            try { TcpClient c12 = new TcpClient(); c12.Connect(site12, 1444); button12.BackColor = Color.Green; }
            catch { button12.BackColor = Color.Red; }
            try { TcpClient c13 = new TcpClient(); c13.Connect(site13, 1444); button13.BackColor = Color.Green; }
            catch { button13.BackColor = Color.Red; }
            try { TcpClient c14 = new TcpClient(); c14.Connect(site14, 1444); button14.BackColor = Color.Green; }
            catch { button14.BackColor = Color.Red; }
            try { TcpClient c15 = new TcpClient(); c15.Connect(site15, 1444); button15.BackColor = Color.Green; }
            catch { button15.BackColor = Color.Red; }
        }


        void Refresh2_Click(Object sender,
                       EventArgs f)
        {

    string FileName = "c:\\multisitelist.txt";

   
    string site16 = File.ReadLines(FileName).Skip(15).Take(1).First(); textBox16.Text = site16;
    string site17 = File.ReadLines(FileName).Skip(16).Take(1).First(); textBox17.Text = site17;
    string site18 = File.ReadLines(FileName).Skip(17).Take(1).First(); textBox18.Text = site18;
    string site19 = File.ReadLines(FileName).Skip(18).Take(1).First(); textBox19.Text = site19;
    string site20 = File.ReadLines(FileName).Skip(19).Take(1).First(); textBox20.Text = site20;
    string site21 = File.ReadLines(FileName).Skip(20).Take(1).First(); textBox21.Text = site21;
    string site22 = File.ReadLines(FileName).Skip(21).Take(1).First(); textBox22.Text = site22;
    string site23 = File.ReadLines(FileName).Skip(22).Take(1).First(); textBox23.Text = site23;
    string site24 = File.ReadLines(FileName).Skip(23).Take(1).First(); textBox24.Text = site24;
    string site25 = File.ReadLines(FileName).Skip(24).Take(1).First(); textBox25.Text = site25;
    string site26 = File.ReadLines(FileName).Skip(25).Take(1).First(); textBox26.Text = site26;
    string site27 = File.ReadLines(FileName).Skip(26).Take(1).First(); textBox27.Text = site27;
    string site28 = File.ReadLines(FileName).Skip(27).Take(1).First(); textBox28.Text = site28;
    string site29 = File.ReadLines(FileName).Skip(28).Take(1).First(); textBox29.Text = site29;
    string site30 = File.ReadLines(FileName).Skip(29).Take(1).First(); textBox30.Text = site30;

    try { TcpClient c16 = new TcpClient(); c16.Connect(site16, 1444); button16.BackColor = Color.Green; }
    catch { button16.BackColor = Color.Red; }
    try { TcpClient c17 = new TcpClient(); c17.Connect(site17, 1444); button17.BackColor = Color.Green; }
    catch { button17.BackColor = Color.Red; }
    try { TcpClient c18 = new TcpClient(); c18.Connect(site18, 1444); button18.BackColor = Color.Green; }
    catch { button18.BackColor = Color.Red; }
    try { TcpClient c19 = new TcpClient(); c19.Connect(site19, 1444); button19.BackColor = Color.Green; }
    catch { button19.BackColor = Color.Red; }
    try { TcpClient c20 = new TcpClient(); c20.Connect(site20, 1444); button20.BackColor = Color.Green; }
    catch { button20.BackColor = Color.Red; }
    try { TcpClient c21 = new TcpClient(); c21.Connect(site21, 1444); button21.BackColor = Color.Green; }
    catch { button21.BackColor = Color.Red; }
    try { TcpClient c22 = new TcpClient(); c22.Connect(site22, 1444); button22.BackColor = Color.Green; }
    catch { button22.BackColor = Color.Red; }
    try { TcpClient c23 = new TcpClient(); c23.Connect(site23, 1444); button23.BackColor = Color.Green; }
    catch { button23.BackColor = Color.Red; }
    try { TcpClient c24 = new TcpClient(); c24.Connect(site24, 1444); button24.BackColor = Color.Green; }
    catch { button24.BackColor = Color.Red; }
    try { TcpClient c25 = new TcpClient(); c25.Connect(site25, 1444); button25.BackColor = Color.Green; }
    catch { button25.BackColor = Color.Red; }
    try { TcpClient c26 = new TcpClient(); c26.Connect(site26, 1444); button26.BackColor = Color.Green; }
    catch { button26.BackColor = Color.Red; }
    try { TcpClient c27 = new TcpClient(); c27.Connect(site27, 1444); button27.BackColor = Color.Green; }
    catch { button27.BackColor = Color.Red; }
    try { TcpClient c28 = new TcpClient(); c28.Connect(site28, 1444); button28.BackColor = Color.Green; }
    catch { button28.BackColor = Color.Red; }
    try { TcpClient c29 = new TcpClient(); c29.Connect(site29, 1444); button29.BackColor = Color.Green; }
    catch { button29.BackColor = Color.Red; }
    try { TcpClient c30 = new TcpClient(); c30.Connect(site30, 1444); button30.BackColor = Color.Green; }
    catch { button30.BackColor = Color.Red; }
     
        }



        void Refresh3_Click(Object sender,
                       EventArgs g)
        {

          string FileName = "c:\\multisitelist.txt";
  
    string site31 = File.ReadLines(FileName).Skip(30).Take(1).First(); textBox31.Text = site31;
    string site32 = File.ReadLines(FileName).Skip(31).Take(1).First(); textBox32.Text = site32;
    string site33 = File.ReadLines(FileName).Skip(32).Take(1).First(); textBox33.Text = site33;
    string site34 = File.ReadLines(FileName).Skip(33).Take(1).First(); textBox34.Text = site34;
    string site35 = File.ReadLines(FileName).Skip(34).Take(1).First(); textBox35.Text = site35;
    string site36 = File.ReadLines(FileName).Skip(35).Take(1).First(); textBox36.Text = site36;
    string site37 = File.ReadLines(FileName).Skip(36).Take(1).First(); textBox37.Text = site37;
    string site38 = File.ReadLines(FileName).Skip(37).Take(1).First(); textBox38.Text = site38;
    string site39 = File.ReadLines(FileName).Skip(38).Take(1).First(); textBox39.Text = site39;
    string site40 = File.ReadLines(FileName).Skip(39).Take(1).First(); textBox40.Text = site40;
    string site41 = File.ReadLines(FileName).Skip(40).Take(1).First(); textBox41.Text = site41;
    string site42 = File.ReadLines(FileName).Skip(41).Take(1).First(); textBox42.Text = site42;
    string site43 = File.ReadLines(FileName).Skip(42).Take(1).First(); textBox43.Text = site43;
    string site44 = File.ReadLines(FileName).Skip(43).Take(1).First(); textBox44.Text = site44;
    string site45 = File.ReadLines(FileName).Skip(44).Take(1).First(); textBox45.Text = site45;

    try { TcpClient c31 = new TcpClient(); c31.Connect(site31, 1444); button31.BackColor = Color.Green; }
    catch { button31.BackColor = Color.Red; }
    try { TcpClient c32 = new TcpClient(); c32.Connect(site32, 1444); button32.BackColor = Color.Green; }
    catch { button32.BackColor = Color.Red; }
    try { TcpClient c33 = new TcpClient(); c33.Connect(site33, 1444); button33.BackColor = Color.Green; }
    catch { button33.BackColor = Color.Red; }
    try { TcpClient c34 = new TcpClient(); c34.Connect(site34, 1444); button34.BackColor = Color.Green; }
    catch { button34.BackColor = Color.Red; }
    try { TcpClient c35 = new TcpClient(); c35.Connect(site35, 1444); button35.BackColor = Color.Green; }
    catch { button35.BackColor = Color.Red; }
    try { TcpClient c36 = new TcpClient(); c36.Connect(site36, 1444); button36.BackColor = Color.Green; }
    catch { button36.BackColor = Color.Red; }
    try { TcpClient c37 = new TcpClient(); c37.Connect(site37, 1444); button37.BackColor = Color.Green; }
    catch { button37.BackColor = Color.Red; }
    try { TcpClient c38 = new TcpClient(); c38.Connect(site38, 1444); button38.BackColor = Color.Green; }
    catch { button38.BackColor = Color.Red; }
    try { TcpClient c39 = new TcpClient(); c39.Connect(site39, 1444); button39.BackColor = Color.Green; }
    catch { button39.BackColor = Color.Red; }
    try { TcpClient c40 = new TcpClient(); c40.Connect(site40, 1444); button40.BackColor = Color.Green; }
    catch { button40.BackColor = Color.Red; }
    try { TcpClient c41 = new TcpClient(); c41.Connect(site41, 1444); button41.BackColor = Color.Green; }
    catch { button41.BackColor = Color.Red; }
    try { TcpClient c42 = new TcpClient(); c42.Connect(site42, 1444); button42.BackColor = Color.Green; }
    catch { button42.BackColor = Color.Red; }
    try { TcpClient c43 = new TcpClient(); c43.Connect(site43, 1444); button43.BackColor = Color.Green; }
    catch { button43.BackColor = Color.Red; }
    try { TcpClient c44 = new TcpClient(); c44.Connect(site44, 1444); button44.BackColor = Color.Green; }
    catch { button44.BackColor = Color.Red; }
    try { TcpClient c45 = new TcpClient(); c45.Connect(site45, 1444); button45.BackColor = Color.Green; }
    catch { button45.BackColor = Color.Red; }

        }


        void Refresh4_Click(Object sender,
                    EventArgs h)
        {

            string FileName = "c:\\multisitelist.txt";  
            
    string site46 = File.ReadLines(FileName).Skip(45).Take(1).First(); textBox46.Text = site46;
    string site47 = File.ReadLines(FileName).Skip(46).Take(1).First(); textBox47.Text = site47;
    string site48 = File.ReadLines(FileName).Skip(47).Take(1).First(); textBox48.Text = site48;
    string site49 = File.ReadLines(FileName).Skip(48).Take(1).First(); textBox49.Text = site49;
    string site50 = File.ReadLines(FileName).Skip(49).Take(1).First(); textBox50.Text = site50;
    string site51 = File.ReadLines(FileName).Skip(50).Take(1).First(); textBox51.Text = site51;
    string site52 = File.ReadLines(FileName).Skip(51).Take(1).First(); textBox52.Text = site52;
    string site53 = File.ReadLines(FileName).Skip(52).Take(1).First(); textBox53.Text = site53;
    string site54 = File.ReadLines(FileName).Skip(53).Take(1).First(); textBox54.Text = site54;
    string site55 = File.ReadLines(FileName).Skip(54).Take(1).First(); textBox55.Text = site55;
    string site56 = File.ReadLines(FileName).Skip(55).Take(1).First(); textBox56.Text = site56;
    string site57 = File.ReadLines(FileName).Skip(56).Take(1).First(); textBox57.Text = site57;
    string site58 = File.ReadLines(FileName).Skip(57).Take(1).First(); textBox58.Text = site58;
    string site59 = File.ReadLines(FileName).Skip(58).Take(1).First(); textBox59.Text = site59;
    string site60 = File.ReadLines(FileName).Skip(59).Take(1).First(); textBox60.Text = site60;

   




   
   
    try { TcpClient c46 = new TcpClient(); c46.Connect(site46, 1444); button46.BackColor = Color.Green; }
    catch { button46.BackColor = Color.Red; }
    try { TcpClient c47 = new TcpClient(); c47.Connect(site47, 1444); button47.BackColor = Color.Green; }
    catch { button47.BackColor = Color.Red; }
    try { TcpClient c48 = new TcpClient(); c48.Connect(site48, 1444); button48.BackColor = Color.Green; }
    catch { button48.BackColor = Color.Red; }
    try { TcpClient c49 = new TcpClient(); c49.Connect(site49, 1444); button49.BackColor = Color.Green; }
    catch { button49.BackColor = Color.Red; }
    try { TcpClient c50 = new TcpClient(); c50.Connect(site50, 1444); button50.BackColor = Color.Green; }
    catch { button50.BackColor = Color.Red; }
    try { TcpClient c51 = new TcpClient(); c51.Connect(site51, 1444); button51.BackColor = Color.Green; }
    catch { button51.BackColor = Color.Red; }
    try { TcpClient c52 = new TcpClient(); c52.Connect(site52, 1444); button52.BackColor = Color.Green; }
    catch { button52.BackColor = Color.Red; }
    try { TcpClient c53 = new TcpClient(); c53.Connect(site53, 1444); button53.BackColor = Color.Green; }
    catch { button53.BackColor = Color.Red; }
    try { TcpClient c54 = new TcpClient(); c54.Connect(site54, 1444); button54.BackColor = Color.Green; }
    catch { button54.BackColor = Color.Red; }
    try { TcpClient c55 = new TcpClient(); c55.Connect(site55, 1444); button55.BackColor = Color.Green; }
    catch { button55.BackColor = Color.Red; }
    try { TcpClient c56 = new TcpClient(); c56.Connect(site56, 1444); button56.BackColor = Color.Green; }
    catch { button56.BackColor = Color.Red; }
    try { TcpClient c57 = new TcpClient(); c57.Connect(site57, 1444); button57.BackColor = Color.Green; }
    catch { button57.BackColor = Color.Red; }
    try { TcpClient c58 = new TcpClient(); c58.Connect(site58, 1444); button58.BackColor = Color.Green; }
    catch { button58.BackColor = Color.Red; }
    try { TcpClient c59 = new TcpClient(); c59.Connect(site59, 1444); button59.BackColor = Color.Green; }
    catch { button59.BackColor = Color.Red; }
    try { TcpClient c60 = new TcpClient(); c60.Connect(site60, 1444); button60.BackColor = Color.Green; }
    catch { button60.BackColor = Color.Red; }
        }




            //new shiznit for each button click to refresh them one at a time for further expedienceyyyyy

void Refresh001_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site1 = File.ReadLines(FileName).Skip(0).Take(1).First(); textBox1.Text = site1; try { TcpClient c1 = new TcpClient(); c1.Connect(site1, 1444); button1.BackColor = Color.Green; }  catch { button1.BackColor = Color.Red; } } 
void Refresh002_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site2 = File.ReadLines(FileName).Skip(1).Take(1).First(); textBox2.Text = site2; try { TcpClient c2 = new TcpClient(); c2.Connect(site2, 1444); button2.BackColor = Color.Green; }  catch { button2.BackColor = Color.Red; } } 
void Refresh003_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site3 = File.ReadLines(FileName).Skip(2).Take(1).First(); textBox3.Text = site3; try { TcpClient c3 = new TcpClient(); c3.Connect(site3, 1444); button3.BackColor = Color.Green; }  catch { button3.BackColor = Color.Red; } } 
void Refresh004_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site4 = File.ReadLines(FileName).Skip(3).Take(1).First(); textBox4.Text = site4; try { TcpClient c4 = new TcpClient(); c4.Connect(site4, 1444); button4.BackColor = Color.Green; }  catch { button4.BackColor = Color.Red; } } 
void Refresh005_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site5 = File.ReadLines(FileName).Skip(4).Take(1).First(); textBox5.Text = site5; try { TcpClient c5 = new TcpClient(); c5.Connect(site5, 1444); button5.BackColor = Color.Green; }  catch { button5.BackColor = Color.Red; } } 
void Refresh006_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site6 = File.ReadLines(FileName).Skip(5).Take(1).First(); textBox6.Text = site6; try { TcpClient c6 = new TcpClient(); c6.Connect(site6, 1444); button6.BackColor = Color.Green; }  catch { button6.BackColor = Color.Red; } } 
void Refresh007_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site7 = File.ReadLines(FileName).Skip(6).Take(1).First(); textBox7.Text = site7; try { TcpClient c7 = new TcpClient(); c7.Connect(site7, 1444); button7.BackColor = Color.Green; }  catch { button7.BackColor = Color.Red; } } 
void Refresh008_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site8 = File.ReadLines(FileName).Skip(7).Take(1).First(); textBox8.Text = site8; try { TcpClient c8 = new TcpClient(); c8.Connect(site8, 1444); button8.BackColor = Color.Green; }  catch { button8.BackColor = Color.Red; } } 
void Refresh009_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site9 = File.ReadLines(FileName).Skip(8).Take(1).First(); textBox9.Text = site9; try { TcpClient c9 = new TcpClient(); c9.Connect(site9, 1444); button9.BackColor = Color.Green; }  catch { button9.BackColor = Color.Red; } } 
void Refresh0010_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site10 = File.ReadLines(FileName).Skip(9).Take(1).First(); textBox10.Text = site10; try { TcpClient c10 = new TcpClient(); c10.Connect(site10, 1444); button10.BackColor = Color.Green; }  catch { button10.BackColor = Color.Red; } } 
void Refresh0011_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site11 = File.ReadLines(FileName).Skip(10).Take(1).First(); textBox11.Text = site11; try { TcpClient c11 = new TcpClient(); c11.Connect(site11, 1444); button11.BackColor = Color.Green; }  catch { button11.BackColor = Color.Red; } } 
void Refresh0012_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site12 = File.ReadLines(FileName).Skip(11).Take(1).First(); textBox12.Text = site12; try { TcpClient c12 = new TcpClient(); c12.Connect(site12, 1444); button12.BackColor = Color.Green; }  catch { button12.BackColor = Color.Red; } } 
void Refresh0013_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site13 = File.ReadLines(FileName).Skip(12).Take(1).First(); textBox13.Text = site13; try { TcpClient c13 = new TcpClient(); c13.Connect(site13, 1444); button13.BackColor = Color.Green; }  catch { button13.BackColor = Color.Red; } } 
void Refresh0014_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site14 = File.ReadLines(FileName).Skip(13).Take(1).First(); textBox14.Text = site14; try { TcpClient c14 = new TcpClient(); c14.Connect(site14, 1444); button14.BackColor = Color.Green; }  catch { button14.BackColor = Color.Red; } } 
void Refresh0015_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site15 = File.ReadLines(FileName).Skip(14).Take(1).First(); textBox15.Text = site15; try { TcpClient c15 = new TcpClient(); c15.Connect(site15, 1444); button15.BackColor = Color.Green; }  catch { button15.BackColor = Color.Red; } } 
void Refresh0016_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site16 = File.ReadLines(FileName).Skip(15).Take(1).First(); textBox16.Text = site16; try { TcpClient c16 = new TcpClient(); c16.Connect(site16, 1444); button16.BackColor = Color.Green; }  catch { button16.BackColor = Color.Red; } } 
void Refresh0017_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site17 = File.ReadLines(FileName).Skip(16).Take(1).First(); textBox17.Text = site17; try { TcpClient c17 = new TcpClient(); c17.Connect(site17, 1444); button17.BackColor = Color.Green; }  catch { button17.BackColor = Color.Red; } } 
void Refresh0018_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site18 = File.ReadLines(FileName).Skip(17).Take(1).First(); textBox18.Text = site18; try { TcpClient c18 = new TcpClient(); c18.Connect(site18, 1444); button18.BackColor = Color.Green; }  catch { button18.BackColor = Color.Red; } } 
void Refresh0019_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site19 = File.ReadLines(FileName).Skip(18).Take(1).First(); textBox19.Text = site19; try { TcpClient c19 = new TcpClient(); c19.Connect(site19, 1444); button19.BackColor = Color.Green; }  catch { button19.BackColor = Color.Red; } } 
void Refresh0020_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site20 = File.ReadLines(FileName).Skip(19).Take(1).First(); textBox20.Text = site20; try { TcpClient c20 = new TcpClient(); c20.Connect(site20, 1444); button20.BackColor = Color.Green; }  catch { button20.BackColor = Color.Red; } } 
void Refresh0021_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site21 = File.ReadLines(FileName).Skip(20).Take(1).First(); textBox21.Text = site21; try { TcpClient c21 = new TcpClient(); c21.Connect(site21, 1444); button21.BackColor = Color.Green; }  catch { button21.BackColor = Color.Red; } } 
void Refresh0022_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site22 = File.ReadLines(FileName).Skip(21).Take(1).First(); textBox22.Text = site22; try { TcpClient c22 = new TcpClient(); c22.Connect(site22, 1444); button22.BackColor = Color.Green; }  catch { button22.BackColor = Color.Red; } } 
void Refresh0023_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site23 = File.ReadLines(FileName).Skip(22).Take(1).First(); textBox23.Text = site23; try { TcpClient c23 = new TcpClient(); c23.Connect(site23, 1444); button23.BackColor = Color.Green; }  catch { button23.BackColor = Color.Red; } } 
void Refresh0024_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site24 = File.ReadLines(FileName).Skip(23).Take(1).First(); textBox24.Text = site24; try { TcpClient c24 = new TcpClient(); c24.Connect(site24, 1444); button24.BackColor = Color.Green; }  catch { button24.BackColor = Color.Red; } } 
void Refresh0025_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site25 = File.ReadLines(FileName).Skip(24).Take(1).First(); textBox25.Text = site25; try { TcpClient c25 = new TcpClient(); c25.Connect(site25, 1444); button25.BackColor = Color.Green; }  catch { button25.BackColor = Color.Red; } } 
void Refresh0026_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site26 = File.ReadLines(FileName).Skip(25).Take(1).First(); textBox26.Text = site26; try { TcpClient c26 = new TcpClient(); c26.Connect(site26, 1444); button26.BackColor = Color.Green; }  catch { button26.BackColor = Color.Red; } } 
void Refresh0027_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site27 = File.ReadLines(FileName).Skip(26).Take(1).First(); textBox27.Text = site27; try { TcpClient c27 = new TcpClient(); c27.Connect(site27, 1444); button27.BackColor = Color.Green; }  catch { button27.BackColor = Color.Red; } } 
void Refresh0028_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site28 = File.ReadLines(FileName).Skip(27).Take(1).First(); textBox28.Text = site28; try { TcpClient c28 = new TcpClient(); c28.Connect(site28, 1444); button28.BackColor = Color.Green; }  catch { button28.BackColor = Color.Red; } } 
void Refresh0029_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site29 = File.ReadLines(FileName).Skip(28).Take(1).First(); textBox29.Text = site29; try { TcpClient c29 = new TcpClient(); c29.Connect(site29, 1444); button29.BackColor = Color.Green; }  catch { button29.BackColor = Color.Red; } } 
void Refresh0030_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site30 = File.ReadLines(FileName).Skip(29).Take(1).First(); textBox30.Text = site30; try { TcpClient c30 = new TcpClient(); c30.Connect(site30, 1444); button30.BackColor = Color.Green; }  catch { button30.BackColor = Color.Red; } } 
void Refresh0031_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site31 = File.ReadLines(FileName).Skip(30).Take(1).First(); textBox31.Text = site31; try { TcpClient c31 = new TcpClient(); c31.Connect(site31, 1444); button31.BackColor = Color.Green; }  catch { button31.BackColor = Color.Red; } } 
void Refresh0032_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site32 = File.ReadLines(FileName).Skip(31).Take(1).First(); textBox32.Text = site32; try { TcpClient c32 = new TcpClient(); c32.Connect(site32, 1444); button32.BackColor = Color.Green; }  catch { button32.BackColor = Color.Red; } } 
void Refresh0033_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site33 = File.ReadLines(FileName).Skip(32).Take(1).First(); textBox33.Text = site33; try { TcpClient c33 = new TcpClient(); c33.Connect(site33, 1444); button33.BackColor = Color.Green; }  catch { button33.BackColor = Color.Red; } } 
void Refresh0034_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site34 = File.ReadLines(FileName).Skip(33).Take(1).First(); textBox34.Text = site34; try { TcpClient c34 = new TcpClient(); c34.Connect(site34, 1444); button34.BackColor = Color.Green; }  catch { button34.BackColor = Color.Red; } } 
void Refresh0035_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site35 = File.ReadLines(FileName).Skip(34).Take(1).First(); textBox35.Text = site35; try { TcpClient c35 = new TcpClient(); c35.Connect(site35, 1444); button35.BackColor = Color.Green; }  catch { button35.BackColor = Color.Red; } } 
void Refresh0036_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site36 = File.ReadLines(FileName).Skip(35).Take(1).First(); textBox36.Text = site36; try { TcpClient c36 = new TcpClient(); c36.Connect(site36, 1444); button36.BackColor = Color.Green; }  catch { button36.BackColor = Color.Red; } } 
void Refresh0037_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site37 = File.ReadLines(FileName).Skip(36).Take(1).First(); textBox37.Text = site37; try { TcpClient c37 = new TcpClient(); c37.Connect(site37, 1444); button37.BackColor = Color.Green; }  catch { button37.BackColor = Color.Red; } } 
void Refresh0038_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site38 = File.ReadLines(FileName).Skip(37).Take(1).First(); textBox38.Text = site38; try { TcpClient c38 = new TcpClient(); c38.Connect(site38, 1444); button38.BackColor = Color.Green; }  catch { button38.BackColor = Color.Red; } } 
void Refresh0039_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site39 = File.ReadLines(FileName).Skip(38).Take(1).First(); textBox39.Text = site39; try { TcpClient c39 = new TcpClient(); c39.Connect(site39, 1444); button39.BackColor = Color.Green; }  catch { button39.BackColor = Color.Red; } } 
void Refresh0040_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site40 = File.ReadLines(FileName).Skip(39).Take(1).First(); textBox40.Text = site40; try { TcpClient c40 = new TcpClient(); c40.Connect(site40, 1444); button40.BackColor = Color.Green; }  catch { button40.BackColor = Color.Red; } } 
void Refresh0041_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site41 = File.ReadLines(FileName).Skip(40).Take(1).First(); textBox41.Text = site41; try { TcpClient c41 = new TcpClient(); c41.Connect(site41, 1444); button41.BackColor = Color.Green; }  catch { button41.BackColor = Color.Red; } } 
void Refresh0042_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site42 = File.ReadLines(FileName).Skip(41).Take(1).First(); textBox42.Text = site42; try { TcpClient c42 = new TcpClient(); c42.Connect(site42, 1444); button42.BackColor = Color.Green; }  catch { button42.BackColor = Color.Red; } } 
void Refresh0043_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site43 = File.ReadLines(FileName).Skip(42).Take(1).First(); textBox43.Text = site43; try { TcpClient c43 = new TcpClient(); c43.Connect(site43, 1444); button43.BackColor = Color.Green; }  catch { button43.BackColor = Color.Red; } } 
void Refresh0044_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site44 = File.ReadLines(FileName).Skip(43).Take(1).First(); textBox44.Text = site44; try { TcpClient c44 = new TcpClient(); c44.Connect(site44, 1444); button44.BackColor = Color.Green; }  catch { button44.BackColor = Color.Red; } } 
void Refresh0045_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site45 = File.ReadLines(FileName).Skip(44).Take(1).First(); textBox45.Text = site45; try { TcpClient c45 = new TcpClient(); c45.Connect(site45, 1444); button45.BackColor = Color.Green; }  catch { button45.BackColor = Color.Red; } } 
void Refresh0046_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site46 = File.ReadLines(FileName).Skip(45).Take(1).First(); textBox46.Text = site46; try { TcpClient c46 = new TcpClient(); c46.Connect(site46, 1444); button46.BackColor = Color.Green; }  catch { button46.BackColor = Color.Red; } } 
void Refresh0047_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site47 = File.ReadLines(FileName).Skip(46).Take(1).First(); textBox47.Text = site47; try { TcpClient c47 = new TcpClient(); c47.Connect(site47, 1444); button47.BackColor = Color.Green; }  catch { button47.BackColor = Color.Red; } } 
void Refresh0048_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site48 = File.ReadLines(FileName).Skip(47).Take(1).First(); textBox48.Text = site48; try { TcpClient c48 = new TcpClient(); c48.Connect(site48, 1444); button48.BackColor = Color.Green; }  catch { button48.BackColor = Color.Red; } } 
void Refresh0049_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site49 = File.ReadLines(FileName).Skip(48).Take(1).First(); textBox49.Text = site49; try { TcpClient c49 = new TcpClient(); c49.Connect(site49, 1444); button49.BackColor = Color.Green; }  catch { button49.BackColor = Color.Red; } } 
void Refresh0050_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site50 = File.ReadLines(FileName).Skip(49).Take(1).First(); textBox50.Text = site50; try { TcpClient c50 = new TcpClient(); c50.Connect(site50, 1444); button50.BackColor = Color.Green; }  catch { button50.BackColor = Color.Red; } } 
void Refresh0051_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site51 = File.ReadLines(FileName).Skip(50).Take(1).First(); textBox51.Text = site51; try { TcpClient c51 = new TcpClient(); c51.Connect(site51, 1444); button51.BackColor = Color.Green; }  catch { button51.BackColor = Color.Red; } } 
void Refresh0052_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site52 = File.ReadLines(FileName).Skip(51).Take(1).First(); textBox52.Text = site52; try { TcpClient c52 = new TcpClient(); c52.Connect(site52, 1444); button52.BackColor = Color.Green; }  catch { button52.BackColor = Color.Red; } } 
void Refresh0053_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site53 = File.ReadLines(FileName).Skip(52).Take(1).First(); textBox53.Text = site53; try { TcpClient c53 = new TcpClient(); c53.Connect(site53, 1444); button53.BackColor = Color.Green; }  catch { button53.BackColor = Color.Red; } } 
void Refresh0054_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site54 = File.ReadLines(FileName).Skip(53).Take(1).First(); textBox54.Text = site54; try { TcpClient c54 = new TcpClient(); c54.Connect(site54, 1444); button54.BackColor = Color.Green; }  catch { button54.BackColor = Color.Red; } } 
void Refresh0055_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site55 = File.ReadLines(FileName).Skip(54).Take(1).First(); textBox55.Text = site55; try { TcpClient c55 = new TcpClient(); c55.Connect(site55, 1444); button55.BackColor = Color.Green; }  catch { button55.BackColor = Color.Red; } } 
void Refresh0056_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site56 = File.ReadLines(FileName).Skip(55).Take(1).First(); textBox56.Text = site56; try { TcpClient c56 = new TcpClient(); c56.Connect(site56, 1444); button56.BackColor = Color.Green; }  catch { button56.BackColor = Color.Red; } } 
void Refresh0057_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site57 = File.ReadLines(FileName).Skip(56).Take(1).First(); textBox57.Text = site57; try { TcpClient c57 = new TcpClient(); c57.Connect(site57, 1444); button57.BackColor = Color.Green; }  catch { button57.BackColor = Color.Red; } } 
void Refresh0058_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site58 = File.ReadLines(FileName).Skip(57).Take(1).First(); textBox58.Text = site58; try { TcpClient c58 = new TcpClient(); c58.Connect(site58, 1444); button58.BackColor = Color.Green; }  catch { button58.BackColor = Color.Red; } } 
void Refresh0059_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site59 = File.ReadLines(FileName).Skip(58).Take(1).First(); textBox59.Text = site59; try { TcpClient c59 = new TcpClient(); c59.Connect(site59, 1444); button59.BackColor = Color.Green; }  catch { button59.BackColor = Color.Red; } } 
void Refresh0060_Click(Object sender,EventArgs e) {string FileName = "c:\\multisitelist.txt"; string site60 = File.ReadLines(FileName).Skip(59).Take(1).First(); textBox60.Text = site60; try { TcpClient c60 = new TcpClient(); c60.Connect(site60, 1444); button60.BackColor = Color.Green; }  catch { button60.BackColor = Color.Red; } } 

    



















        }
    }

