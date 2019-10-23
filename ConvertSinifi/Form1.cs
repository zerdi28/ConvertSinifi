using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertSinifi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            string sayi = "123";
            byte s1 = Convert.ToByte(sayi);
            sbyte s2 = Convert.ToSByte(sayi);
            short s3 = Convert.ToInt16(sayi);
            ushort s4 = Convert.ToUInt16(sayi);
            int s5 = Convert.ToInt32(sayi);
            uint s6 = Convert.ToUInt32(sayi);
            long s7 = Convert.ToInt64(sayi);
            ulong s8 = Convert.ToUInt64(sayi);
            float s9 = Convert.ToSingle(sayi);
            double s10 = Convert.ToDouble(sayi);
            decimal s11 = Convert.ToDecimal(sayi);


            string gelensayi1 = Convert.ToString(s11);
            string gelensayi2 = s11.ToString();//bu yontemı kullanmak daha mantıklı oluyor.


        }
    }
}
