using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HslControlsDemo
{
    public partial class FormDigitalInput : FormContent
    {
        public FormDigitalInput( )
        {
            InitializeComponent( );
        }

        private void FormDigitalInput_Load( object sender, EventArgs e )
        {
            hslDigitalInput1.OnOk = m => { MessageBox.Show( m ); textBox5.Text = m; };
        }

        private void TextBox1_Click( object sender, EventArgs e )
        {
            HslControls.Forms.FormHslDigitalInput formHslDigital = new HslControls.Forms.FormHslDigitalInput( );
            formHslDigital.OnOk = m =>
            {
                textBox1.Text = m;
                formHslDigital.Close( );
            };
            formHslDigital.ShowDialog( );
        }

        private void TextBox2_Click( object sender, EventArgs e )
        {
            HslControls.Forms.FormHslDigitalInput formHslDigital = new HslControls.Forms.FormHslDigitalInput( );
            formHslDigital.OnOk = m =>
            {
                textBox2.Text = m;
                formHslDigital.Close( );
            };
            formHslDigital.DigitalInput.EnableNegative = false;                // 禁用负号
            formHslDigital.DigitalInput.EnableSpot = false;                    // 禁用小数点
            formHslDigital.ShowDialog( );
        }

        private void TextBox3_Click( object sender, EventArgs e )
        {
            HslControls.Forms.FormHslDigitalInput formHslDigital = new HslControls.Forms.FormHslDigitalInput( );
            formHslDigital.OnOk = m =>
            {
                textBox3.Text = m;
                formHslDigital.Close( );
            };
            formHslDigital.DigitalInput.EnableNegative = false;                // 禁用负号
            formHslDigital.DigitalInput.EnableSpot = false;                    // 禁用小数点
            formHslDigital.DigitalInput.InputCheck = m =>                      // 添加验证100-200的范围
            {
                int value = int.Parse( m );
                if (value >= 100 && value <= 200) return true;
                return false;
            };
            formHslDigital.ShowDialog( );
        }

        private void HslDigitalInput1_Click( object sender, EventArgs e )
        {
            Control_Click( sender, e );
        }

        private void TextBox4_Click( object sender, EventArgs e )
        {
            HslControls.Forms.FormHslDigitalInput formHslDigital = new HslControls.Forms.FormHslDigitalInput( );
            formHslDigital.OnOk = m =>
            {
                textBox4.Text = m;
                formHslDigital.Close( );
            };
            formHslDigital.BackColor = Color.LightPink;
            formHslDigital.Font = new Font( "微软雅黑", 12f );                   // 设置字体
            formHslDigital.DigitalInput.EnableNegative = false;                // 禁用负号
            formHslDigital.DigitalInput.EnableSpot = false;                    // 禁用小数点
            formHslDigital.DigitalInput.LedForeColor = Color.LimeGreen;        // 设置LED的颜色
            formHslDigital.DigitalInput.InputCheck = m =>                      // 添加验证100-200的范围
            {
                int value = int.Parse( m );
                if (value >= 100 && value <= 200) return true;
                return false;
            };
            formHslDigital.ShowDialog( );
        }

        private void button1_Click( object sender, EventArgs e )
        {
            hslDigitalInput1.MaskChar = '-';
        }

        private void button2_Click( object sender, EventArgs e )
        {
            hslDigitalInput1.MaskChar = ':';
        }

        private void button3_Click( object sender, EventArgs e )
        {
            hslDigitalInput1.MaskChar = '\0';
        }
    }
}
